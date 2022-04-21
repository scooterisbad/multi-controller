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
    public partial class ColourPicker : UserControl
    {
        private Color chosenColour;
        [Bindable(true)]
        [Browsable(true)]
        public Color ChosenColour
        {
            get { return chosenColour; }
            set 
            { 
                chosenColour = value;
                SelectColourButton.BackColor = chosenColour;
            }
        }

        private string labelText;
        [Browsable(true)]
        public string LabelText
        {
            get 
            {
                labelText = label1.Text;
                return labelText; 
            }
            set
            {
                labelText = value;
                label1.Text = labelText;
            }
        }

        public ColourPicker()
        {
            InitializeComponent();
        }

        private void SelectColourButton_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog();
            colourDialog.Color = ChosenColour;
            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                ChosenColour = colourDialog.Color;
                SelectColourButton.BackColor = ChosenColour;
            }
        }
    }
}
