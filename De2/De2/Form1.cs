using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Formbai2 f1 = new Formbai2();
            f1.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Formbai3 f2 = new Formbai3();
            f2.Show();
        }
    }
}
