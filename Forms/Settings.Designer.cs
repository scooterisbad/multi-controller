namespace multi_controller.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KeyMappingsPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.JumpMapping = new multi_controller.Control.KeyMapping();
            this.RightMapping = new multi_controller.Control.KeyMapping();
            this.BackMapping = new multi_controller.Control.KeyMapping();
            this.LeftMapping = new multi_controller.Control.KeyMapping();
            this.ForwardMapping = new multi_controller.Control.KeyMapping();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.KeybindsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.keyReader4 = new multi_controller.Control.KeyReader();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keyReader3 = new multi_controller.Control.KeyReader();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keyReader2 = new multi_controller.Control.KeyReader();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyReader1 = new multi_controller.Control.KeyReader();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomisationPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.BorderWidthChooser = new System.Windows.Forms.NumericUpDown();
            this.RightMultiClickBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.LeftMultiClickBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.RightBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.LeftBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.MultiClickBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.MultiBorderColourPicker = new multi_controller.Control.ColourPicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.KeyMappingsPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.KeybindsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CustomisationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderWidthChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KeyMappingsPage);
            this.tabControl1.Controls.Add(this.GeneralPage);
            this.tabControl1.Controls.Add(this.KeybindsPage);
            this.tabControl1.Controls.Add(this.CustomisationPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // KeyMappingsPage
            // 
            this.KeyMappingsPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KeyMappingsPage.Controls.Add(this.button1);
            this.KeyMappingsPage.Controls.Add(this.tableLayoutPanel2);
            this.KeyMappingsPage.Location = new System.Drawing.Point(4, 22);
            this.KeyMappingsPage.Name = "KeyMappingsPage";
            this.KeyMappingsPage.Size = new System.Drawing.Size(792, 469);
            this.KeyMappingsPage.TabIndex = 2;
            this.KeyMappingsPage.Text = "Key Mappings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Key Map (WIP)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.JumpMapping, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RightMapping, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BackMapping, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LeftMapping, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ForwardMapping, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 417);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // JumpMapping
            // 
            this.JumpMapping.BackColor = System.Drawing.Color.Transparent;
            this.JumpMapping.LeftKey = System.Windows.Forms.Keys.None;
            this.JumpMapping.Location = new System.Drawing.Point(3, 143);
            this.JumpMapping.MapName = "Jump";
            this.JumpMapping.Name = "JumpMapping";
            this.JumpMapping.NameReadOnly = true;
            this.JumpMapping.OutputKey = System.Windows.Forms.Keys.None;
            this.JumpMapping.RightKey = System.Windows.Forms.Keys.None;
            this.JumpMapping.Size = new System.Drawing.Size(770, 29);
            this.JumpMapping.TabIndex = 4;
            // 
            // RightMapping
            // 
            this.RightMapping.BackColor = System.Drawing.Color.Transparent;
            this.RightMapping.LeftKey = System.Windows.Forms.Keys.None;
            this.RightMapping.Location = new System.Drawing.Point(3, 108);
            this.RightMapping.MapName = "Right";
            this.RightMapping.Name = "RightMapping";
            this.RightMapping.NameReadOnly = true;
            this.RightMapping.OutputKey = System.Windows.Forms.Keys.None;
            this.RightMapping.RightKey = System.Windows.Forms.Keys.None;
            this.RightMapping.Size = new System.Drawing.Size(770, 29);
            this.RightMapping.TabIndex = 3;
            // 
            // BackMapping
            // 
            this.BackMapping.BackColor = System.Drawing.Color.Transparent;
            this.BackMapping.LeftKey = System.Windows.Forms.Keys.None;
            this.BackMapping.Location = new System.Drawing.Point(3, 73);
            this.BackMapping.MapName = "Back";
            this.BackMapping.Name = "BackMapping";
            this.BackMapping.NameReadOnly = true;
            this.BackMapping.OutputKey = System.Windows.Forms.Keys.None;
            this.BackMapping.RightKey = System.Windows.Forms.Keys.None;
            this.BackMapping.Size = new System.Drawing.Size(770, 29);
            this.BackMapping.TabIndex = 2;
            // 
            // LeftMapping
            // 
            this.LeftMapping.BackColor = System.Drawing.Color.Transparent;
            this.LeftMapping.LeftKey = System.Windows.Forms.Keys.None;
            this.LeftMapping.Location = new System.Drawing.Point(3, 38);
            this.LeftMapping.MapName = "Left";
            this.LeftMapping.Name = "LeftMapping";
            this.LeftMapping.NameReadOnly = true;
            this.LeftMapping.OutputKey = System.Windows.Forms.Keys.None;
            this.LeftMapping.RightKey = System.Windows.Forms.Keys.None;
            this.LeftMapping.Size = new System.Drawing.Size(770, 29);
            this.LeftMapping.TabIndex = 1;
            // 
            // ForwardMapping
            // 
            this.ForwardMapping.BackColor = System.Drawing.Color.Transparent;
            this.ForwardMapping.LeftKey = System.Windows.Forms.Keys.None;
            this.ForwardMapping.Location = new System.Drawing.Point(3, 3);
            this.ForwardMapping.MapName = "Forward";
            this.ForwardMapping.Name = "ForwardMapping";
            this.ForwardMapping.NameReadOnly = true;
            this.ForwardMapping.OutputKey = System.Windows.Forms.Keys.None;
            this.ForwardMapping.RightKey = System.Windows.Forms.Keys.None;
            this.ForwardMapping.Size = new System.Drawing.Size(770, 29);
            this.ForwardMapping.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GeneralPage.Controls.Add(this.checkBox3);
            this.GeneralPage.Controls.Add(this.checkBox2);
            this.GeneralPage.Controls.Add(this.checkBox1);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(792, 469);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            // 
            // KeybindsPage
            // 
            this.KeybindsPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KeybindsPage.Controls.Add(this.tableLayoutPanel1);
            this.KeybindsPage.Location = new System.Drawing.Point(4, 22);
            this.KeybindsPage.Name = "KeybindsPage";
            this.KeybindsPage.Padding = new System.Windows.Forms.Padding(3);
            this.KeybindsPage.Size = new System.Drawing.Size(792, 469);
            this.KeybindsPage.TabIndex = 1;
            this.KeybindsPage.Text = "Keybinds";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.89725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.89725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.89725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.89725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.41101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.keyReader4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(3, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 82);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Switch Control Mode";
            // 
            // keyReader4
            // 
            this.keyReader4.BackColor = System.Drawing.Color.Transparent;
            this.keyReader4.ChosenKey = 0;
            this.keyReader4.Location = new System.Drawing.Point(9, 32);
            this.keyReader4.Modifiers = 0;
            this.keyReader4.Name = "keyReader4";
            this.keyReader4.Size = new System.Drawing.Size(285, 45);
            this.keyReader4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Switches between multi mode and left-right mode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.keyReader3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(3, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toggle Multiclick";
            // 
            // keyReader3
            // 
            this.keyReader3.BackColor = System.Drawing.Color.Transparent;
            this.keyReader3.ChosenKey = 0;
            this.keyReader3.Location = new System.Drawing.Point(9, 32);
            this.keyReader3.Modifiers = 0;
            this.keyReader3.Name = "keyReader3";
            this.keyReader3.Size = new System.Drawing.Size(285, 45);
            this.keyReader3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toggle multiclick mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.keyReader2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toggle Control All Groups";
            // 
            // keyReader2
            // 
            this.keyReader2.BackColor = System.Drawing.Color.Transparent;
            this.keyReader2.ChosenKey = 0;
            this.keyReader2.Location = new System.Drawing.Point(9, 32);
            this.keyReader2.Modifiers = 0;
            this.keyReader2.Name = "keyReader2";
            this.keyReader2.Size = new System.Drawing.Size(285, 45);
            this.keyReader2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toggles controlling all groups at once";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyReader1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activate controller";
            // 
            // keyReader1
            // 
            this.keyReader1.BackColor = System.Drawing.Color.Transparent;
            this.keyReader1.ChosenKey = 0;
            this.keyReader1.Location = new System.Drawing.Point(9, 32);
            this.keyReader1.Modifiers = 0;
            this.keyReader1.Name = "keyReader1";
            this.keyReader1.Size = new System.Drawing.Size(285, 45);
            this.keyReader1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activates the controller";
            // 
            // CustomisationPage
            // 
            this.CustomisationPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomisationPage.Controls.Add(this.label5);
            this.CustomisationPage.Controls.Add(this.BorderWidthChooser);
            this.CustomisationPage.Controls.Add(this.RightMultiClickBorderColourPicker);
            this.CustomisationPage.Controls.Add(this.LeftMultiClickBorderColourPicker);
            this.CustomisationPage.Controls.Add(this.RightBorderColourPicker);
            this.CustomisationPage.Controls.Add(this.LeftBorderColourPicker);
            this.CustomisationPage.Controls.Add(this.MultiClickBorderColourPicker);
            this.CustomisationPage.Controls.Add(this.MultiBorderColourPicker);
            this.CustomisationPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomisationPage.Location = new System.Drawing.Point(4, 22);
            this.CustomisationPage.Name = "CustomisationPage";
            this.CustomisationPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomisationPage.Size = new System.Drawing.Size(792, 469);
            this.CustomisationPage.TabIndex = 3;
            this.CustomisationPage.Text = "Customisation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Border width";
            // 
            // BorderWidthChooser
            // 
            this.BorderWidthChooser.Location = new System.Drawing.Point(7, 163);
            this.BorderWidthChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BorderWidthChooser.Name = "BorderWidthChooser";
            this.BorderWidthChooser.Size = new System.Drawing.Size(46, 20);
            this.BorderWidthChooser.TabIndex = 6;
            this.BorderWidthChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RightMultiClickBorderColourPicker
            // 
            this.RightMultiClickBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.RightMultiClickBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.RightMultiClickBorderColourPicker.LabelText = "Multi click right border colour";
            this.RightMultiClickBorderColourPicker.Location = new System.Drawing.Point(6, 136);
            this.RightMultiClickBorderColourPicker.Name = "RightMultiClickBorderColourPicker";
            this.RightMultiClickBorderColourPicker.Size = new System.Drawing.Size(214, 20);
            this.RightMultiClickBorderColourPicker.TabIndex = 5;
            // 
            // LeftMultiClickBorderColourPicker
            // 
            this.LeftMultiClickBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.LeftMultiClickBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.LeftMultiClickBorderColourPicker.LabelText = "Multi click left border colour";
            this.LeftMultiClickBorderColourPicker.Location = new System.Drawing.Point(6, 110);
            this.LeftMultiClickBorderColourPicker.Name = "LeftMultiClickBorderColourPicker";
            this.LeftMultiClickBorderColourPicker.Size = new System.Drawing.Size(214, 20);
            this.LeftMultiClickBorderColourPicker.TabIndex = 4;
            // 
            // RightBorderColourPicker
            // 
            this.RightBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.RightBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.RightBorderColourPicker.LabelText = "Right border colour";
            this.RightBorderColourPicker.Location = new System.Drawing.Point(6, 84);
            this.RightBorderColourPicker.Name = "RightBorderColourPicker";
            this.RightBorderColourPicker.Size = new System.Drawing.Size(214, 20);
            this.RightBorderColourPicker.TabIndex = 3;
            // 
            // LeftBorderColourPicker
            // 
            this.LeftBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.LeftBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.LeftBorderColourPicker.LabelText = "Left border colour";
            this.LeftBorderColourPicker.Location = new System.Drawing.Point(6, 58);
            this.LeftBorderColourPicker.Name = "LeftBorderColourPicker";
            this.LeftBorderColourPicker.Size = new System.Drawing.Size(214, 20);
            this.LeftBorderColourPicker.TabIndex = 2;
            // 
            // MultiClickBorderColourPicker
            // 
            this.MultiClickBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.MultiClickBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.MultiClickBorderColourPicker.LabelText = "Multi click in multi mode border colour";
            this.MultiClickBorderColourPicker.Location = new System.Drawing.Point(6, 32);
            this.MultiClickBorderColourPicker.Name = "MultiClickBorderColourPicker";
            this.MultiClickBorderColourPicker.Size = new System.Drawing.Size(214, 20);
            this.MultiClickBorderColourPicker.TabIndex = 1;
            // 
            // MultiBorderColourPicker
            // 
            this.MultiBorderColourPicker.BackColor = System.Drawing.Color.Transparent;
            this.MultiBorderColourPicker.ChosenColour = System.Drawing.Color.Empty;
            this.MultiBorderColourPicker.LabelText = "Multi mode border colour";
            this.MultiBorderColourPicker.Location = new System.Drawing.Point(6, 6);
            this.MultiBorderColourPicker.Name = "MultiBorderColourPicker";
            this.MultiBorderColourPicker.Size = new System.Drawing.Size(154, 20);
            this.MultiBorderColourPicker.TabIndex = 0;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox3.Checked = global::multi_controller.Properties.Settings.Default.ClydeCopiumMode;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::multi_controller.Properties.Settings.Default, "ClydeCopiumMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(8, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(405, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Toggle \"control all groups\" when switching control modes (Clyde\'s copium mode)";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::multi_controller.Properties.Settings.Default.MirrorAllInLeftRightMode;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::multi_controller.Properties.Settings.Default, "MirrorAllInLeftRightMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(8, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(305, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mirror all input in LeftRight mode, other than those specified";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::multi_controller.Properties.Settings.Default.ShowMultipleCursors;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::multi_controller.Properties.Settings.Default, "ShowMultipleCursors", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(8, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show multiple cursors in multiclick mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.KeyMappingsPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.KeybindsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CustomisationPage.ResumeLayout(false);
            this.CustomisationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderWidthChooser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage KeybindsPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage KeyMappingsPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Control.KeyReader keyReader1;
        private Control.KeyReader keyReader4;
        private Control.KeyReader keyReader3;
        private Control.KeyReader keyReader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Control.KeyMapping JumpMapping;
        private Control.KeyMapping RightMapping;
        private Control.KeyMapping BackMapping;
        private Control.KeyMapping LeftMapping;
        private Control.KeyMapping ForwardMapping;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TabPage CustomisationPage;
        private Control.ColourPicker MultiBorderColourPicker;
        private Control.ColourPicker MultiClickBorderColourPicker;
        private Control.ColourPicker RightMultiClickBorderColourPicker;
        private Control.ColourPicker LeftMultiClickBorderColourPicker;
        private Control.ColourPicker RightBorderColourPicker;
        private Control.ColourPicker LeftBorderColourPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BorderWidthChooser;
    }
}