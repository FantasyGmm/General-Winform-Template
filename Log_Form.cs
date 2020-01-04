using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通用模板窗体
{
    public partial class Log_Form : Form
    {
        public Log_Form()
        {
            InitializeComponent();
        }

        private void Clean_B_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
        }
    }
}
