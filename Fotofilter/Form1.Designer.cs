namespace Fotofilter
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
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaBildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGGBBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenIMG = new System.Windows.Forms.OpenFileDialog();
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.SaveAs = new System.Windows.Forms.SaveFileDialog();
            this.sparaBildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1390, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaBildToolStripMenuItem,
            this.sparaBildToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaBildToolStripMenuItem
            // 
            this.öppnaBildToolStripMenuItem.Name = "öppnaBildToolStripMenuItem";
            this.öppnaBildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öppnaBildToolStripMenuItem.Text = "Öppna bild";
            this.öppnaBildToolStripMenuItem.Click += new System.EventHandler(this.öppnaBildToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGGBBRToolStripMenuItem,
            this.invertToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // rGGBBRToolStripMenuItem
            // 
            this.rGGBBRToolStripMenuItem.Name = "rGGBBRToolStripMenuItem";
            this.rGGBBRToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.rGGBBRToolStripMenuItem.Text = "R --> G, G --> B, B-->R";
            this.rGGBBRToolStripMenuItem.Click += new System.EventHandler(this.rGGBBRToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // OpenIMG
            // 
            this.OpenIMG.FileName = "OpenIMG";
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(148, 54);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(866, 450);
            this.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox.TabIndex = 1;
            this.Picbox.TabStop = false;
            // 
            // sparaBildToolStripMenuItem
            // 
            this.sparaBildToolStripMenuItem.Name = "sparaBildToolStripMenuItem";
            this.sparaBildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaBildToolStripMenuItem.Text = "Spara bild";
            this.sparaBildToolStripMenuItem.Click += new System.EventHandler(this.sparaBildToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 730);
            this.Controls.Add(this.Picbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenIMG;
        private System.Windows.Forms.ToolStripMenuItem öppnaBildToolStripMenuItem;
        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGGBBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaBildToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveAs;
    }
}

