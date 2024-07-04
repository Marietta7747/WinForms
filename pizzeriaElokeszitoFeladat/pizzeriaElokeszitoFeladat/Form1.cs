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

namespace pizzeriaElokeszitoFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }
        private int meretKicsi = 32, meretNagy = 45;
        private List<Pizza> pizzak = new List<Pizza>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LathatosagBeallitasa(false);
        }

        private void LathatosagBeallitasa(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            try
            {
                AdatBevitel();
                ElemekMegjelenitese();
                LathatosagBeallitasa(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba");
            }
        }

        private void AdatBevitel()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    AdatBeolvasas(fajlNev);
                }
                catch (Exception)
                {
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

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }

        private void ElemekMegjelenitese()
        {
            lblKicsi.Text = meretKicsi + " cm";
            lblNagy.Text = meretNagy + " cm";

            checkBox1.Text = pizzak[0].Nev;
            rdBtn1Kicsi.Text = pizzak[0].ArKicsi + " Ft";
            rdBtn1Nagy.Text = pizzak[0].ArNagy + " Ft";

            checkBox2.Text = pizzak[1].Nev;
            rdBtn2Kicsi.Text = pizzak[1].ArKicsi + " Ft";
            rdBtn2Nagy.Text = pizzak[1].ArNagy + " Ft";
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                int osszeg = 0, ar = 0, db = 0;

                if (checkBox1.Checked)
                {
                    if (rdBtn1Kicsi.Checked) ar = pizzak[0].ArKicsi;
                    else if (rdBtn1Nagy.Checked) ar = pizzak[0].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");
                    db = int.Parse(txtDb1.Text);
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                }

                if (checkBox2.Checked)
                {
                    if (rdBtn2Kicsi.Checked) ar = pizzak[1].ArKicsi;
                    else if (rdBtn2Nagy.Checked) ar = pizzak[1].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");
                    db = int.Parse(txtDb2.Text);
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                }

                if (!checkBox1.Checked && !checkBox2.Checked) throw new MissingFieldException();

                txtFizetendo.Text = osszeg + " Ft";
            }
            catch (FormatException)
            {
                MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
            }
            catch (ArgumentOutOfRangeException aox)
            {
                MessageBox.Show(aox.Message, "Hiba");
            }
            catch (MissingFieldException mex)
            {
                MessageBox.Show(mex.Message,"Hiba");
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //Töröljük a checkbox-ok kijelölését
                if (item is CheckBox) (item as CheckBox).Checked = false;

                //Törüljük a textBox-ok kijelölését
                if (item is TextBox) ((TextBox)item).Clear();

                //a rádiógombok nem közvetlenül a form-on vannak
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton) (gyerek as RadioButton).Checked = false;
                    }
                }
            }
        }

       

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés",
                                                MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }

    class Pizza
    {
        public string Nev { get; private set; }
        public int ArKicsi { get; set; }
        public int ArNagy { get; set; }

        public Pizza(string nev, int arKicsi, int arNagy)
        {
            Nev = nev;
            ArKicsi = arKicsi;
            ArNagy = arNagy;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
