using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_controller.Control
{
    public partial class KeyInput : UserControl
    {
        [Browsable(true)]
        public event KeyEventHandler KeyChanged;

        private Keys keyCode = 0;
        [Bindable(true)]
        [Browsable(true)]
        public Keys KeyCode { 
            get
            {
                return keyCode;
            }
            set
            {
                keyCode = value;
                button1.Text = keyCode.ToString();
            }
        }

        public KeyInput()
        {
            InitializeComponent();

            button1.Text = KeyCode.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.KeyUp += Button1_KeyUp;
        }

        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyCode = e.KeyCode;
            KeyChanged?.Invoke(sender, e);
            button1.KeyUp -= Button1_KeyUp;
        }
    }
}
