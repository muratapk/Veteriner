namespace Veteriner
{
    partial class Anaform
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
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayvanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ziyaretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.hayvanlarToolStripMenuItem,
            this.aşıToolStripMenuItem,
            this.ziyaretToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // hayvanlarToolStripMenuItem
            // 
            this.hayvanlarToolStripMenuItem.Name = "hayvanlarToolStripMenuItem";
            this.hayvanlarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hayvanlarToolStripMenuItem.Text = "Hayvanlar";
            this.hayvanlarToolStripMenuItem.Click += new System.EventHandler(this.hayvanlarToolStripMenuItem_Click);
            // 
            // aşıToolStripMenuItem
            // 
            this.aşıToolStripMenuItem.Name = "aşıToolStripMenuItem";
            this.aşıToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.aşıToolStripMenuItem.Text = "Aşı";
            this.aşıToolStripMenuItem.Click += new System.EventHandler(this.aşıToolStripMenuItem_Click);
            // 
            // ziyaretToolStripMenuItem
            // 
            this.ziyaretToolStripMenuItem.Name = "ziyaretToolStripMenuItem";
            this.ziyaretToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ziyaretToolStripMenuItem.Text = "Ziyaret";
            this.ziyaretToolStripMenuItem.Click += new System.EventHandler(this.ziyaretToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayvanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ziyaretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}