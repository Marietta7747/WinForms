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
    public partial class VersenyForm : Form
    {
        public List<Versenyzo> Versenyzok {  get; private set; }
        public string UszasNem { get; private set; }
        public int Tav {  get; private set; }
        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        private int sorSzam;

        public VersenyForm()
        {
            InitializeComponent();
            idoEredmenyDateTimePicker.Value = alap;
            uszasNemCmbBox.SelectedIndex = 0;
        }

        internal void Fogad(List<Versenyzo> versenyzok)
        {
            Versenyzok = versenyzok;
        }

        private void btnVerseny_Click(object sender, EventArgs e)
        {
            
            btnKovetkezo.Enabled = true;
            btnVerseny.Enabled = false;
            tavNmrcUpDown.Enabled = false;
            uszasNemCmbBox.Enabled = false;

            VersenyzoBeallitas();
        }

        private void VersenyzoBeallitas()
        {
            idoEredmenyDateTimePicker.Value = alap;
            if (sorSzam < Versenyzok.Count)
            {
                txtVersenyzo.Text = Versenyzok[sorSzam].ToString();
            }
            else
            {
                this.Close();
            }
        }
        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = idoEredmenyDateTimePicker.Value - alap;
            Versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();
        }

        
    }
}
