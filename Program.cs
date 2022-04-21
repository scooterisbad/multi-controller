using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using multi_controller.Forms;

namespace multi_controller
{
    internal static class Program
    {
        private static Win32.WinEventDelegate foregroundChangedDelegate = new Win32.WinEventDelegate(WinEventForegroundChanged);
        private static Win32.WinEventDelegate windowMovedDelegate = new Win32.WinEventDelegate(WinEventWindowMoved);
        private static Win32.WinEventDelegate windowClosedDelegate = new Win32.WinEventDelegate(WinEventWindowClosed);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Win32.SetWinEventHook(Win32.EVENT_SYSTEM_FOREGROUND, Win32.EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, foregroundChangedDelegate, 0, 0, 0);
            Win32.SetWinEventHook(Win32.EVENT_OBJECT_LOCATIONCHANGE, Win32.EVENT_OBJECT_LOCATIONCHANGE, IntPtr.Zero, windowMovedDelegate, 0, 0, 0);
            Win32.SetWinEventHook(Win32.EVENT_OBJECT_DESTROY, Win32.EVENT_OBJECT_DESTROY, IntPtr.Zero, windowClosedDelegate, 0, 0, 0);

            Application.Run(new MainWindow());
        }

        private static int IsToontownWindow(IntPtr handle)
        {
            StringBuilder className = new StringBuilder(256);
            IntPtr nRet = Win32.GetClassName(handle, className, className.Capacity);

            if (nRet == IntPtr.Zero) return -1;
            if (className.ToString() == "WinGraphicsWindow0") return 1;
            return 0;
        }

        public static void WinEventForegroundChanged(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            int ret = IsToontownWindow(hWnd);
            if (ret == -1) return;
            if (ret == 1)
            {
                ClientArgs args = new ClientArgs(hWnd);
                Controller.Instance.OnClientActivated(args);
            }
            else
            {
                ClientArgs args = new ClientArgs(hWnd);
                Controller.Instance.OnClientDeactivated(args);
            }
        }

        public static void WinEventWindowMoved(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (IsToontownWindow(hWnd) != 1) return;

            ClientArgs args = new ClientArgs(hWnd);
            Controller.Instance.OnClientMoved(args);
        }

        public static void WinEventWindowClosed(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (IsToontownWindow(hWnd) != 1) return;

            ClientArgs args = new ClientArgs(hWnd);
            Controller.Instance.OnClientClosed(args);
        }
    }
}
