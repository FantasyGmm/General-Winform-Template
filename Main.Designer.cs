namespace 通用模板窗体
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_p0 = new System.Windows.Forms.Panel();
            this.B1 = new System.Windows.Forms.Button();
            this.Main_p0.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_p0
            // 
            this.Main_p0.AllowDrop = true;
            this.Main_p0.AutoSize = true;
            this.Main_p0.Controls.Add(this.B1);
            this.Main_p0.Location = new System.Drawing.Point(12, 12);
            this.Main_p0.Name = "Main_p0";
            this.Main_p0.Size = new System.Drawing.Size(760, 437);
            this.Main_p0.TabIndex = 0;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(3, 3);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 0;
            this.B1.Text = "Log View";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Main_p0);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Main_p0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel Main_p0;
        private System.Windows.Forms.Button B1;
    }
}

