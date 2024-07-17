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
    public partial class AddNewForm : Form
    {
        public AddNewForm()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "records.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            Person p = new Person();

            try
            {
                string fileName = saveFileDialog1.FileName;
                sw = new StreamWriter(fileName);

                p.Name = txtBoxName.Text;
                p.Address = txtBoxAddress.Text;
                p.FatherName = txtBoxFName.Text;
                p.MotherName = txtBoxMName.Text;
                p.MbleNumber = int.Parse(txtBoxPhone.Text);
                p.Sex = char.Parse(txtBoxSex.Text);
                p.Mail = txtBoxMail.Text;
                p.CitisionNumber = txtBoxCitizen.Text;

                sw.WriteLine(p.ToString());

                MessageBox.Show("Record Saved", "Successfully saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
