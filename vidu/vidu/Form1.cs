using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu
{
    public partial class Formchu : Form
    {
        public Formchu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formvd1 f1 = new Formvd1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formvd2cs f2 = new Formvd2cs();
            f2.Show();
        }
    }
}
