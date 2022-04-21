namespace multi_controller.Forms
{
    partial class MainWindow
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
            this.EditWindowsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditWindowsButton
            // 
            this.EditWindowsButton.Location = new System.Drawing.Point(12, 12);
            this.EditWindowsButton.Name = "EditWindowsButton";
            this.EditWindowsButton.Size = new System.Drawing.Size(110, 23);
            this.EditWindowsButton.TabIndex = 1;
            this.EditWindowsButton.TabStop = false;
            this.EditWindowsButton.Text = "Edit Windows";
            this.EditWindowsButton.UseVisualStyleBackColor = true;
            this.EditWindowsButton.Click += new System.EventHandler(this.EditWindowsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsButton.Location = new System.Drawing.Point(12, 41);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(110, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(134, 74);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.EditWindowsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Multitoon Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditWindowsButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}

