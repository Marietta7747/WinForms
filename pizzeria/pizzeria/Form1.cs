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
using System.Diagnostics.Eventing.Reader;

namespace pizzeria
{    
    public partial class PizzaForm : Form
    {
        private bool lathato;

        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        public PizzaForm()
        {
            InitializeComponent();

            //Beállítjuk az induló mappa helyét
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            //Beállítjuk, hogy milyen fájlnevet ajánljon fel indulásként
            openFileDialog1.FileName = "";
            //Beállítjuk a vezérlőelemek láthatóságát
            lathato = false;
            LathatosagBeallitasa(lathato);
        }

        private void AdatBeolvasas(StreamReader sr)
        {
            string adat;
           
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
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBeolvasas(sr);


                    //Ez a metódus tölti fel a vezérlőelemeket
                    ValasztekFeltoltes();

                    //Láthatóság átállítása
                    lathato = true;
                    LathatosagBeallitasa(lathato);
                    btnAdatBe.Visible = false;

                    //Leszedjük a háttérképet
                    this.BackgroundImage = null;
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

        private int bal = 20, fent = 10;
        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 200;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 40;
        private int meretDb = 50;
        private int koz = 3;

        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;

            for (int i = 0; i < pizzak.Count; i++)
            {
                //checkBox felrakása
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY);
                checkBox.Size = new Size(meretChk, meretY);

                //a most beállított jelölőnégyzetet hozzáadjuk
                //a jelölőnégyzetek listájához
                jeloloNegyzetek.Add(checkBox);

                //a most beállított jelölőnégyzetet rárakjuk
                //a központi panelre
                pnlKozponti.Controls.Add(checkBox);

                //panel felrakása
                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);

                //a panelt rárakjuk a központi panelre
                pnlKozponti.Controls.Add(panel);

                //radiobtn kicsi ár felrakása
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0,0);
                rdBtnKicsiArak.Add(radioButton);

                //a rádiógombot rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(radioButton);

                //Fix Ft felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);


                //radiobtn nagy ár felrakása
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArNagy.ToString();
                radioButton.Location = new Point(meretFt + koz, 0);
                rdBtnNagyArak.Add(radioButton);

                panel.Controls.Add(radioButton);

                //Fix Ft felairat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretAr, meretY);
                panel.Controls.Add(label);

                //textBox darabszám
                textBox = new TextBox();
                textBox.Location = new Point(meretFt + koz, 0);
                textBox.Size = new Size(meretDb, meretY);
                panel.Controls.Add(textBox);


                //Fix darab felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = "darab";
                label.Location = new Point(meretDb + koz, 0);
                label.Size = new Size(meretDb, meretY);
                panel.Controls.Add(label);
            }

        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            bool  vanKijeloles = false;
            int db, osszeg = 0, ar = 0;

            for (int i = 0; i < jeloloNegyzetek.Count; i++)
            {
                if (jeloloNegyzetek[i].Checked)
                {
                    vanKijeloles = true;
                    try
                    {
                        //ha az első fajtát választottuk
                        if (rdBtnKicsiArak[i].Checked) ar = pizzak[i].ArKicsi;
                        //ha a második fajtát választottuk
                        else if (rdBtnNagyArak[i].Checked) ar = pizzak[i].ArNagy;
                        //ha egyáltalán nem választottunk
                        else throw new MissingFieldException();

                        //ide csak akkor jut ide, ha valamit kiválasztottunk, ezért
                        //kitudja olvasni a db értékét. ha hibás formátumot adunk meg
                        // (üres vagy nem egész szám), akkor FormatException kivételt dob.
                        db = int.Parse(txtDarabok[i].Text);

                        //azt is vizsgálni kell, hogy nem írtunk-e negatív értéket
                        if (db < 0) throw new Exception();
                        txtDarabok[i].BackColor = Color.White;
                        osszeg += ar * db;
                    }
                    catch (MissingFieldException)
                    {
                        MessageBox.Show("Nem választott méretet", "Hiba");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
                        txtDarabok[i].BackColor = Color.Coral;
                        txtDarabok[i].Clear();
                    }
                }
            }
            if (!vanKijeloles) MessageBox.Show("Nincs kijelölve semmi", "Figyelmeztetés");
            else txtFizetendo.Text = osszeg + " Ft";
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

        public Pizza(string nev, int arKicsi, int arNagy) {
            this.Nev = nev;
            this.ArKicsi = arKicsi;
            this.ArNagy = arNagy;
        }

        public override string ToString()
        {
            return this.Nev;
        }
    }
}
