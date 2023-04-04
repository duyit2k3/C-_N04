using System;
using System.Windows.Forms;

namespace BaiNgay11_3
{
    public partial class Formbai5 : Form
    {
        public Formbai5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTInh_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (Int32.TryParse(txtN.Text, out n))
            {
                if (n > 0)
                {
                    txtRes1.Text = "";
                    txtRes2.Text = "";
                    int sum = 0;
                    for(int i = 1; i <= n; i++)
                    {
                        if(i != n)
                        {
                            txtRes1.Text += i.ToString() + " + ";
                        }
                        else
                        {
                            txtRes1.Text += i.ToString();
                        }
                        sum += i;
                    }
                    txtRes2.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("Nhập dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtN.Clear();
                    txtN.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtN.Clear();
                txtN.Focus();
            }
        }
    }
}
