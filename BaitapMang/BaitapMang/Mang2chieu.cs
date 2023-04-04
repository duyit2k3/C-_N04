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
    public partial class Mang2chieu : Form
    {
        const int rw = 4;
        const int col = 5;
        int[,] arr2 = new int[4, 5];
        public Mang2chieu()
        {
            InitializeComponent();
        }

        private void Mang2chieu_Load(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lblRes.Text = "Mảng 2 chiều đã được nhập.";
            for (int i = 0; i < rw; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr2[i, j] = i + j;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(lblRes.Text != "")
            {
                lblRes.Text = "Mảng 2 chiều đã nhập là:\n\r";
                for (int i = 0; i < rw; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        lblRes.Text += arr2[i, j].ToString() + "           ";
                    }
                    lblRes.Text += "\n\r";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mảng!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(lblRes.Text != "")
            {
                int max = arr2[0, 0];
                for(int i = 0; i < rw; i++)
                {
                    for(int j = 0; j < col; j++)
                    {
                        if (arr2[i, j] > max)
                        {
                            max = arr2[i, j];
                        }
                    }
                }
                lblRes.Text = "Giá trị lớn nhất của mảng là:\n\r";
                lblRes.Text += max.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mảng!");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (lblRes.Text != "")
            {
                int min = arr2[0, 0];
                for (int i = 0; i < rw; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (arr2[i, j] < min)
                        {
                            min = arr2[i, j];
                        }
                    }
                }
                lblRes.Text = "Giá trị lớn nhất của mảng là:\n\r";
                lblRes.Text += min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mảng!");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (lblRes.Text != "")
            {
                int sum = 0;
                for (int i = 0; i < rw; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sum += arr2[i, j];
                    }
                }
                lblRes.Text = "Tổng các phần tử của mảng là:\n\r";
                lblRes.Text += sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mảng!");
            }
        }

        private void btnAvr_Click(object sender, EventArgs e)
        {
            if (lblRes.Text != "")
            {
                int sum = 0;
                for (int i = 0; i < rw; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sum += arr2[i, j];
                    }
                }
                lblRes.Text = "Trung bình cộng các phần tử của mảng là:\n\r";
                double res = 1.0 * sum / (rw * col);
                lblRes.Text += res.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mảng!");
            }
        }
    }
}
