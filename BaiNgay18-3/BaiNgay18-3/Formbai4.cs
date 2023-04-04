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
    public partial class Formbai4 : Form
    {
        public Formbai4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            if(rdCacUoc.Checked == true)
            {
                for(int i = 1; i <= Math.Min(n, m); i++)
                {
                    if(n % i == 0 && m % i == 0)
                    {
                        if(i == Math.Min(n, m))
                        {
                            txtRes.Text += i.ToString();
                        }
                        else
                        {
                            txtRes.Text += i.ToString() + ", ";
                        }
                    }
                }
            }
            if(rdUocMax.Checked== true)
            {
                int a = Math.Max(n, m);
                int b = Math.Min(n, m);
                int r;
                while(b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }
                txtRes.Text = a.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtM.Clear();
            txtRes.Clear();
            txtN.Focus();
            rdCacUoc.Checked = false;
            rdUocMax.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
