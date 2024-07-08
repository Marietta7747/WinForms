namespace MenuvezereltUszoverseny
{
    partial class VersenyForm
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
            this.tavNmrcUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerseny = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersenyzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.idoEredmenyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uszasNemCmbBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tavNmrcUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Táv:";
            // 
            // tavNmrcUpDown
            // 
            this.tavNmrcUpDown.Location = new System.Drawing.Point(99, 21);
            this.tavNmrcUpDown.Name = "tavNmrcUpDown";
            this.tavNmrcUpDown.Size = new System.Drawing.Size(62, 20);
            this.tavNmrcUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // btnVerseny
            // 
            this.btnVerseny.Location = new System.Drawing.Point(459, 21);
            this.btnVerseny.Name = "btnVerseny";
            this.btnVerseny.Size = new System.Drawing.Size(75, 23);
            this.btnVerseny.TabIndex = 3;
            this.btnVerseny.Text = "Verseny";
            this.btnVerseny.UseVisualStyleBackColor = true;
            this.btnVerseny.Click += new System.EventHandler(this.btnVerseny_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Versenyző:";
            // 
            // txtVersenyzo
            // 
            this.txtVersenyzo.Enabled = false;
            this.txtVersenyzo.Location = new System.Drawing.Point(128, 146);
            this.txtVersenyzo.Name = "txtVersenyzo";
            this.txtVersenyzo.Size = new System.Drawing.Size(305, 20);
            this.txtVersenyzo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Időeredmény:";
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.Enabled = false;
            this.btnKovetkezo.Location = new System.Drawing.Point(459, 207);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btnKovetkezo.TabIndex = 8;
            this.btnKovetkezo.Text = "Következő";
            this.btnKovetkezo.UseVisualStyleBackColor = true;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnKovetkezo_Click);
            // 
            // idoEredmenyDateTimePicker
            // 
            this.idoEredmenyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.idoEredmenyDateTimePicker.Location = new System.Drawing.Point(128, 209);
            this.idoEredmenyDateTimePicker.MaxDate = new System.DateTime(2024, 7, 8, 2, 59, 59, 0);
            this.idoEredmenyDateTimePicker.Name = "idoEredmenyDateTimePicker";
            this.idoEredmenyDateTimePicker.ShowUpDown = true;
            this.idoEredmenyDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.idoEredmenyDateTimePicker.TabIndex = 9;
            this.idoEredmenyDateTimePicker.Value = new System.DateTime(2024, 7, 8, 0, 0, 0, 0);
            // 
            // uszasNemCmbBox
            // 
            this.uszasNemCmbBox.FormattingEnabled = true;
            this.uszasNemCmbBox.Items.AddRange(new object[] {
            "mellúszás",
            "gyorsúszás",
            "pillangó úszás",
            "hátúszás",
            "vegyes"});
            this.uszasNemCmbBox.Location = new System.Drawing.Point(220, 23);
            this.uszasNemCmbBox.Name = "uszasNemCmbBox";
            this.uszasNemCmbBox.Size = new System.Drawing.Size(174, 21);
            this.uszasNemCmbBox.TabIndex = 10;
            // 
            // VersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.uszasNemCmbBox);
            this.Controls.Add(this.idoEredmenyDateTimePicker);
            this.Controls.Add(this.btnKovetkezo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVersenyzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerseny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tavNmrcUpDown);
            this.Controls.Add(this.label1);
            this.Name = "VersenyForm";
            this.Text = "Verseny";
            ((System.ComponentModel.ISupportInitialize)(this.tavNmrcUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tavNmrcUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerseny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersenyzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKovetkezo;
        private System.Windows.Forms.DateTimePicker idoEredmenyDateTimePicker;
        private System.Windows.Forms.ComboBox uszasNemCmbBox;
    }
}