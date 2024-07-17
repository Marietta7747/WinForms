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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "records.txt";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            Person p = new Person();
            string deleteName;
            int flag = 0;

            try
            {
                StreamWriter sw = new StreamWriter("temp.txt");
                if (sw ==  null)
                {
                    MessageBox.Show("file opening error", "Error");
                }

                deleteName = txtBoxDelete.Text;
                string fileName = openFileDialog1.FileName;
                sr = new StreamReader(fileName);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] strings = line.Split(';');

                    if (deleteName != strings[0])
                    {
                        sw.WriteLine(deleteName);
                    }
                    if(deleteName == strings[1])
                    {
                        flag = 1;
                    }
                }
                sw.Close();

                if (flag != 1)
                {
                    MessageBox.Show("NO CONTACT'S RECORD TO DELETE","Error");
                    File.Delete("temp.txt");
                }
                else
                {
                    File.Delete("records.txt");
                    File.Move("temp.txt", "records.txt");
                    MessageBox.Show("RECORD DELETED SUCCESSFULLY", "Successfully deleted");
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
