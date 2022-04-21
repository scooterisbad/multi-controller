using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace multi_controller.Forms
{
    public partial class MainWindow : Form, IMessageFilter
    {
        const int ACTIVATE_CONTROLLER_HOTKEY_ID = 1;
        const int MULTI_CLICK_HOTKEY_ID = 2;
        const int CONTROL_ALL_GROUPS_TOGGLE_HOTKEY_ID = 3;

        public MainWindow()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            Win32.RegisterHotKey(this.Handle, ACTIVATE_CONTROLLER_HOTKEY_ID, Properties.Settings.Default.ActivateControllerMods, Properties.Settings.Default.ActivateControllerKey);
            Win32.RegisterHotKey(this.Handle, MULTI_CLICK_HOTKEY_ID, Properties.Settings.Default.MultiClickMods, Properties.Settings.Default.MultiClickKey);
            Win32.RegisterHotKey(this.Handle, CONTROL_ALL_GROUPS_TOGGLE_HOTKEY_ID, Properties.Settings.Default.ControlAllMods, Properties.Settings.Default.ControlAllKey);

            Properties.Settings.Default.PropertyChanged += SettingChanged;

            Controller.Instance.ActivateController += Controller_ActivateController;

            // Interrupts all messages sent to the main window
            Application.AddMessageFilter(this);
        }

        private void SettingChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ActivateControllerKey" || e.PropertyName == "ActivateControllerMods")
            {
                Win32.UnregisterHotKey(this.Handle, ACTIVATE_CONTROLLER_HOTKEY_ID);
                Win32.RegisterHotKey(this.Handle, ACTIVATE_CONTROLLER_HOTKEY_ID, Properties.Settings.Default.ActivateControllerMods, Properties.Settings.Default.ActivateControllerKey);
            }
            else if (e.PropertyName == "MultiClickKey" || e.PropertyName == "MultiClickMods")
            {
                Win32.UnregisterHotKey(this.Handle, MULTI_CLICK_HOTKEY_ID);
                Win32.RegisterHotKey(this.Handle, MULTI_CLICK_HOTKEY_ID, Properties.Settings.Default.MultiClickMods, Properties.Settings.Default.MultiClickKey);
            }
            else if (e.PropertyName == "ControlAllKey" || e.PropertyName == "ControlAllMods")
            {
                Win32.UnregisterHotKey(this.Handle, CONTROL_ALL_GROUPS_TOGGLE_HOTKEY_ID);
                Win32.RegisterHotKey(this.Handle, CONTROL_ALL_GROUPS_TOGGLE_HOTKEY_ID, Properties.Settings.Default.ControlAllMods, Properties.Settings.Default.ControlAllKey);
            }
        }

        /// <summary>
        /// Captures messages sent to the form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)Win32.WM.HOTKEY)
            {
                IntPtr handle = Win32.GetForegroundWindow();
                bool ret = true;
                if (handle == this.Handle) ret = false;
                else
                {
                    // If foreground is any client in any group 
                    foreach (Group group in Controller.Instance.Collection.Groups)
                    {
                        if (group.GetClient(handle) != null)
                        {
                            ret = false;
                            break;
                        }
                    }
                }
                if (ret) return;

                switch (m.WParam.ToInt32())
                {
                    case ACTIVATE_CONTROLLER_HOTKEY_ID:
                        Controller_ActivateController(this, EventArgs.Empty);
                        break;
                    case MULTI_CLICK_HOTKEY_ID:
                        Controller.Instance.MultiClick = !Controller.Instance.MultiClick;
                        Controller_ActivateController(this, EventArgs.Empty);
                        break;
                    case CONTROL_ALL_GROUPS_TOGGLE_HOTKEY_ID:
                        Controller.Instance.Collection.AllActive = !Controller.Instance.Collection.AllActive;
                        Controller_ActivateController(this, EventArgs.Empty);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        public bool PreFilterMessage(ref Message m)
        {
            bool val = false;

            if (Form.ActiveForm != this) return false;

            Win32.WM msg = (Win32.WM)m.Msg;
            if (msg == Win32.WM.KEYDOWN || msg == Win32.WM.KEYUP)
            {
                Controller.Instance.ProcessKey(msg, m.WParam, m.LParam);
                val = true;
            }

            return val;
        }

        private void Controller_ActivateController(object sender, EventArgs e)
        {
            Thread activationThread = new Thread(ActivationThread);
            activationThread.Start();
        }

        /// <summary>
        /// Forcefully activates the controller by repeatedly calling the function until it works
        /// </summary>
        private void ActivationThread()
        {
            IntPtr handle = IntPtr.Zero;
            Invoke(new Action(() => handle = this.Handle));
            int t = 0;
            do
            {
                if (Win32.GetForegroundWindow() == handle) return;

                Invoke(new Action(() => this.Activate()));

                Thread.Sleep(5);
                t += 5;
            } while (t < 1000);
        }

        private void EditWindowsButton_Click(object sender, EventArgs e)
        {
            WindowSelector windowSelector = new WindowSelector();
            windowSelector.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Client client in Controller.Instance.Collection.GetAllClients())
            {
                client.Overlay.Dispose();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
