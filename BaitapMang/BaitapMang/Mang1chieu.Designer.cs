namespace BaitapMang
{
    partial class Mang1chieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKq = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAvr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(58, 95);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(325, 48);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 phần tử mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(430, 95);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(159, 46);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.lblKq);
            this.panel1.Location = new System.Drawing.Point(58, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 246);
            this.panel1.TabIndex = 2;
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKq.Location = new System.Drawing.Point(26, 25);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(0, 31);
            this.lblKq.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(58, 432);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(161, 62);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(626, 159);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(166, 62);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Giá trị lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(626, 249);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(166, 62);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "Giá trị nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(243, 432);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(161, 62);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(430, 432);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(161, 62);
            this.btnDung.TabIndex = 7;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(626, 343);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(166, 62);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "Tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAvr
            // 
            this.btnAvr.Location = new System.Drawing.Point(626, 432);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(166, 62);
            this.btnAvr.TabIndex = 9;
            this.btnAvr.Text = "Trung bình cộng";
            this.btnAvr.UseVisualStyleBackColor = true;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // Mang1chieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 528);
            this.Controls.Add(this.btnAvr);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mang1chieu";
            this.Text = "Mảng 1 chiều";
            this.Load += new System.EventHandler(this.Mang1chieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAvr;
    }
}