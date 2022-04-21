namespace multi_controller.Control
{
    partial class KeyReader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AltCheckBox = new System.Windows.Forms.CheckBox();
            this.ShiftCheckBox = new System.Windows.Forms.CheckBox();
            this.CtrlCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyInput1 = new multi_controller.Control.KeyInput();
            this.SuspendLayout();
            // 
            // AltCheckBox
            // 
            this.AltCheckBox.AutoSize = true;
            this.AltCheckBox.Location = new System.Drawing.Point(236, 20);
            this.AltCheckBox.Name = "AltCheckBox";
            this.AltCheckBox.Size = new System.Drawing.Size(38, 17);
            this.AltCheckBox.TabIndex = 11;
            this.AltCheckBox.Text = "Alt";
            this.AltCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftCheckBox
            // 
            this.ShiftCheckBox.AutoSize = true;
            this.ShiftCheckBox.Location = new System.Drawing.Point(183, 20);
            this.ShiftCheckBox.Name = "ShiftCheckBox";
            this.ShiftCheckBox.Size = new System.Drawing.Size(47, 17);
            this.ShiftCheckBox.TabIndex = 10;
            this.ShiftCheckBox.Text = "Shift";
            this.ShiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // CtrlCheckBox
            // 
            this.CtrlCheckBox.AutoSize = true;
            this.CtrlCheckBox.Location = new System.Drawing.Point(136, 20);
            this.CtrlCheckBox.Name = "CtrlCheckBox";
            this.CtrlCheckBox.Size = new System.Drawing.Size(41, 17);
            this.CtrlCheckBox.TabIndex = 9;
            this.CtrlCheckBox.Text = "Ctrl";
            this.CtrlCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key";
            // 
            // keyInput1
            // 
            this.keyInput1.BackColor = System.Drawing.Color.Transparent;
            this.keyInput1.KeyCode = System.Windows.Forms.Keys.None;
            this.keyInput1.Location = new System.Drawing.Point(3, 18);
            this.keyInput1.Name = "keyInput1";
            this.keyInput1.Size = new System.Drawing.Size(104, 26);
            this.keyInput1.TabIndex = 12;
            // 
            // KeyReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.keyInput1);
            this.Controls.Add(this.AltCheckBox);
            this.Controls.Add(this.ShiftCheckBox);
            this.Controls.Add(this.CtrlCheckBox);
            this.Controls.Add(this.label2);
            this.Name = "KeyReader";
            this.Size = new System.Drawing.Size(285, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AltCheckBox;
        private System.Windows.Forms.CheckBox ShiftCheckBox;
        private System.Windows.Forms.CheckBox CtrlCheckBox;
        private System.Windows.Forms.Label label2;
        private KeyInput keyInput1;
    }
}
