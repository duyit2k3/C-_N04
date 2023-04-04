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
    public partial class Formbai5 : Form
    {
        public Formbai5()
        {
            InitializeComponent();
        }
        private void ThietLapViTriComboBox()
        {
            cboVT.Items.Clear();
            int idx = dsSanPham.Items.Count;
            for (int i = 1; i <= idx; i++)
            {
                cboVT.Items.Add(i.ToString());
            }
        }
        private void Formbai5_Load(object sender, EventArgs e)
        {
            ThietLapViTriComboBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThemsp.Text.Trim() != "")
            {
                dsSanPham.Items.Add(txtThemsp.Text);
                txtThemsp.Text = "";
                ThietLapViTriComboBox();
            }
            else
            {
                MessageBox.Show("Phải nhập tên sản phẩm");
            }
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if(txtThemspvt.Text.Trim() != "")
            {
                if(cboVT.Text != "")
                {
                    dsSanPham.Items.Insert(Convert.ToInt32(cboVT.Text), txtThemspvt.Text);
                    txtThemspvt.Text = "";
                    ThietLapViTriComboBox();
                }
                else
                {
                    MessageBox.Show("Phải chọn vị trí hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Phải nhập tên sản phẩm");
            }
        }

        private void btnXoads_Click(object sender, EventArgs e)
        {
            if(dsSanPham.Items.Count> 0)
            {
                dsSanPham.Items.Clear();
            }
            else
            {
                MessageBox.Show("Danh sách sản phẩm chưa có gì");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dsSanPham.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa ");
            }
            else
            {
                dsSanPham.Items.Remove(dsSanPham.SelectedItem);
                MessageBox.Show("Xóa sản phẩm thành công");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTim.Text != "")
            {
                if(dsSanPham.Items.Contains(txtTim.Text) == true)
                {
                    MessageBox.Show("Tìm thấy sản phẩm");
                }
                else
                {
                    MessageBox.Show("Không Tìm thấy sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Nhập tên sản phẩm cần tìm");
            }
        }
    }
}
