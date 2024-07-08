namespace MenuvezereltUszoverseny
{
    partial class EredmenyForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.versenyzokLstBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrszagok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bezarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eredmenyRdBtn = new System.Windows.Forms.RadioButton();
            this.nevRdBtn = new System.Windows.Forms.RadioButton();
            this.idoEredmenyTxtBox = new System.Windows.Forms.TextBox();
            this.orszagTxtBox = new System.Windows.Forms.TextBox();
            this.rajtszamTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCim.Location = new System.Drawing.Point(67, 39);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(352, 24);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "300 méteres gyorsúszás eredménye:";
            this.lblCim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // versenyzokLstBox
            // 
            this.versenyzokLstBox.FormattingEnabled = true;
            this.versenyzokLstBox.Location = new System.Drawing.Point(36, 127);
            this.versenyzokLstBox.Name = "versenyzokLstBox";
            this.versenyzokLstBox.Size = new System.Drawing.Size(186, 342);
            this.versenyzokLstBox.TabIndex = 1;
            this.versenyzokLstBox.SelectedIndexChanged += new System.EventHandler(this.versenyzokLstBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résztvevők";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOrszagok
            // 
            this.btnOrszagok.Location = new System.Drawing.Point(56, 502);
            this.btnOrszagok.Name = "btnOrszagok";
            this.btnOrszagok.Size = new System.Drawing.Size(135, 23);
            this.btnOrszagok.TabIndex = 3;
            this.btnOrszagok.Text = "Résztvevő országok";
            this.btnOrszagok.UseVisualStyleBackColor = true;
            this.btnOrszagok.Click += new System.EventHandler(this.btnOrszagok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Időeredmény:";
            // 
            // bezarBtn
            // 
            this.bezarBtn.Location = new System.Drawing.Point(296, 502);
            this.bezarBtn.Name = "bezarBtn";
            this.bezarBtn.Size = new System.Drawing.Size(135, 23);
            this.bezarBtn.TabIndex = 7;
            this.bezarBtn.Text = "Bezár";
            this.bezarBtn.UseVisualStyleBackColor = true;
            this.bezarBtn.Click += new System.EventHandler(this.bezarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eredmenyRdBtn);
            this.groupBox1.Controls.Add(this.nevRdBtn);
            this.groupBox1.Location = new System.Drawing.Point(248, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont:";
            // 
            // eredmenyRdBtn
            // 
            this.eredmenyRdBtn.AutoSize = true;
            this.eredmenyRdBtn.Location = new System.Drawing.Point(18, 42);
            this.eredmenyRdBtn.Name = "eredmenyRdBtn";
            this.eredmenyRdBtn.Size = new System.Drawing.Size(105, 17);
            this.eredmenyRdBtn.TabIndex = 1;
            this.eredmenyRdBtn.TabStop = true;
            this.eredmenyRdBtn.Text = "Eredmény szerint";
            this.eredmenyRdBtn.UseVisualStyleBackColor = true;
            this.eredmenyRdBtn.CheckedChanged += new System.EventHandler(this.eredmenyRdBtn_CheckedChanged);
            // 
            // nevRdBtn
            // 
            this.nevRdBtn.AutoSize = true;
            this.nevRdBtn.Location = new System.Drawing.Point(18, 19);
            this.nevRdBtn.Name = "nevRdBtn";
            this.nevRdBtn.Size = new System.Drawing.Size(92, 17);
            this.nevRdBtn.TabIndex = 0;
            this.nevRdBtn.TabStop = true;
            this.nevRdBtn.Text = "Névsor szerint";
            this.nevRdBtn.UseVisualStyleBackColor = true;
            this.nevRdBtn.CheckedChanged += new System.EventHandler(this.nevRdBtn_CheckedChanged);
            // 
            // idoEredmenyTxtBox
            // 
            this.idoEredmenyTxtBox.Enabled = false;
            this.idoEredmenyTxtBox.Location = new System.Drawing.Point(322, 238);
            this.idoEredmenyTxtBox.Name = "idoEredmenyTxtBox";
            this.idoEredmenyTxtBox.Size = new System.Drawing.Size(108, 20);
            this.idoEredmenyTxtBox.TabIndex = 9;
            // 
            // orszagTxtBox
            // 
            this.orszagTxtBox.Enabled = false;
            this.orszagTxtBox.Location = new System.Drawing.Point(322, 182);
            this.orszagTxtBox.Name = "orszagTxtBox";
            this.orszagTxtBox.Size = new System.Drawing.Size(108, 20);
            this.orszagTxtBox.TabIndex = 10;
            // 
            // rajtszamTxtBox
            // 
            this.rajtszamTxtBox.Enabled = false;
            this.rajtszamTxtBox.Location = new System.Drawing.Point(322, 127);
            this.rajtszamTxtBox.Name = "rajtszamTxtBox";
            this.rajtszamTxtBox.Size = new System.Drawing.Size(108, 20);
            this.rajtszamTxtBox.TabIndex = 11;
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.rajtszamTxtBox);
            this.Controls.Add(this.orszagTxtBox);
            this.Controls.Add(this.idoEredmenyTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bezarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrszagok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versenyzokLstBox);
            this.Controls.Add(this.lblCim);
            this.Name = "EredmenyForm";
            this.Text = "Eredmények";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.ListBox versenyzokLstBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrszagok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bezarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton eredmenyRdBtn;
        private System.Windows.Forms.RadioButton nevRdBtn;
        private System.Windows.Forms.TextBox idoEredmenyTxtBox;
        private System.Windows.Forms.TextBox orszagTxtBox;
        private System.Windows.Forms.TextBox rajtszamTxtBox;
    }
}