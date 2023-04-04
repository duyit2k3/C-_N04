using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapMang
{
    public partial class Mang1chieu : Form
    {
        public Mang1chieu()
        {
            InitializeComponent();
        }
        int spt = 0;
        int[] arr = new int[10];
        private void Mang1chieu_Load(object sender, EventArgs e)
        {
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if(spt == 10)
            {
                MessageBox.Show("Mảng đã đầy!");
                txtNhap.Clear();
                txtNhap.ReadOnly = true;
            }
            else
            {
                int n;
                if(int.TryParse(txtNhap.Text, out n))
                {
                    arr[spt] = n;
                    spt++;
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
                else
                {
                    MessageBox.Show("Nội dung nhập không đúng theo yêu cầu");
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.lblKq.Text = "Mảng đã nhập là:\n\r";
            for(int i = 0; i < spt; i++)
            {
                this.lblKq.Text += arr[i].ToString() + " ";
            }
            txtNhap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblKq.Text = "";
            spt = 0;
            txtNhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(spt != 0)
            {
                this.lblKq.Text = "Giá trị lớn nhất của mảng là:\n\r";
                int max = arr[0];
                for(int i = 1; i < spt; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                this.lblKq.Text += max.ToString();
            }
            else
            {
                MessageBox.Show("Mảng rỗng!");
                txtNhap.Focus();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(spt != 0)
            {
                this.lblKq.Text = "Giá trị nhỏ nhất của mảng là:\n\r";
                int min = arr[0];
                for(int i = 1; i < spt; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                this.lblKq.Text += min.ToString();
            }
            else
            {
                MessageBox.Show("Mảng rỗng!");
                txtNhap.Focus();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(spt != 0)
            {
                this.lblKq.Text = "Tổng các phần tử trong mảng là:\n\r";
                int sum = 0;
                for(int i = 0; i < spt; i++)
                {
                    sum += arr[i];
                }
                this.lblKq.Text += sum.ToString();
            }
            else
            {
                MessageBox.Show("Mảng rỗng!");
                txtNhap.Focus();
            }
        }

        private void btnAvr_Click(object sender, EventArgs e)
        {
            if(spt != 0)
            {
                this.lblKq.Text = "Trung bình cộng các phần tử trong mảng là:\n\r";
                int sum = 0;
                for(int i = 0; i < spt; i++)
                {
                    sum += arr[i];
                }
                double res = 1.0 * sum / spt;
                this.lblKq.Text += res.ToString();
            }
            else
            {
                MessageBox.Show("Mảng rỗng!");
                txtNhap.Focus();
            }
        }
    }
}
