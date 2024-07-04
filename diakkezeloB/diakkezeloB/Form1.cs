using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diakkezeloB
{
    public partial class Form1 : Form
    {
        private List<int> evek = new List<int>();
        private List<Button> btnEvek = new List<Button>();  
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
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
                    FelrakEvek();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak;
            diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.SzulEv)) evek.Add(diak.SzulEv);
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
        private int kezdoX = 10, btnXKoz = 80, kezdoY = 15;
        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();

                btn.Click += new System.EventHandler(Kivalaszt);
                
                //Rárakjuk a panelre a gombot
                pnlEvek.Controls.Add(btn);

                //Hozzáadjuk a gombok listájához
                btnEvek.Add(btn);
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
            btnAdatbevitel.Enabled = false;
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            //Az év értéke az aktuálisan megnyomott gomb felirata
            int ev = int.Parse((sender as Button).Text);

            lstEredmeny.Items.Clear();
            foreach(Diak diak in lstDiakok.Items)
            {
                if (diak.SzulEv == ev) lstEredmeny.Items.Add(diak);
            }
        }

        private void lstEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstEredmeny.SelectedItem;
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
