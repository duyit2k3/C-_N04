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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formvd4 f1 = new Formvd4();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formvd42 f2 = new Formvd42();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formvd43 f3 = new Formvd43();  
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formvd44 f4 = new Formvd44();  
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formvd45 f5 = new Formvd45();
            f5.Show();
        }
    }
}
