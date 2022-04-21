namespace multi_controller.Forms
{
    partial class WindowSelector
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
            this.AddLeftWindowsButton = new System.Windows.Forms.Button();
            this.GroupSelectComboBox = new System.Windows.Forms.ComboBox();
            this.WindowCountLabel = new System.Windows.Forms.Label();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.RemoveGroupButton = new System.Windows.Forms.Button();
            this.AddRightWindowsButton = new System.Windows.Forms.Button();
            this.RemoveWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddLeftWindowsButton
            // 
            this.AddLeftWindowsButton.Location = new System.Drawing.Point(8, 70);
            this.AddLeftWindowsButton.Name = "AddLeftWindowsButton";
            this.AddLeftWindowsButton.Size = new System.Drawing.Size(116, 23);
            this.AddLeftWindowsButton.TabIndex = 0;
            this.AddLeftWindowsButton.TabStop = false;
            this.AddLeftWindowsButton.Text = "Add left windows";
            this.AddLeftWindowsButton.UseVisualStyleBackColor = true;
            this.AddLeftWindowsButton.Click += new System.EventHandler(this.AddLeftWindowsButton_Click);
            // 
            // GroupSelectComboBox
            // 
            this.GroupSelectComboBox.FormattingEnabled = true;
            this.GroupSelectComboBox.Location = new System.Drawing.Point(130, 10);
            this.GroupSelectComboBox.Name = "GroupSelectComboBox";
            this.GroupSelectComboBox.Size = new System.Drawing.Size(116, 21);
            this.GroupSelectComboBox.TabIndex = 1;
            this.GroupSelectComboBox.TabStop = false;
            this.GroupSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupSelectComboBox_SelectedIndexChanged);
            // 
            // WindowCountLabel
            // 
            this.WindowCountLabel.AutoSize = true;
            this.WindowCountLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindowCountLabel.Location = new System.Drawing.Point(5, 14);
            this.WindowCountLabel.Name = "WindowCountLabel";
            this.WindowCountLabel.Size = new System.Drawing.Size(112, 13);
            this.WindowCountLabel.TabIndex = 2;
            this.WindowCountLabel.Text = "Number of windows: 0";
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(8, 41);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(116, 23);
            this.AddGroupButton.TabIndex = 3;
            this.AddGroupButton.TabStop = false;
            this.AddGroupButton.Text = "Add group";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // RemoveGroupButton
            // 
            this.RemoveGroupButton.Location = new System.Drawing.Point(130, 41);
            this.RemoveGroupButton.Name = "RemoveGroupButton";
            this.RemoveGroupButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveGroupButton.TabIndex = 4;
            this.RemoveGroupButton.TabStop = false;
            this.RemoveGroupButton.Text = "Remove group";
            this.RemoveGroupButton.UseVisualStyleBackColor = true;
            this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
            // 
            // AddRightWindowsButton
            // 
            this.AddRightWindowsButton.Location = new System.Drawing.Point(130, 70);
            this.AddRightWindowsButton.Name = "AddRightWindowsButton";
            this.AddRightWindowsButton.Size = new System.Drawing.Size(116, 23);
            this.AddRightWindowsButton.TabIndex = 5;
            this.AddRightWindowsButton.TabStop = false;
            this.AddRightWindowsButton.Text = "Add right windows";
            this.AddRightWindowsButton.UseVisualStyleBackColor = true;
            this.AddRightWindowsButton.Click += new System.EventHandler(this.AddRightWindowsButton_Click);
            // 
            // RemoveWindowButton
            // 
            this.RemoveWindowButton.Location = new System.Drawing.Point(69, 99);
            this.RemoveWindowButton.Name = "RemoveWindowButton";
            this.RemoveWindowButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveWindowButton.TabIndex = 6;
            this.RemoveWindowButton.TabStop = false;
            this.RemoveWindowButton.Text = "Remove window";
            this.RemoveWindowButton.UseVisualStyleBackColor = true;
            this.RemoveWindowButton.Click += new System.EventHandler(this.RemoveWindowButton_Click);
            // 
            // WindowSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(254, 130);
            this.Controls.Add(this.RemoveWindowButton);
            this.Controls.Add(this.AddRightWindowsButton);
            this.Controls.Add(this.RemoveGroupButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.WindowCountLabel);
            this.Controls.Add(this.GroupSelectComboBox);
            this.Controls.Add(this.AddLeftWindowsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window Selector";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowSelector_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLeftWindowsButton;
        private System.Windows.Forms.ComboBox GroupSelectComboBox;
        private System.Windows.Forms.Label WindowCountLabel;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Button RemoveGroupButton;
        private System.Windows.Forms.Button AddRightWindowsButton;
        private System.Windows.Forms.Button RemoveWindowButton;
    }
}