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
    public partial class Formbai3 : Form
    {
        public Formbai3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = imgBuomBay.Location.X;
            int y = imgBuomBay.Location.Y;

            //Dịch chuyển hình ảnh sang phải
            x += 10;

            //Nếu hình ảnh rời khỏi form đặt lại vị trí ban đầu
            if(x > this.ClientSize.Width - imgBuomBay.ClientSize.Width)
            {
                x = 0;
            }
            //Cập nhật vị trí mới của ảnh
            imgBuomBay.Location= new Point(x, y);
        }

        private void Formbai3_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
