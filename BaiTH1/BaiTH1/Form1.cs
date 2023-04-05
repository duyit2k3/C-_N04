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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test1 f1 = new Test1();
            f1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test2 f2 = new Test2();
            f2.Show();
        }
    }
}
