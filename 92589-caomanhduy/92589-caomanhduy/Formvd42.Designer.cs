namespace _92589_caomanhduy
{
    partial class Formvd42
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
            this.cbWeb = new System.Windows.Forms.ComboBox();
            this.btnOkk = new System.Windows.Forms.Button();
            this.btnResett = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liên kết website";
            // 
            // cbWeb
            // 
            this.cbWeb.FormattingEnabled = true;
            this.cbWeb.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh niên",
            "VNExpress",
            "Dân trí",
            "Công an"});
            this.cbWeb.Location = new System.Drawing.Point(54, 147);
            this.cbWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbWeb.Name = "cbWeb";
            this.cbWeb.Size = new System.Drawing.Size(323, 30);
            this.cbWeb.TabIndex = 6;
            this.cbWeb.Text = "Liên kết Website";
            // 
            // btnOkk
            // 
            this.btnOkk.Location = new System.Drawing.Point(473, 137);
            this.btnOkk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOkk.Name = "btnOkk";
            this.btnOkk.Size = new System.Drawing.Size(114, 48);
            this.btnOkk.TabIndex = 7;
            this.btnOkk.Text = "Ok";
            this.btnOkk.UseVisualStyleBackColor = true;
            this.btnOkk.Click += new System.EventHandler(this.btnOkk_Click);
            // 
            // btnResett
            // 
            this.btnResett.Location = new System.Drawing.Point(627, 137);
            this.btnResett.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResett.Name = "btnResett";
            this.btnResett.Size = new System.Drawing.Size(114, 48);
            this.btnResett.TabIndex = 8;
            this.btnResett.Text = "Reset";
            this.btnResett.UseVisualStyleBackColor = true;
            this.btnResett.Click += new System.EventHandler(this.btnResett_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(54, 230);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(323, 30);
            this.txtRes.TabIndex = 9;
            // 
            // Formvd42
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnResett);
            this.Controls.Add(this.btnOkk);
            this.Controls.Add(this.cbWeb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formvd42";
            this.Text = "FormWebLinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWeb;
        private System.Windows.Forms.Button btnOkk;
        private System.Windows.Forms.Button btnResett;
        private System.Windows.Forms.TextBox txtRes;
    }
}