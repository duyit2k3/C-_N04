namespace De2
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
            this.lblTenmon = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtThemMon = new System.Windows.Forms.TextBox();
            this.btnChon1 = new System.Windows.Forms.Button();
            this.btnChonAll1 = new System.Windows.Forms.Button();
            this.btnChon2 = new System.Windows.Forms.Button();
            this.btnChonAll2 = new System.Windows.Forms.Button();
            this.lst_ThucDon = new System.Windows.Forms.ListBox();
            this.lst_Chon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTenmon
            // 
            this.lblTenmon.AutoSize = true;
            this.lblTenmon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenmon.Location = new System.Drawing.Point(39, 68);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(130, 38);
            this.lblTenmon.TabIndex = 0;
            this.lblTenmon.Text = "Tên món:";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(548, 57);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(171, 64);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm ";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtThemMon
            // 
            this.txtThemMon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThemMon.Location = new System.Drawing.Point(194, 68);
            this.txtThemMon.Name = "txtThemMon";
            this.txtThemMon.Size = new System.Drawing.Size(302, 43);
            this.txtThemMon.TabIndex = 2;
            // 
            // btnChon1
            // 
            this.btnChon1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon1.Location = new System.Drawing.Point(339, 174);
            this.btnChon1.Name = "btnChon1";
            this.btnChon1.Size = new System.Drawing.Size(77, 59);
            this.btnChon1.TabIndex = 3;
            this.btnChon1.Text = ">";
            this.btnChon1.UseVisualStyleBackColor = true;
            this.btnChon1.Click += new System.EventHandler(this.btnChon1_Click);
            // 
            // btnChonAll1
            // 
            this.btnChonAll1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonAll1.Location = new System.Drawing.Point(339, 271);
            this.btnChonAll1.Name = "btnChonAll1";
            this.btnChonAll1.Size = new System.Drawing.Size(77, 59);
            this.btnChonAll1.TabIndex = 4;
            this.btnChonAll1.Text = ">>";
            this.btnChonAll1.UseVisualStyleBackColor = true;
            this.btnChonAll1.Click += new System.EventHandler(this.btnChonAll1_Click);
            // 
            // btnChon2
            // 
            this.btnChon2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon2.Location = new System.Drawing.Point(339, 366);
            this.btnChon2.Name = "btnChon2";
            this.btnChon2.Size = new System.Drawing.Size(77, 59);
            this.btnChon2.TabIndex = 5;
            this.btnChon2.Text = "<";
            this.btnChon2.UseVisualStyleBackColor = true;
            this.btnChon2.Click += new System.EventHandler(this.btnChon2_Click);
            // 
            // btnChonAll2
            // 
            this.btnChonAll2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonAll2.Location = new System.Drawing.Point(339, 455);
            this.btnChonAll2.Name = "btnChonAll2";
            this.btnChonAll2.Size = new System.Drawing.Size(77, 59);
            this.btnChonAll2.TabIndex = 6;
            this.btnChonAll2.Text = "<<";
            this.btnChonAll2.UseVisualStyleBackColor = true;
            this.btnChonAll2.Click += new System.EventHandler(this.btnChonAll2_Click);
            // 
            // lst_ThucDon
            // 
            this.lst_ThucDon.FormattingEnabled = true;
            this.lst_ThucDon.ItemHeight = 28;
            this.lst_ThucDon.Location = new System.Drawing.Point(37, 174);
            this.lst_ThucDon.Name = "lst_ThucDon";
            this.lst_ThucDon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_ThucDon.Size = new System.Drawing.Size(267, 340);
            this.lst_ThucDon.TabIndex = 7;
            // 
            // lst_Chon
            // 
            this.lst_Chon.FormattingEnabled = true;
            this.lst_Chon.ItemHeight = 28;
            this.lst_Chon.Location = new System.Drawing.Point(452, 174);
            this.lst_Chon.Name = "lst_Chon";
            this.lst_Chon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_Chon.Size = new System.Drawing.Size(267, 340);
            this.lst_Chon.TabIndex = 8;
            // 
            // Formbai2
            // 
            this.AcceptButton = this.btnThemMon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 613);
            this.Controls.Add(this.lst_Chon);
            this.Controls.Add(this.lst_ThucDon);
            this.Controls.Add(this.btnChonAll2);
            this.Controls.Add(this.btnChon2);
            this.Controls.Add(this.btnChonAll1);
            this.Controls.Add(this.btnChon1);
            this.Controls.Add(this.txtThemMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.lblTenmon);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formbai2";
            this.Text = "Formbai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenmon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtThemMon;
        private System.Windows.Forms.Button btnChon1;
        private System.Windows.Forms.Button btnChonAll1;
        private System.Windows.Forms.Button btnChon2;
        private System.Windows.Forms.Button btnChonAll2;
        private System.Windows.Forms.ListBox lst_ThucDon;
        private System.Windows.Forms.ListBox lst_Chon;
    }
}