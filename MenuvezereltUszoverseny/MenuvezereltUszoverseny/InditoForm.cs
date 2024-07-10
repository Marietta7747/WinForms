using System;
using System.IO;
using System.Collections.Concurrent;
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
    public partial class InditoForm : Form
    {
        public InditoForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "versenyzok.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "";
        }
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);

                    versenyMenuItem.Enabled = true;
                    openMenuItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }

        public void AdatBevitel(StreamReader sr)
        {
            string sor;
            string[] tordelt;
            string nev, orszag, zaszlo;

            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                if (sor != "")
                {
                    tordelt = sor.Split(';');
                    nev = tordelt[0];
                    orszag = tordelt[1];
                    zaszlo = tordelt[2];
                    versenyzok.Add(new Versenyzo(nev, orszag, zaszlo));
                }
            }
        }
               
        private void versenyMenuItem_Click(object sender, EventArgs e)
        {
            versenyForm.Fogad(versenyzok);

            this.Hide();
            versenyForm.ShowDialog();
            this.Show();

            eredmenyMenuItem.Enabled = true;
            versenyMenuItem.Enabled = false;
            saveMenuItem.Enabled = true;
            int tav = versenyForm.Tav;
            string uszasNem = versenyForm.UszasNem;
            eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }

        private void eredmenyMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    sw = new StreamWriter(fajlNev);
                    FajlbaIr(sw);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "hiba");
                }
                finally
                {
                    if(sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }

        private void FajlbaIr(StreamWriter sw)
        {
            foreach (var versenyzo in versenyzok)
            {
                sw.WriteLine(versenyzo.Rajtszam + ";" + versenyzo.Nev + ";" +
                    versenyzo.OrszagNev + ";" + versenyzo.IdoEredmeny);
            }
        }

        private void nevjegyMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "Bitbajnok";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev {  get; private set; }
        public string OrszagNev { get; private set; }
        public string ZaszloNev { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        private static int sorSzam;
        public Versenyzo(string nev, string orszagNev, string zaszloNev)
        {
            this.Nev = nev;
            this.OrszagNev = orszagNev;
            this.ZaszloNev = zaszloNev;
            sorSzam++;
            this.Rajtszam  = (sorSzam < 10)?("0" + sorSzam):sorSzam.ToString();
        }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }
        

        public override string ToString()
        {
            return Nev;
        }
    }
}
