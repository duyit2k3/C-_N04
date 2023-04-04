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
    public partial class Formnhap : Form
    {
        public Formnhap()
        {
            InitializeComponent();
        }
        public string DataGet { get; set; }
        public bool check = true;
        private void btnOK_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (Int32.TryParse(txtN.Text, out n))
            {

                DataGet = n.ToString();
                txtN.Clear();
                txtN.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }
    }
}
