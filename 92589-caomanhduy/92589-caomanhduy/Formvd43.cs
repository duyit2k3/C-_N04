using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _92589_caomanhduy
{
    public partial class Formvd43 : Form
    {
        public Formvd43()
        {
            InitializeComponent();
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            if(rd1.Checked)
            {
                txtKq.Text = txtName.Text.ToLower();
            }
            if(rd2.Checked)
            {
                txtKq.Text = txtName.Text.ToUpper();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtKq.Clear();
            rd1.Checked = false;
            rd2.Checked = false;
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
