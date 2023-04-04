namespace BaiNgay18_3
{
    partial class Formbai2
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
            this.components = new System.ComponentModel.Container();
            this.lblChu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblChu
            // 
            this.lblChu.BackColor = System.Drawing.Color.MistyRose;
            this.lblChu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChu.ForeColor = System.Drawing.Color.Red;
            this.lblChu.Location = new System.Drawing.Point(54, 79);
            this.lblChu.Name = "lblChu";
            this.lblChu.Size = new System.Drawing.Size(966, 94);
            this.lblChu.TabIndex = 0;
            this.lblChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(60, 279);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(219, 75);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Chạy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(801, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(219, 75);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(422, 279);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(219, 75);
            this.btnDung.TabIndex = 3;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Formbai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 455);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblChu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formbai2";
            this.Text = "Chạy chữ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Timer timer1;
    }
}