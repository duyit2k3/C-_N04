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
    public partial class Formbai1 : Form
    {
        public Formbai1()
        {
            InitializeComponent();
        }
        int i = 10;
        private void btnBatdau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongho.Text = i.ToString();
            i--;
            if(i < 0)
            {
                this.timer1.Enabled = false;
                lblDongho.Text = "Hết giờ!";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
