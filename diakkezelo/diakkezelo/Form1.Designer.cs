namespace diakkezelo
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
            this.pnlDiakok = new System.Windows.Forms.Panel();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKivalasztottak = new System.Windows.Forms.ListBox();
            this.lstLegidosebbek = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDiak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDiakok
            // 
            this.pnlDiakok.AutoScroll = true;
            this.pnlDiakok.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlDiakok.Location = new System.Drawing.Point(37, 90);
            this.pnlDiakok.Name = "pnlDiakok";
            this.pnlDiakok.Size = new System.Drawing.Size(269, 306);
            this.pnlDiakok.TabIndex = 0;
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(37, 414);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 1;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Location = new System.Drawing.Point(231, 414);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 2;
            this.btnKivalaszt.Text = "Kiválasztás";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(425, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiválasztottak";
            // 
            // lstKivalasztottak
            // 
            this.lstKivalasztottak.FormattingEnabled = true;
            this.lstKivalasztottak.Location = new System.Drawing.Point(365, 90);
            this.lstKivalasztottak.Name = "lstKivalasztottak";
            this.lstKivalasztottak.Size = new System.Drawing.Size(271, 173);
            this.lstKivalasztottak.TabIndex = 5;
            this.lstKivalasztottak.SelectedIndexChanged += new System.EventHandler(this.lstKivalasztottak_SelectedIndexChanged);
            // 
            // lstLegidosebbek
            // 
            this.lstLegidosebbek.FormattingEnabled = true;
            this.lstLegidosebbek.Location = new System.Drawing.Point(365, 317);
            this.lstLegidosebbek.Name = "lstLegidosebbek";
            this.lstLegidosebbek.Size = new System.Drawing.Size(271, 82);
            this.lstLegidosebbek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Legidősebbek:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(371, 419);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(0, 13);
            this.lblDiak.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLegidosebbek);
            this.Controls.Add(this.lstKivalasztottak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.pnlDiakok);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiakok;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKivalasztottak;
        private System.Windows.Forms.ListBox lstLegidosebbek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDiak;
    }
}

