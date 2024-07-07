namespace retoxikalo
{
    partial class SugoForm
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
            this.rchTxtBoxSugo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtBoxSugo
            // 
            this.rchTxtBoxSugo.BackColor = System.Drawing.Color.White;
            this.rchTxtBoxSugo.Enabled = false;
            this.rchTxtBoxSugo.Location = new System.Drawing.Point(39, 43);
            this.rchTxtBoxSugo.Name = "rchTxtBoxSugo";
            this.rchTxtBoxSugo.ReadOnly = true;
            this.rchTxtBoxSugo.Size = new System.Drawing.Size(405, 323);
            this.rchTxtBoxSugo.TabIndex = 0;
            this.rchTxtBoxSugo.Text = "";
            // 
            // SugoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.rchTxtBoxSugo);
            this.Name = "SugoForm";
            this.Text = "Súgó";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBoxSugo;
    }
}