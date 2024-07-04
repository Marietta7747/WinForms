using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diakkezelo
{
    public partial class Form1 : Form
    {
        private List<Diak> diakok = new List<Diak>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
            
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
        }

        private void AdatBevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch ( Exception) {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void AdatBeolvasas(string fajlNev)
        {
            string adat;
            StreamReader sr = new StreamReader(fajlNev);

            while (!sr.EndOfStream)
            {
                adat = sr.ReadLine();
                Feldolgoz(adat);
            }
            sr.Close();
        }

        private void Feldolgoz(string adat){
            //Az adatfájl szerkezete: 
            //Név;Kód;SzülÉv

            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        private void FelrakDiakok()
        {
            CheckBox chkBox;

            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYKoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private int kezdoX = 20, kezdoY = 20, chkYKoz = 40;

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {
                MessageBox.Show("Senkit sem választott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).SzulEv;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzulEv < min) min = diak.SzulEv;
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzulEv == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.SzulEv;
        }
    }

    class Diak
    {
        public string Nev { get; private set; }
        public string TanulKod { get; private set; }

        public int SzulEv { get; private set; }

        public Diak(string nev, string tanulKod, int szulEv)
        {
            this.Nev = nev;
            this.TanulKod = tanulKod;
            this.SzulEv = szulEv;
        }

        public override string ToString()
        {
            return Nev + " (" + TanulKod + ")";
        }
    }
}
