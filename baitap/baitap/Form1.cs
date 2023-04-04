using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formb6 f1 = new Formb6();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formb7cs f7 = new Formb7cs();
            f7.Show();
        }
    }
}
