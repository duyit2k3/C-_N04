namespace vidu
{
    partial class Formvd1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVanban = new System.Windows.Forms.TextBox();
            this.txtchuoi = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchuoi1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung văn bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chuỗi tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả đã thay thế:";
            // 
            // txtVanban
            // 
            this.txtVanban.Location = new System.Drawing.Point(237, 59);
            this.txtVanban.Name = "txtVanban";
            this.txtVanban.Size = new System.Drawing.Size(362, 30);
            this.txtVanban.TabIndex = 3;
            // 
            // txtchuoi
            // 
            this.txtchuoi.Location = new System.Drawing.Point(237, 135);
            this.txtchuoi.Name = "txtchuoi";
            this.txtchuoi.Size = new System.Drawing.Size(362, 30);
            this.txtchuoi.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(237, 282);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(362, 30);
            this.txtkq.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 93);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thay thế";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập chuỗi thay thế:";
            // 
            // txtchuoi1
            // 
            this.txtchuoi1.Location = new System.Drawing.Point(237, 209);
            this.txtchuoi1.Name = "txtchuoi1";
            this.txtchuoi1.Size = new System.Drawing.Size(362, 30);
            this.txtchuoi1.TabIndex = 10;
            // 
            // Formvd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 414);
            this.Controls.Add(this.txtchuoi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtchuoi);
            this.Controls.Add(this.txtVanban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formvd1";
            this.Text = "Ví dụ 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVanban;
        private System.Windows.Forms.TextBox txtchuoi;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchuoi1;
    }
}