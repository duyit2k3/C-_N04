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
    public partial class Formvd42 : Form
    {
        public Formvd42()
        {
            InitializeComponent();
        }

        private void btnOkk_Click(object sender, EventArgs e)
        {
            txtRes.Text = "Bạn đã chọn website ";
            txtRes.Text += cbWeb.SelectedItem.ToString();
        }

        private void btnResett_Click(object sender, EventArgs e)
        {
            txtRes.ResetText();
        }
    }
}
