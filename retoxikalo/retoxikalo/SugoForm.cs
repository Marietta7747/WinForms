using System;
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
    public partial class SugoForm : Form
    {
        public SugoForm()
        {
            InitializeComponent();
            rchTxtBoxSugo.Text = "A fájl menüpontban lehet megnyitni az itallistát " +
                "tartalmazó adatfájlt, és itt lehet majd elmenteni a számlák adatait tartalmazó fájlt." +
                "\n\nAz itallap az adatfájl betöltése után is megjelenik, de bármikor máskor is előhozható az Itallap " +
                "menüpont hatására. \n\nA galéria menüpont hatására megnézhet néhány képet a falu" +
                " nevezetességéről és a környékéről.";
        }
    }
}
