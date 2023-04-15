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
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }
        string input = "";
        private void txtRes_KeyDown(object sender, KeyEventArgs e)
        {
            input = e.KeyData.ToString();
            SuKienKeyDown();
        }

        private void txtRes_KeyUp(object sender, KeyEventArgs e)
        {
            input = e.KeyData.ToString();
            SuKienKeyUp();
        }

        void SuKienKeyDown()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr.GetType() == typeof(Label))
                {
                    if(ctr.Text.ToUpper() == input.ToUpper())
                    {
                        ctr.BackColor = Color.Red;
                    }
                }
            }
        }

        void SuKienKeyUp()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr.GetType() == typeof(Label))
                {
                    if(ctr.Text.ToUpper() == input.ToUpper())
                    {
                        ctr.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
