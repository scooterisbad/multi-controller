namespace multi_controller.Control
{
    partial class KeyMapping
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OutputKeyInput = new multi_controller.Control.KeyInput();
            this.LeftKeyInput = new multi_controller.Control.KeyInput();
            this.RightKeyInput = new multi_controller.Control.KeyInput();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputKeyInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LeftKeyInput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightKeyInput, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // OutputKeyInput
            // 
            this.OutputKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.OutputKeyInput.KeyCode = System.Windows.Forms.Keys.None;
            this.OutputKeyInput.Location = new System.Drawing.Point(249, 3);
            this.OutputKeyInput.Name = "OutputKeyInput";
            this.OutputKeyInput.Size = new System.Drawing.Size(104, 25);
            this.OutputKeyInput.TabIndex = 1;
            this.OutputKeyInput.KeyChanged += new System.Windows.Forms.KeyEventHandler(this.OutputKeyInput_KeyChanged);
            // 
            // LeftKeyInput
            // 
            this.LeftKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.LeftKeyInput.KeyCode = System.Windows.Forms.Keys.None;
            this.LeftKeyInput.Location = new System.Drawing.Point(495, 3);
            this.LeftKeyInput.Name = "LeftKeyInput";
            this.LeftKeyInput.Size = new System.Drawing.Size(104, 25);
            this.LeftKeyInput.TabIndex = 2;
            this.LeftKeyInput.KeyChanged += new System.Windows.Forms.KeyEventHandler(this.LeftKeyInput_KeyChanged);
            // 
            // RightKeyInput
            // 
            this.RightKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.RightKeyInput.KeyCode = System.Windows.Forms.Keys.None;
            this.RightKeyInput.Location = new System.Drawing.Point(741, 3);
            this.RightKeyInput.Name = "RightKeyInput";
            this.RightKeyInput.Size = new System.Drawing.Size(104, 25);
            this.RightKeyInput.TabIndex = 3;
            this.RightKeyInput.KeyChanged += new System.Windows.Forms.KeyEventHandler(this.RightKeyInput_KeyChanged);
            // 
            // KeyMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KeyMapping";
            this.Size = new System.Drawing.Size(985, 31);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private KeyInput OutputKeyInput;
        private KeyInput LeftKeyInput;
        private KeyInput RightKeyInput;
    }
}
