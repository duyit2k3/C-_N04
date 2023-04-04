namespace BaiNgay11_3
{
    partial class Form1
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
            this.btnBai5 = new System.Windows.Forms.Button();
            this.btnBai6 = new System.Windows.Forms.Button();
            this.btnBai7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai5
            // 
            this.btnBai5.Location = new System.Drawing.Point(72, 66);
            this.btnBai5.Name = "btnBai5";
            this.btnBai5.Size = new System.Drawing.Size(219, 82);
            this.btnBai5.TabIndex = 0;
            this.btnBai5.Text = "Bài 5";
            this.btnBai5.UseVisualStyleBackColor = true;
            this.btnBai5.Click += new System.EventHandler(this.btnBai5_Click);
            // 
            // btnBai6
            // 
            this.btnBai6.Location = new System.Drawing.Point(419, 66);
            this.btnBai6.Name = "btnBai6";
            this.btnBai6.Size = new System.Drawing.Size(219, 82);
            this.btnBai6.TabIndex = 1;
            this.btnBai6.Text = "Bài 6";
            this.btnBai6.UseVisualStyleBackColor = true;
            this.btnBai6.Click += new System.EventHandler(this.btnBai6_Click);
            // 
            // btnBai7
            // 
            this.btnBai7.Location = new System.Drawing.Point(72, 215);
            this.btnBai7.Name = "btnBai7";
            this.btnBai7.Size = new System.Drawing.Size(219, 82);
            this.btnBai7.TabIndex = 2;
            this.btnBai7.Text = "Bài 7";
            this.btnBai7.UseVisualStyleBackColor = true;
            this.btnBai7.Click += new System.EventHandler(this.btnBai7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 453);
            this.Controls.Add(this.btnBai7);
            this.Controls.Add(this.btnBai6);
            this.Controls.Add(this.btnBai5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai5;
        private System.Windows.Forms.Button btnBai6;
        private System.Windows.Forms.Button btnBai7;
    }
}

