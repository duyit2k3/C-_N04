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
    public partial class Formbai6 : Form
    {
        public Formbai6()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tong = 0, tongchan = 0, tongle = 0;
            txtMang.Text = "";
            Formnhap f2 = new Formnhap();
            while (f2.check == true)
            {
                txtMang.Text = txtMang.Text + f2.DataGet + " ";
                int num = Convert.ToInt32(f2.DataGet);
                tong += num;
                if (num % 2 == 0)
                {
                    tongchan += num;
                }
                else
                {
                    tongle += num;
                }
                f2.ShowDialog();
            }
            txtTong.Text = tong.ToString();
            txtTongChan.Text = tongchan.ToString();
            txtTongLe.Text = tongle.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMang.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
