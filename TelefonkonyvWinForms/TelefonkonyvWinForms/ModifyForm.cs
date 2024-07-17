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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "records.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            Person p = new Person();
            Person s = new Person();
            string name = txtBoxModify.Text;
            int flag = 0;

            try
            {
                string fileName = openFileDialog1.FileName;
                sr = new StreamReader(fileName);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] strings = line.Split(';');

                    if(name == strings[0])
                    {
                        s.Name = strings[0];
                        s.Address = strings[1];
                        s.FatherName = strings[2];
                        s.MotherName = strings[3];
                        s.MbleNumber = int.Parse(strings[4]);
                        s.Sex = char.Parse(strings[5]);
                        s.Mail = strings[6];
                        s.CitisionNumber = strings[7];
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("your data id modified", "Modified");
                }
                else
                {
                    MessageBox.Show("data is not found", "Error");
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
