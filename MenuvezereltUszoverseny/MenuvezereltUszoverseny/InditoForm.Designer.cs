namespace MenuvezereltUszoverseny
{
    partial class InditoForm
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
            this.fajlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlMenuItem,
            this.versenyMenuItem,
            this.eredmenyMenuItem,
            this.nevjegyMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlMenuItem
            // 
            this.fajlMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
            this.fajlMenuItem.Name = "fajlMenuItem";
            this.fajlMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlMenuItem.Text = "Fájl";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Megnyitás";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Mentés";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Kilépés";
            // 
            // versenyMenuItem
            // 
            this.versenyMenuItem.Enabled = false;
            this.versenyMenuItem.Name = "versenyMenuItem";
            this.versenyMenuItem.Size = new System.Drawing.Size(59, 20);
            this.versenyMenuItem.Text = "Verseny";
            this.versenyMenuItem.Click += new System.EventHandler(this.versenyMenuItem_Click);
            // 
            // eredmenyMenuItem
            // 
            this.eredmenyMenuItem.Enabled = false;
            this.eredmenyMenuItem.Name = "eredmenyMenuItem";
            this.eredmenyMenuItem.Size = new System.Drawing.Size(72, 20);
            this.eredmenyMenuItem.Text = "Eredmény";
            this.eredmenyMenuItem.Click += new System.EventHandler(this.eredmenyMenuItem_Click);
            // 
            // nevjegyMenuItem
            // 
            this.nevjegyMenuItem.Name = "nevjegyMenuItem";
            this.nevjegyMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nevjegyMenuItem.Text = "Névjegy";
            this.nevjegyMenuItem.Click += new System.EventHandler(this.nevjegyMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuvezereltUszoverseny.Properties.Resources.inditoFormKep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InditoForm";
            this.Text = "Úszóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredmenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevjegyMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

