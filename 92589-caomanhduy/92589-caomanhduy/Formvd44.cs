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
    public partial class Formvd44 : Form
    {
        public Formvd44()
        {
            InitializeComponent();
        }
        int i = 10;
        private void Formvd44_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDongho.Text = i.ToString();
            i--;
            if(i < 0)
            {
                timer1.Enabled = false;
                lbDongho.Text = "Hết giờ!";
            }
        }
    }
}
