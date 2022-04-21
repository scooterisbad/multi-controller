using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_controller.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Application binding wasn't working and it was pissing me off so we're
        // going with this piece of shit code for now, cope.
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.KeyMaps.Default.Forward.OutputKey = ForwardMapping.OutputKey;
            Properties.KeyMaps.Default.Forward.LeftKey = ForwardMapping.LeftKey;
            Properties.KeyMaps.Default.Forward.RightKey = ForwardMapping.RightKey;
            Properties.KeyMaps.Default.Left.OutputKey = LeftMapping.OutputKey;
            Properties.KeyMaps.Default.Left.LeftKey = LeftMapping.LeftKey;
            Properties.KeyMaps.Default.Left.RightKey = LeftMapping.RightKey;
            Properties.KeyMaps.Default.Back.OutputKey = BackMapping.OutputKey;
            Properties.KeyMaps.Default.Back.LeftKey = BackMapping.LeftKey;
            Properties.KeyMaps.Default.Back.RightKey = BackMapping.RightKey;
            Properties.KeyMaps.Default.Right.OutputKey = RightMapping.OutputKey;
            Properties.KeyMaps.Default.Right.LeftKey = RightMapping.LeftKey;
            Properties.KeyMaps.Default.Right.RightKey = RightMapping.RightKey;
            Properties.KeyMaps.Default.Jump.OutputKey = JumpMapping.OutputKey;
            Properties.KeyMaps.Default.Jump.LeftKey = JumpMapping.LeftKey;
            Properties.KeyMaps.Default.Jump.RightKey = JumpMapping.RightKey;

            Properties.Settings.Default.ActivateControllerKey = keyReader1.ChosenKey;
            Properties.Settings.Default.ActivateControllerMods = keyReader1.Modifiers;
            Properties.Settings.Default.ControlAllKey = keyReader2.ChosenKey;
            Properties.Settings.Default.ControlAllMods = keyReader2.Modifiers;
            Properties.Settings.Default.MultiClickKey = keyReader3.ChosenKey;
            Properties.Settings.Default.MultiClickMods = keyReader3.Modifiers;
            Properties.Settings.Default.SwitchModeKey = keyReader4.ChosenKey;
            Properties.Settings.Default.SwitchModeMods = keyReader4.Modifiers;

            Properties.Customisation.Default.MultiBorderColour = MultiBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.MultiClickBorderColour = MultiClickBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.LeftBorderColour = LeftBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.RightBorderColour = RightBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.LeftMultiClickBorderColour = LeftMultiClickBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.RightMultiClickBorderColour = RightMultiClickBorderColourPicker.ChosenColour;
            Properties.Customisation.Default.BorderWidth = (int)BorderWidthChooser.Value;

            Properties.Settings.Default.Save();
            Properties.KeyMaps.Default.Save();
            Properties.Customisation.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ForwardMapping.OutputKey = Properties.KeyMaps.Default.Forward.OutputKey;
            ForwardMapping.LeftKey = Properties.KeyMaps.Default.Forward.LeftKey;
            ForwardMapping.RightKey = Properties.KeyMaps.Default.Forward.RightKey;
            LeftMapping.OutputKey = Properties.KeyMaps.Default.Left.OutputKey;
            LeftMapping.LeftKey = Properties.KeyMaps.Default.Left.LeftKey;
            LeftMapping.RightKey = Properties.KeyMaps.Default.Left.RightKey;
            BackMapping.OutputKey = Properties.KeyMaps.Default.Back.OutputKey;
            BackMapping.LeftKey = Properties.KeyMaps.Default.Back.LeftKey;
            BackMapping.RightKey = Properties.KeyMaps.Default.Back.RightKey;
            RightMapping.OutputKey = Properties.KeyMaps.Default.Right.OutputKey;
            RightMapping.LeftKey = Properties.KeyMaps.Default.Right.LeftKey;
            RightMapping.RightKey = Properties.KeyMaps.Default.Right.RightKey;
            JumpMapping.OutputKey = Properties.KeyMaps.Default.Jump.OutputKey;
            JumpMapping.LeftKey = Properties.KeyMaps.Default.Jump.LeftKey;
            JumpMapping.RightKey = Properties.KeyMaps.Default.Jump.RightKey;

            keyReader1.ChosenKey = Properties.Settings.Default.ActivateControllerKey;
            keyReader1.Modifiers = Properties.Settings.Default.ActivateControllerMods;
            keyReader2.ChosenKey = Properties.Settings.Default.ControlAllKey;
            keyReader2.Modifiers = Properties.Settings.Default.ControlAllMods;
            keyReader3.ChosenKey = Properties.Settings.Default.MultiClickKey;
            keyReader3.Modifiers = Properties.Settings.Default.MultiClickMods;
            keyReader4.ChosenKey = Properties.Settings.Default.SwitchModeKey;
            keyReader4.Modifiers = Properties.Settings.Default.SwitchModeMods;

            MultiBorderColourPicker.ChosenColour = Properties.Customisation.Default.MultiBorderColour;
            MultiClickBorderColourPicker.ChosenColour = Properties.Customisation.Default.MultiClickBorderColour;
            LeftBorderColourPicker.ChosenColour = Properties.Customisation.Default.LeftBorderColour;
            RightBorderColourPicker.ChosenColour = Properties.Customisation.Default.RightBorderColour;
            LeftMultiClickBorderColourPicker.ChosenColour = Properties.Customisation.Default.LeftMultiClickBorderColour;
            RightMultiClickBorderColourPicker.ChosenColour = Properties.Customisation.Default.RightMultiClickBorderColour;
            BorderWidthChooser.Value = Properties.Customisation.Default.BorderWidth;
        }
    }
}
