using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu
{
    public partial class Formvd1 : Form
    {
        public Formvd1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = this.txtVanban.Text.IndexOf(this.txtchuoi.Text);
            if(idx > 0)
            {
                MessageBox.Show("Có tồn tại");
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = this.txtVanban.Text.IndexOf(this.txtchuoi.Text);
            if (idx > 0)
            {
                string res;
                res = this.txtVanban.Text.Substring(0, idx);
                res += txtchuoi1.Text;
                res += this.txtVanban.Text.Substring(idx + txtchuoi.Text.Length);
                int chk = res.IndexOf(txtchuoi.Text);
                while(chk > 0)
                {
                    string res1 = res;
                    res = res1.Substring(0, chk);
                    res += txtchuoi1.Text;
                    res += res1.Substring(chk + txtchuoi.Text.Length);
                    chk = res.IndexOf(txtchuoi.Text);
                }
                txtkq.Text = res;
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
