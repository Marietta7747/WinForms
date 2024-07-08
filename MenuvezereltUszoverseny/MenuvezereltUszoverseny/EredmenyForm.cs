using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuvezereltUszoverseny
{
    public partial class EredmenyForm : Form
    {
        private List<Versenyzo> versenyzok;

        public EredmenyForm()
        {
            InitializeComponent();
        }

        public void EredmenyHirdetes(string uszasNem, int tav, List<Versenyzo> versenyzok)
        {
            lblCim.Text = tav + " méteres" + uszasNem + " eredménye: ";
            this.versenyzok = versenyzok;
            foreach(Versenyzo versenyzo in versenyzok)
            {
                versenyzokLstBox.Items.Add(versenyzo);
            }
        }

        private void versenyzokLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Versenyzo versenyzo = (Versenyzo)versenyzokLstBox.SelectedItem;
                rajtszamTxtBox.Text = versenyzo.Rajtszam;
                orszagTxtBox.Text = versenyzo.OrszagNev;
                idoEredmenyTxtBox.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
            }
            catch(Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void nevRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            versenyzokLstBox.Sorted = true;
        }

        private void eredmenyRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            versenyzokLstBox.Sorted = false;
            versenyzokLstBox.Items.Clear();
            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count; i++)
            {
                for (int j = 0; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].IdoEredmeny < versenyzok[j].IdoEredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }
            foreach(Versenyzo versenyzo in versenyzok)
            {
                versenyzokLstBox.Items.Add(versenyzo);
            }
        }

        private void btnOrszagok_Click(object sender, EventArgs e)
        {
            ZaszloForm zaszloForm = new ZaszloForm();
            zaszloForm.Fogad(versenyzok);
            zaszloForm.ShowDialog();
        }

        private void bezarBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztos ki akar lépni", "Megerősítés",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
