using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiNgay18_3
{
    public partial class Formbai2 : Form
    {
        public Formbai2()
        {
            InitializeComponent();
        }
        string s = "Chúc Mừng Năm Mới - Happy New Year";
        int i = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            if(i == s.Length)
            {
                this.timer1.Enabled = false;
            }
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChu.Text += s[i];
            i++;
            if (i > s.Length - 1)
            {
                this.timer1.Enabled = false;
            }
        }
    }
}
