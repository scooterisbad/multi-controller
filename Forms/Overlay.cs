using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_controller.Forms
{
    /// <summary>
    /// Drawn on top of a client
    /// </summary>
    public partial class Overlay : Form
    {
        public event MouseEventHandler MouseMoved;

        private static Font font = new Font(FontFamily.GenericMonospace, 15, FontStyle.Bold);
        private static Icon fakeCursor = Properties.Resources.fakecursor;
        private static Icon realCursor = Properties.Resources.realcursor;

        private int initialStyle;

        private Client associatedClient;
        public Client AssociatedClient
        {
            get { return associatedClient; }
            set
            {
                associatedClient = value;
            }
        }

        private int borderWidth;
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        private Color borderColour;
        public Color BorderColour
        {
            get { return borderColour; }
            set
            {
                borderColour = value;
                InvalidateBorder();
            }
        }

        private bool renderCursor = false;
        public bool RenderCursor
        {
            get { return renderCursor; }
            set { renderCursor = value; }
        }

        private Icon usedCursor = fakeCursor;
        public Icon UsedCursor
        {
            get { return usedCursor; }
            set { usedCursor = value; }
        }

        private Win32.POINT cursorPos;
        private Rectangle cursorRect;

        private static ControlSet sideHovered;

        private static Win32.RECT ogRect;

        public Overlay(Client associatedClient)
        {
            InitializeComponent();

            this.associatedClient = associatedClient;

            initialStyle = Win32.GetWindowLong(this.Handle, Win32.GWL_EXSTYLE);
            SetTransparency(true);

            Win32.SetParent(this.Handle, associatedClient.Handle);

            borderWidth = Properties.Customisation.Default.BorderWidth;

            MouseMoved += Overlay_MouseMoved;
        }

        public void SetTransparency(bool transparent)
        {
            if (transparent)
            {
                Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, initialStyle | Win32.WS_EX_LAYERED | Win32.WS_EX_TRANSPARENT);
            }
            else
            {
                Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, initialStyle | Win32.WS_EX_NOACTIVATE);
            }
        }

        public void OnMouseMoved(object sender, MouseEventArgs e)
        {
            MouseMoved.Invoke(sender, e);
        }

        private void Overlay_MouseMoved(object sender, MouseEventArgs e)
        {
            if (Controller.Instance.CtrlMode == Controller.ControlMode.LeftRight && associatedClient.ControlSet != sideHovered) return;
            renderCursor = true;
            cursorPos = new Win32.POINT(e.X, e.Y);

            Win32.RECT thisRect = new Win32.RECT();
            Win32.GetClientRect(this.Handle, out thisRect);
            float heightDiff = (thisRect.bottom - thisRect.top) / (ogRect.bottom - ogRect.top);
            float widthDiff = (thisRect.right - thisRect.left) / (ogRect.right - ogRect.left);

            cursorPos.x = (int)(cursorPos.x * widthDiff);
            cursorPos.y = (int)(cursorPos.y * heightDiff);

            Invalidate(cursorRect);
        }

        public void Enable()
        {
            this.Show();
            //Win32.SetWindowPos(associatedClient.Handle, this.Handle, 0, 0, 0, 0, Win32.SetWindowPosFlags.DoNotActivate | Win32.SetWindowPosFlags.IgnoreMove | Win32.SetWindowPosFlags.IgnoreResize);
        }

        public void Disable()
        {
        }

        private void Overlay_Resize(object sender, EventArgs e)
        {
        }

        public void InvalidateBorder()
        {
            Rectangle top = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, borderWidth);
            Rectangle bottom = new Rectangle(this.Location.X, this.Size.Height - borderWidth, this.Size.Width, borderWidth);
            Rectangle left = new Rectangle(this.Location.X, this.Location.Y, borderWidth, this.Size.Height);
            Rectangle right = new Rectangle(this.Size.Width - borderWidth, this.Location.Y, borderWidth, this.Size.Height);
            Invalidate(top);
            Invalidate(bottom);
            Invalidate(left);
            Invalidate(right);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                borderColour, borderWidth, ButtonBorderStyle.Solid,
                borderColour, borderWidth, ButtonBorderStyle.Solid,
                borderColour, borderWidth, ButtonBorderStyle.Solid,
                borderColour, borderWidth, ButtonBorderStyle.Solid);

            if (Properties.Settings.Default.ShowMultipleCursors && RenderCursor)
            {
                cursorRect = new Rectangle(cursorPos.x, cursorPos.y, 35, 45);
                e.Graphics.DrawIcon(usedCursor, cursorRect);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)Win32.WM.LBUTTONDOWN)
            {
                MouseEventArgs mouseArgs = new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X, Cursor.Position.Y, 0);
                if (Controller.Instance.CtrlMode == Controller.ControlMode.LeftRight)
                {
                    Controller.Instance.ProcessMouse(mouseArgs, associatedClient.Handle, associatedClient.ControlSet);
                }
                else
                {
                    Controller.Instance.ProcessMouse(mouseArgs, associatedClient.Handle, null);
                }
            }
            else if (m.Msg == (int)Win32.WM.MOUSEMOVE)
            {
                sideHovered = associatedClient.ControlSet;

                Win32.GetClientRect(this.Handle, out ogRect);

                renderCursor = false;
                Invalidate(cursorRect);

                usedCursor = realCursor;

                Win32.POINT cursorPos = new Win32.POINT(Cursor.Position.X, Cursor.Position.Y);
                Win32.ScreenToClient(Handle, ref cursorPos);

                MouseEventArgs args = new MouseEventArgs(MouseButtons.None, 0, cursorPos.x, cursorPos.y, 0);
                foreach (Client client in Controller.Instance.Collection.GetAllActiveClients())
                {
                    if (client.Handle != associatedClient.Handle)
                    {
                        client.Overlay.UsedCursor = fakeCursor;
                    }
                    client.Overlay.OnMouseMoved(this, args);
                }
            }

            base.WndProc(ref m);
        }
    }
}
