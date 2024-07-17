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

namespace TelefonkonyvWinForms
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "records.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            Person p = new Person();

            try
            {
                string fileName = openFileDialog1.FileName;
                sr = new StreamReader(fileName);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] strings = line.Split(';');

                    txtBoxName.Text = strings[0];   
                    txtBoxAddress.Text = strings[1];
                    txtBoxFName.Text = strings[2];
                    txtBoxMName.Text = strings[3];
                    txtBoxPhone.Text = strings[4];
                    txtBoxSex.Text = strings[5];
                    txtBoxMail.Text = strings[6];
                    txtBoxCitizen.Text = strings[7];

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
}
