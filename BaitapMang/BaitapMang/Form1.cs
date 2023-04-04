using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapMang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mảng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mang1chieu f1 = new Mang1chieu();
            f1.Show();
        }

        private void mảng2ChiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mang2chieu f2 = new Mang2chieu();
            f2.Show();
        }
    }
}
