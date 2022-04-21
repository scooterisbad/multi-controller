using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace multi_controller.Control
{
    public partial class KeyReader : UserControl
    {
        private int chosenKey;
        [Bindable(true)]
        [Browsable(true)]
        public int ChosenKey
        {
            get
            {
                return chosenKey;
            }
            set
            {
                chosenKey = value;
                keyInput1.KeyCode = (Keys)chosenKey;
            }
        }

        [Bindable(true)]
        [Browsable(true)]
        public int Modifiers
        {
            get
            {
                int modifier = 0x0000;
                if (AltCheckBox.Checked) modifier = modifier | 0x0001;
                if (CtrlCheckBox.Checked) modifier = modifier | 0x0002;
                if (ShiftCheckBox.Checked) modifier = modifier | 0x0004;
                return modifier;
            }
            set
            {
                if ((value & 0x0001) == 0x0001) AltCheckBox.Checked = true;
                if ((value & 0x0002) == 0x0002) CtrlCheckBox.Checked = true;
                if ((value & 0x0004) == 0x0004) ShiftCheckBox.Checked = true;
            }
        }

        public KeyReader()
        {
            InitializeComponent();

            keyInput1.KeyChanged += KeyInput1_KeyChanged;
        }

        private void KeyInput1_KeyChanged(object sender, KeyEventArgs e)
        {
            ChosenKey = e.KeyValue;
        }
    }
}
