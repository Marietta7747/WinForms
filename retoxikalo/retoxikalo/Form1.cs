﻿using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 10;

        private ItalLapForm italForm = new ItalLapForm();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception) {
                MessageBox.Show("Hiba a képek létrehozásakor", "hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 0; i <= kepekSzama; i++)
            {
                //kep = Image.FromFile("kep" + i + ".jpg");
                //kepek.Add(kep);
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);

                    ItallapMenuItem.Enabled = true;
                    SaveMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (sr != null) {
                        sr.Close();
                    }
                }
            }
        }

        private void AdatBevitel(StreamReader sr)
        {
            string sor = sr.ReadLine();
            string[] adatok;
            while (sor != null) { 
                adatok = sor.Split(';');

                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = sr.ReadLine();
            }
        }

    }
    class Ital
    {
        public string ItalNev { get; private set; }
        public int EgysegAr { get; set; }

        public Ital(string italNev, int egysegAr)
        {
            ItalNev = italNev;
            EgysegAr = egysegAr;
        }
    }

    class Image
    {

    }
}