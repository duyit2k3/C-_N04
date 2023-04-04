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
    public partial class Formbai3 : Form
    {
        public Formbai3()
        {
            InitializeComponent();
        }

        private void Formbai3_Load(object sender, EventArgs e)
        {
            cbName.Items.Add("Cao Mạnh Duy");
            lstMon.Items.Add("Bóng đá");
            lstMon.Items.Add("Bóng bàn");
            lstMon.Items.Add("Nhảy dù");
            lstMon.Items.Add("Bập bênh");
            lstMon.Items.Add("Cầu lông");
            lstMon.Items.Add("Bắn bi");
            DateTime now = DateTime.Now;
            string y = now.Year.ToString();
            string m = now.Month.ToString();
            string d = now.Day.ToString();
            string h = now.Hour.ToString();
            string mi = now.Minute.ToString();
            string s = now.Second.ToString();
            if(y.Length < 2)
            {
                y = "0" + y;
            }
            if (m.Length < 2)
            {
                m = "0" + m;
            }
            if (d.Length < 2)
            {
                d = "0" + d;
            }
            if(h.Length < 2)
            {
                h = "0" + h;
            }
            if (mi.Length < 2)
            {
                mi = "0" + mi;
            }
            if (s.Length < 2)
            {
                s = "0" + s;
            }
            txtDate.Text = d + "/" + m + "/" + y;
            txtTime.Text = h + ":" + mi + ":" + s;
        }

        private void btnChon1_Click(object sender, EventArgs e)
        {
            if(lstMon.Items.Count != 0 && lstMon.SelectedItem != null)
            {
                string s = lstMon.SelectedItem.ToString();
                if (!lstMon_chon.Items.Contains(s))
                {
                    lstMon_chon.Items.Add(s);
                    lstMon.Items.Remove(s);
                }
            }
        }

        private void btnChonAll1_Click(object sender, EventArgs e)
        {
            if(lstMon.Items.Count != 0)
            {
                foreach (string item in lstMon.Items)
                {
                    lstMon_chon.Items.Add(item);
                }
                while (lstMon.Items.Count != 0)
                {
                    lstMon.Items.Clear();
                }
            }
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            if(lstMon_chon.SelectedItem != null)
            {
                string s = lstMon_chon.SelectedItem.ToString();
                lstMon.Items.Add(s);
                lstMon_chon.Items.Remove(s);
            }
        }

        private void btnChonAll2_Click(object sender, EventArgs e)
        {
            if(lstMon_chon.Items.Count != 0)
            {
                foreach(string item in lstMon_chon.Items){
                    lstMon.Items.Add(item);
                }
                lstMon_chon.Items.Clear();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(cbName.SelectedItem != null)
            {
                if(lstMon_chon.Items.Count != 0)
                {
                    txtRes.Text = cbName.SelectedItem.ToString() + "\n\r";
                    txtRes.Text += "\n\r" + txtDate.Text + " " + txtTime.Text + "\n\r";
                    txtRes.Text += "\n\r" + "**Môn học đã chọn:" + "\n\r";
                    foreach(string item in lstMon_chon.Items)
                    {
                        txtRes.Text += "\n\r" + item + "\n\r";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn môn học!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tên sinh viên!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbName.SelectedItem = null;
            txtRes.Clear();
            foreach(string item in lstMon_chon.Items)
            {
                lstMon.Items.Add(item);
            }
            lstMon_chon.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
