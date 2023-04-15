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
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMess_TextChanged(object sender, EventArgs e)
        {
            if(rdBlack.Checked == true)
            {
                txtMess.ForeColor = Color.Black;
            }
            if(rdBlue.Checked == true)
            {
                txtMess.ForeColor = Color.Blue;
            }
            if(rdGreen.Checked == true)
            {
                txtMess.ForeColor = Color.Green;   
            }
            if(rdRed.Checked == true)
            {
                txtMess.ForeColor = Color.Red;
            }
            if(chkBold.Checked == true)
            {
                txtMess.Font = new Font(txtMess.Font, FontStyle.Bold);
            }
        }
    }
}
