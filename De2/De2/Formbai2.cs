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
    public partial class Formbai2 : Form
    {
        public Formbai2()
        {
            InitializeComponent();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (!lst_ThucDon.Items.Contains(txtThemMon.Text) && txtThemMon.Text != "")
            {
                lst_ThucDon.Items.Add(txtThemMon.Text);
                txtThemMon.Clear();
                txtThemMon.Focus();
            }
            else if(txtThemMon.Text != "")
            {
                MessageBox.Show("Tồn tại món đã nhập!");
                txtThemMon.Clear();
                txtThemMon.Focus();
            }
        }

        private void btnChon1_Click(object sender, EventArgs e)
        {
            if(lst_ThucDon.SelectedItems.Count == 1)
            {
                string s = lst_ThucDon.SelectedItem.ToString();
                if (!lst_Chon.Items.Contains(s))
                {
                    lst_Chon.Items.Add(s);
                }
            }
        }

        private void btnChonAll1_Click(object sender, EventArgs e)
        {
            foreach(string item in lst_ThucDon.Items)
            {
               if (!lst_Chon.Items.Contains(item))
               {
                    lst_Chon.Items.Add(item);
               }
            }
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            if(lst_Chon.SelectedItems.Count == 1)
            {
                lst_Chon.Items.Remove(lst_Chon.SelectedItem);
            }
        }

        private void btnChonAll2_Click(object sender, EventArgs e)
        {
            lst_Chon.Items.Clear();
        }
    }
}
