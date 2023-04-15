namespace BaiTH1
{
    partial class Test2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBlack = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMess);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(183, 92);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(402, 34);
            this.txtMess.TabIndex = 3;
            this.txtMess.TextChanged += new System.EventHandler(this.txtMess_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 34);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBlack);
            this.groupBox2.Controls.Add(this.rdBlue);
            this.groupBox2.Controls.Add(this.rdGreen);
            this.groupBox2.Controls.Add(this.rdRed);
            this.groupBox2.Location = new System.Drawing.Point(113, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rdBlack
            // 
            this.rdBlack.AutoSize = true;
            this.rdBlack.Location = new System.Drawing.Point(21, 157);
            this.rdBlack.Name = "rdBlack";
            this.rdBlack.Size = new System.Drawing.Size(78, 32);
            this.rdBlack.TabIndex = 3;
            this.rdBlack.TabStop = true;
            this.rdBlack.Text = "Black";
            this.rdBlack.UseVisualStyleBackColor = true;
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.BackColor = System.Drawing.SystemColors.Control;
            this.rdBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdBlue.Location = new System.Drawing.Point(21, 119);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(70, 32);
            this.rdBlue.TabIndex = 2;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = false;
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.ForeColor = System.Drawing.Color.Green;
            this.rdGreen.Location = new System.Drawing.Point(21, 81);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(85, 32);
            this.rdGreen.TabIndex = 1;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.ForeColor = System.Drawing.Color.Red;
            this.rdRed.Location = new System.Drawing.Point(21, 43);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(66, 32);
            this.rdRed.TabIndex = 0;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkUnderline);
            this.groupBox3.Controls.Add(this.chkItalic);
            this.groupBox3.Controls.Add(this.chkBold);
            this.groupBox3.Location = new System.Drawing.Point(444, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Style";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkUnderline.Location = new System.Drawing.Point(49, 144);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(119, 32);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkItalic.Location = new System.Drawing.Point(49, 96);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(75, 32);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBold.Location = new System.Drawing.Point(49, 44);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(77, 32);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Test2";
            this.Text = "Test2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
    }
}