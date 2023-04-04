using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiNgay11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Formbai5 f1 = new Formbai5();
            f1.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Formbai6 f2 = new Formbai6();
            f2.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Formbai7 f3 = new Formbai7();
            f3.Show();
        }
    }
}
