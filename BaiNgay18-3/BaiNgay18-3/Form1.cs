using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiNgay18_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbai1 f1 = new Formbai1();
            f1.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbai2 f2 = new Formbai2();
            f2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbai3 f3 = new Formbai3();
            f3.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbai4 f4 = new Formbai4();  
            f4.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbai5 f5 = new Formbai5();   
            f5.Show();
        }
    }
}
