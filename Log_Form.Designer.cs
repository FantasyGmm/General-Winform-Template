namespace 通用模板窗体
{
    partial class Log_Form
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
            this.Main = new System.Windows.Forms.Panel();
            this.Clean_B = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.textBox1);
            this.Main.Location = new System.Drawing.Point(13, 42);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(459, 207);
            this.Main.TabIndex = 0;
            // 
            // Clean_B
            // 
            this.Clean_B.Location = new System.Drawing.Point(13, 13);
            this.Clean_B.Name = "Clean_B";
            this.Clean_B.Size = new System.Drawing.Size(75, 23);
            this.Clean_B.TabIndex = 1;
            this.Clean_B.Text = "清空输出";
            this.Clean_B.UseVisualStyleBackColor = true;
            this.Clean_B.Click += new System.EventHandler(this.Clean_B_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(452, 200);
            this.textBox1.TabIndex = 0;
            // 
            // Log_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Clean_B);
            this.Controls.Add(this.Main);
            this.DoubleBuffered = true;
            this.Name = "Log_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Log_Form";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button Clean_B;
        public System.Windows.Forms.TextBox textBox1;
    }
}