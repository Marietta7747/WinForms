﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikalo
{
    public partial class ItalLapForm : Form
    {
        public ItalLapForm()
        {
            InitializeComponent();
        }

        private List<Ital> italok = new List<Ital>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();
        private List<TextBox> txtBoxok = new List<TextBox>();

        private int bal = 10, fent = 10, chkXMeret = 250, chkYTav = 40,
            txtXMeret = 30, txtYmeret = 17, xKoz = 5;

       
        private int maxAdag = 999;

        internal void ArlapotIr(List<Ital> italok)
        {
            pnlValasztek.Controls.Clear();
            chkBoxok.Clear();
            txtBoxok.Clear();

            this.italok = italok;

            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;

            for (int i = 0; i < italok.Count; i++)
            {
                chkBox = new CheckBox();
                txtBox = new TextBox();
                lbl = new Label();

                //chkBox
                chkBox.Location = new Point(bal, fent + i * chkYTav);
                chkBox.Size = new Size(chkXMeret, txtYmeret);
                chkBox.Text = italok[i].Arlistaba();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                //txtBox
                txtBox.Location = new Point(bal + chkXMeret, fent + i * chkYTav - 2);
                txtBox.Size = new Size(txtXMeret, txtYmeret);

                //lbl
                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXMeret + txtXMeret + xKoz,
                                        fent + i * chkYTav + 1);
                lbl.Text = "adag";

                //panelre rakás
                pnlValasztek.Controls.Add(chkBox);
                pnlValasztek.Controls.Add(txtBox);
                pnlValasztek.Controls.Add(lbl);

                //listákba pakolás
                chkBoxok.Add(chkBox);
                txtBoxok.Add(txtBox);
            }
        }

        private void btnRendel_Click(object sender, EventArgs e)
        {
            bool valasztott = false, vanHibasAdag = false;
            int mennyiseg = 0;

            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    valasztott = true;
                    try
                    {
                        mennyiseg = int.Parse(txtBoxok[i].Text);
                        if (mennyiseg <= 0 || mennyiseg > maxAdag) throw new Exception();
                            italok[i].Rendel(mennyiseg);
                            txtBoxok[i].BackColor = Color.White;
                            chkBoxok[i].Checked = false;
                            txtBoxok[i].Clear();
                    }
                    catch (Exception)
                    {
                        txtBoxok[i].BackColor = Color.Salmon;
                        vanHibasAdag = true;
                    }
                }
            }
            if (!valasztott)
            {
                MessageBox.Show("Semmit sem választott!", "figyelmeztetés");
            }
            else if (vanHibasAdag)
            {
                MessageBox.Show("A pirossal jelzett adagok hibásak","figyelmeztetés");
            }
        }

        private void fizetMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Ital item in italok)
            {
                item.Fizet();
            }
        }

        private void szamlatKerMenuItem_Click_1(object sender, EventArgs e)
        {
            SzamlaForm szamlaForm = new SzamlaForm();
            szamlaForm.Kitolt(italok);
            szamlaForm.ShowDialog();
        }

    }
}
