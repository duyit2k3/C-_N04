using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH1
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void txtTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int sl = 0;
            double dg = 0;
            if (int.TryParse(txtSL.Text, out sl))
            {
                if(sl <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn hoặc bằng 0!");
                    txtSL.Clear();
                    txtSL.Focus();
                }
            }
            else
            {
                MessageBox.Show("Số lượng phải nhập số!");
                txtSL.Clear();
                txtSL.Focus();
            }
            if(double.TryParse(txtDG.Text, out dg))
            {
                if(dg < 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn hoặc bằng 0");
                    txtDG.Clear();
                }
            }
            else
            {
                MessageBox.Show("Đơn giá phải nhập số!");
                txtDG.Clear();
                txtDG.Focus();
            }
            txtTT.Text = (sl * dg).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTH.Clear();
            txtSL.Clear();
            txtDG.Clear();
            txtTH.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                this.Close();
            }
        }
    }
}
