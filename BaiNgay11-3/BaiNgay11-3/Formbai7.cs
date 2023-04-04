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
    public partial class Formbai7 : Form
    {
        public Formbai7()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            txtRes.Text = "";
            int n = 0;
            if(Int32.TryParse(txtN.Text, out n))
            {
                //Lưu các chuỗi tương ứng với các số từ 0 -> 9
                string[] chuso = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

                //Xử lý hàng trăm
                int hundreds = n / 100;
                if(hundreds > 0)
                {
                    txtRes.Text += chuso[hundreds] + " Trăm ";
                }
                // Xử lý hàng chục và hàng đơn vị
                int tens = (n % 100) / 10;
                int ones = n % 10;
                // Trường hợp đặc biệt: số 10 đến 19
                if(tens == 1)
                {
                    txtRes.Text += " Mười ";
                    if(ones > 0)
                    {
                        txtRes.Text += chuso[ones];
                    }
                }
                else
                {
                    if (tens > 1)
                    {
                        txtRes.Text += chuso[tens] + " Mươi ";
                    }
                    if(tens == 0 && ones > 0)
                    {
                        txtRes.Text += " Linh " + chuso[ones];
                    }
                    if (ones > 0 && tens != 0)
                    {
                        txtRes.Text += chuso[ones];
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtN.Clear();
                txtN.Focus();
            }
        }
    }
}
