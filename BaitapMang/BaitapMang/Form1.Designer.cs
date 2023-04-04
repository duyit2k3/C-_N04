namespace BaitapMang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mảng2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mảng2ChiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mảng2ToolStripMenuItem,
            this.mảng2ChiềuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mảng2ToolStripMenuItem
            // 
            this.mảng2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mảng2ToolStripMenuItem.Name = "mảng2ToolStripMenuItem";
            this.mảng2ToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.mảng2ToolStripMenuItem.Text = "Mảng 1 chiều";
            this.mảng2ToolStripMenuItem.Click += new System.EventHandler(this.mảng2ToolStripMenuItem_Click);
            // 
            // mảng2ChiềuToolStripMenuItem
            // 
            this.mảng2ChiềuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mảng2ChiềuToolStripMenuItem.Name = "mảng2ChiềuToolStripMenuItem";
            this.mảng2ChiềuToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.mảng2ChiềuToolStripMenuItem.Text = "Mảng 2 chiều";
            this.mảng2ChiềuToolStripMenuItem.Click += new System.EventHandler(this.mảng2ChiềuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 559);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mảng2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mảng2ChiềuToolStripMenuItem;
    }
}

