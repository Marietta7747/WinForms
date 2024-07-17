using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TelefonkonyvWinForms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private AddNewForm addNew = new AddNewForm();
        private DisplayForm display = new DisplayForm();
        private ModifyForm modify = new ModifyForm();
        private SearchForm search = new SearchForm();
        private DeleteForm delete = new DeleteForm();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addNew.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modify.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete.Show();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long MbleNumber { get; set; }
        public char Sex { get; set; }
        public string Mail { get; set; }
        public string CitisionNumber { get; set; }

        public Person(string name, string address, string fatherName, string motherName, long mbleNumber, char sex, string mail, string citisionNumber)
        {
            this.Name = name;
            this.Address = address;
            this.FatherName = fatherName;
            this.MotherName = motherName;
            this.MbleNumber = mbleNumber;
            this.Sex = sex;
            this.Mail = mail;
            this.CitisionNumber = citisionNumber;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"{this.Name};{this.Address};{this.FatherName};{this.MotherName};{this.MbleNumber};" +
                $"{this.Sex};{this.Mail};{this.CitisionNumber}";
        }
    }
}
