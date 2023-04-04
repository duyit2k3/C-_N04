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
    public partial class Formvd4 : Form
    {
        public Formvd4()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Bạn đã chọn Website ";
            txtKq.Text += lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKq.ResetText();
        }
    }
}
