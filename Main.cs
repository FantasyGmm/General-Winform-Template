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
    public partial class Main : Form
    {
        public Log_Form logForm = new Log_Form();
        public Main()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            logForm.Show(this.Owner);

        }
    }
}
