using multi_controller.Forms;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace multi_controller
{
    /// <summary>
    /// Represents a toontown window
    /// </summary>
    public class Client
    {
        private IntPtr handle;
        public IntPtr Handle
        {
            get { return handle; }
        }

        private Overlay overlay;
        public Overlay Overlay
        {
            get { return overlay; }
            set
            {
                overlay = value;
                overlay.AssociatedClient = this;
            }
        }

        private ControlSet controlSet;
        public ControlSet ControlSet
        {
            get { return controlSet; }
            set { controlSet = value; }
        }

        public Client(IntPtr handle)
        {
            this.handle = handle;
            overlay = new Overlay(this);

            RedrawOverlay();

            overlay.Show();

            Controller.Instance.ClientMoved += Controller_ClientMoved;
            Controller.Instance.ClientActivated += Controller_ClientActivated;
            Controller.Instance.ClientDeactivated += Controller_ClientDeactivated;

            Thread keepAlive = new Thread(KeepAlive);
            keepAlive.IsBackground = true;
            keepAlive.Start();
        }

        public void RedrawOverlay()
        {
            Win32.RECT rect = GetRect();
            Win32.POINT topLeft = new Win32.POINT(rect.left, rect.top);
            Win32.POINT bottomRight = new Win32.POINT(rect.right, rect.bottom);
            Win32.ClientToScreen(this.Handle, out topLeft);
            Win32.ClientToScreen(this.Handle, out bottomRight);

            overlay.Location = new Point(0, 0);
            //overlay.Location = new Point(topLeft.x, topLeft.y);
            overlay.Size = new Size(bottomRight.x - topLeft.x, bottomRight.y - topLeft.y);

            overlay.Invalidate();
        }

        private void Controller_ClientMoved(object sender, ClientArgs e)
        {
            if (e.handle != this.handle) return;
            RedrawOverlay();
        }

        private void Controller_ClientActivated(object sender, ClientArgs e)
        {
            if (e.handle != this.handle) return;
            if (!Controller.Instance.Collection.IsActive(this.Handle)) return;
            overlay.Enable();
        }

        private void Controller_ClientDeactivated(object sender, ClientArgs e)
        {
            overlay.Disable();
        }

        public Win32.RECT GetRect()
        {
            Win32.RECT rect = new Win32.RECT();
            Win32.GetClientRect(handle, out rect);
            return rect;
        }

        // Don't tell the mods
        public void KeepAlive()
        {
            Random random = new Random();
            while (true)
            {
                Win32.SendMessage(this.Handle, (int)Win32.WM.KEYDOWN, (IntPtr)Keys.G, IntPtr.Zero);
                Win32.SendMessage(this.Handle, (int)Win32.WM.KEYUP, (IntPtr)Keys.G, IntPtr.Zero);
                Thread.Sleep(random.Next(120000, 240000));
            }
        }
    }

    public enum ControlSet
    {
        Left,
        Right
    }
}
