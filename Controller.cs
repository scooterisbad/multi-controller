using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace multi_controller
{
    internal class Controller
    {
        public event EventHandler<ClientArgs> ClientMoved;
        public event EventHandler<ClientArgs> ClientActivated;
        public event EventHandler<ClientArgs> ClientDeactivated;
        public event EventHandler<ClientArgs> ClientClosed;
        public event EventHandler ActivateController;
        public event EventHandler ControlModeChanged;

        public enum ControlMode
        {
            Multi,
            LeftRight,
        }

        private static Controller instance = new Controller();
        public static Controller Instance
        {
            get { return instance; }
        }

        private Collection collection;
        public Collection Collection
        {
            get { return collection; }
        }

        private bool multiClick = false;
        public bool MultiClick
        {
            get { return multiClick; }
            set
            {
                multiClick = value;

                foreach (Client client in collection.GetAllClients())
                {
                    client.Overlay.RenderCursor = multiClick;
                    client.Overlay.SetTransparency(!multiClick);
                }
                if (Properties.Settings.Default.ShowMultipleCursors)
                {
                    if (multiClick) Cursor.Hide();
                    else Cursor.Show();
                }

                UpdateBorders();
                foreach (Client client in collection.GetAllActiveClients())
                {
                    client.Overlay.Enable();
                }
            }
        }

        private ControlMode ctrlMode;
        public ControlMode CtrlMode
        {
            get { return ctrlMode; }
            set
            {
                ctrlMode = value;
                UpdateBorders();
                ControlModeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Controller()
        {
            collection = new Collection();

            CtrlMode = ControlMode.LeftRight;

            ClientClosed += Controller_ClientClosed;
        }

        private void Controller_ClientClosed(object sender, ClientArgs e)
        {
            foreach (Group group in collection.Groups)
            {
                if (group.GetClient(e.handle) != null)
                {
                    group.GetClient(e.handle).Overlay.Dispose();
                    group.RemoveClient(e.handle);
                    return;
                }
            }
        }

        /// <summary>
        /// Called whenever a change is made where the borders will change
        /// </summary>
        public void UpdateBorders()
        {
            if (CtrlMode == ControlMode.Multi)
            {
                Color borderColour;
                if (MultiClick) borderColour = Properties.Customisation.Default.MultiClickBorderColour;
                else borderColour = Properties.Customisation.Default.MultiBorderColour;

                foreach (Client client in collection.GetAllClients())
                {
                    client.Overlay.BorderColour = borderColour;
                }
            }
            else
            {
                Color leftBorderColour;
                Color rightBorderColour;
                if (MultiClick)
                {
                    leftBorderColour = Properties.Customisation.Default.LeftMultiClickBorderColour;
                    rightBorderColour = Properties.Customisation.Default.RightMultiClickBorderColour;
                }
                else
                {
                    leftBorderColour = Properties.Customisation.Default.LeftBorderColour;
                    rightBorderColour = Properties.Customisation.Default.RightBorderColour;
                }

                foreach (Client client in collection.GetAllClients(ControlSet.Left))
                {
                    client.Overlay.BorderColour = leftBorderColour;
                }
                foreach (Client client in collection.GetAllClients(ControlSet.Right))
                {
                    client.Overlay.BorderColour = rightBorderColour;
                }
            }

            RedrawBorders();
        }

        public void RedrawBorders()
        {
            foreach (Client client in collection.GetAllClients())
            {
                client.RedrawOverlay();
            }
        }

        /// <summary>
        /// Endpoint for all keyboard input
        /// </summary>
        /// <param name="msg">0x0100 if key press, 0x0101 if key up</param>
        /// <param name="wParam">Key code of the key</param>
        /// <param name="lParam">Unused</param>
        public void ProcessKey(Win32.WM msg, IntPtr wParam, IntPtr lParam)
        {
            List<Client> clients = collection.GetAllActiveClients();

            int keyCode = (int)wParam;

            if (msg == Win32.WM.KEYDOWN)
            {
                if (keyCode == Properties.Settings.Default.SwitchModeKey)
                {
                    if (CtrlMode == ControlMode.Multi) CtrlMode = ControlMode.LeftRight;
                    else if (CtrlMode == ControlMode.LeftRight) CtrlMode = ControlMode.Multi;

                    if (Properties.Settings.Default.ClydeCopiumMode) Collection.AllActive = !Collection.AllActive;

                    ActivateController?.Invoke(this, EventArgs.Empty);
                    return;
                }
                if (keyCode >= (int)Keys.D1 && keyCode <= (int)Keys.D9)
                {
                    collection.SetActiveGroup((keyCode - (int)Keys.D1) + 1);
                    ActivateController?.Invoke(this, EventArgs.Empty);
                    return;
                }
            }

            if (CtrlMode == ControlMode.LeftRight)
            {
                int leftOutput = KeyMap.GetOutputKey(keyCode, ControlSet.Left);
                int rightOutput = KeyMap.GetOutputKey(keyCode, ControlSet.Right);

                if (leftOutput != -1)
                {
                    keyCode = leftOutput;
                    foreach (Client client in collection.GetAllActiveClients(ControlSet.Left))
                    {
                        Win32.SendMessage(client.Handle, (int)msg, (IntPtr)keyCode, IntPtr.Zero);
                    }
                }
                if (rightOutput != -1)
                {
                    keyCode = rightOutput;
                    foreach (Client client in collection.GetAllActiveClients(ControlSet.Right))
                    {
                        Win32.SendMessage(client.Handle, (int)msg, (IntPtr)keyCode, IntPtr.Zero);
                    }
                }

                if (leftOutput != -1 || rightOutput != -1 || !Properties.Settings.Default.MirrorAllInLeftRightMode) return;
            }

            foreach (Client client in clients)
            {
                Win32.SendMessage(client.Handle, (int)msg, (IntPtr)keyCode, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Endpoint for all mouse input
        /// </summary>
        /// <param name="args"></param>
        /// <param name="handle">Handle of the window sent from</param>
        /// <param name="controlSet">Control set of the window sent from</param>
        public void ProcessMouse(MouseEventArgs args, IntPtr handle, ControlSet? controlSet)
        {
            List<Client> clients;
            if (controlSet != null) clients = collection.GetAllActiveClients(controlSet);
            else clients = collection.GetAllActiveClients();

            if (MultiClick && args.Button == MouseButtons.Left)
            {
                Win32.POINT pos = new Win32.POINT(args.X, args.Y);
                Win32.ScreenToClient(handle, ref pos);

                //Win32.RECT ogRECT = collection.ActiveGroup.GetClient(handle).GetRect();

                foreach (Client client in clients)
                {
                    /*Win32.RECT clientRect = client.GetRect();
                    float heightDiff = (clientRect.bottom - clientRect.top) / (ogRECT.bottom - ogRECT.top);
                    float widthDiff = (clientRect.right - clientRect.left) / (ogRECT.right - ogRECT.left);

                    pos.x = (int)(pos.x * widthDiff);
                    pos.y = (int)(pos.y * heightDiff);*/

                    IntPtr lParam = (IntPtr)(((pos.y) << 16) | ((pos.x) & 0xffff));

                    Win32.SendMessage(client.Handle, 0x0201, (IntPtr)1, lParam);
                    Win32.SendMessage(client.Handle, 0x0202, (IntPtr)0, lParam);
                }
                ActivateController?.Invoke(this, EventArgs.Empty);
            }
        }

        public virtual void OnClientMoved(ClientArgs e)
        {
            ClientMoved?.Invoke(this, e);
        }

        public virtual void OnClientActivated(ClientArgs e)
        {
            ClientActivated?.Invoke(this, e);
        }

        public virtual void OnClientDeactivated(ClientArgs e)
        {
            ClientDeactivated?.Invoke(this, e);
        }

        public virtual void OnClientClosed(ClientArgs e)
        {
            ClientClosed?.Invoke(this, e);
        }
    }

    public class ClientArgs : EventArgs
    {
        public IntPtr handle;

        public ClientArgs(IntPtr handle)
        {
            this.handle = handle;
        }
    }
}
