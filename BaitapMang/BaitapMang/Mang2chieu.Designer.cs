namespace BaitapMang
{
    partial class Mang2chieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAvr = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.lblRes);
            this.panel1.Location = new System.Drawing.Point(28, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 409);
            this.panel1.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(560, 33);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(163, 98);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(560, 152);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(163, 47);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Giá trị lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(560, 219);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(163, 47);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Giá trị nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(560, 296);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(163, 47);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Tổng ";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAvr
            // 
            this.btnAvr.Location = new System.Drawing.Point(560, 371);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(163, 71);
            this.btnAvr.TabIndex = 5;
            this.btnAvr.Text = "Trung bình cộng";
            this.btnAvr.UseVisualStyleBackColor = true;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(28, 464);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(128, 62);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(204, 464);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 62);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(390, 464);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(128, 62);
            this.btnDung.TabIndex = 9;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRes.Location = new System.Drawing.Point(28, 29);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 31);
            this.lblRes.TabIndex = 0;
            // 
            // Mang2chieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 552);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnAvr);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mang2chieu";
            this.Text = "Mang2chieu";
            this.Load += new System.EventHandler(this.Mang2chieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAvr;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
    }
}