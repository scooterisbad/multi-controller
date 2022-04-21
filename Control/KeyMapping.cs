using System.ComponentModel;
using System.Windows.Forms;

namespace multi_controller.Control
{
    public partial class KeyMapping : UserControl
    {
        private Keys outputKey;
        [Browsable(true)]
        public Keys OutputKey
        {
            get { return outputKey; }
            set
            {
                outputKey = value;
                OutputKeyInput.KeyCode = value;
            }
        }

        private Keys leftKey;
        [Browsable(true)]
        public Keys LeftKey
        {
            get { return leftKey; }
            set
            {
                leftKey = value;
                LeftKeyInput.KeyCode = value;
            }
        }

        private Keys rightKey;
        [Browsable(true)]
        public Keys RightKey
        {
            get { return rightKey; }
            set
            {
                rightKey = value;
                RightKeyInput.KeyCode = value;
            }
        }

        private bool nameReadOnly = true;
        [Browsable(true)]
        public bool NameReadOnly
        {
            get { return nameReadOnly; }
            set
            {
                nameReadOnly = value;
                textBox1.ReadOnly = nameReadOnly;
            }
        }

        private string mapName;
        [Browsable(true)]
        public string MapName
        {
            get { return mapName; }
            set
            {
                mapName = value;
                textBox1.Text = mapName;
            }
        }

        public KeyMapping()
        {
            InitializeComponent();
        }

        private void OutputKeyInput_KeyChanged(object sender, KeyEventArgs e)
        {
            OutputKey = e.KeyCode;
        }

        private void LeftKeyInput_KeyChanged(object sender, KeyEventArgs e)
        {
            LeftKey = e.KeyCode;
        }

        private void RightKeyInput_KeyChanged(object sender, KeyEventArgs e)
        {
            RightKey = e.KeyCode;
        }
    }
}
