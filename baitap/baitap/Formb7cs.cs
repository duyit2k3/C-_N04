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
    public partial class Formb7cs : Form
    {
        public Formb7cs()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            txtRes.Text = "";
            string s = txtN.Text;
            int l = s.Length;
            int i = 0;
            while(i < l)
            {
                switch(s[i])
                {
                    case '0':
                        txtRes.Text += "Không ";
                    break;
                    case '1':
                        if (i == l - 1)
                            txtRes.Text += "Mốt";
                        
                        break;
                    case '2':
                        txtRes.Text += "Hai ";
                        break;
                    case '3':
                        txtRes.Text += "Ba ";
                        break;
                    case '4':
                        txtRes.Text += "Bốn ";
                        break;
                    case '5':
                        txtRes.Text += "Năm ";
                        break;
                    case '6':
                        txtRes.Text += "Sáu ";
                        break;
                    case '7':
                        txtRes.Text += "Bảy ";
                        break;
                    case '8':
                        txtRes.Text += "Tám ";
                        break;
                    case '9':
                        txtRes.Text += "Chín ";
                        break;
                }
                if(l - i == 3)
                {
                    txtRes.Text += "Trăm ";
                }
                if(l - i == 2 )
                {
                    if(s[i] != '1')
                    {
                        txtRes.Text += "Mươi ";
                    }
                    else
                    {
                        txtRes.Text += "Mười ";
                    }
                }
                i++;
            }
        }
    }
}
