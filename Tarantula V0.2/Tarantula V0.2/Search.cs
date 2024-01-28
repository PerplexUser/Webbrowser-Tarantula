using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tarantula_V0._2
{
    public partial class Search : Form
    {
        string Reader;
        string Google = "https://www.google.com/search?q=";
        string Bing = "https://www.bing.com/search?q=";
        string Youtube = "https://www.youtube.com/results?search_query=";
        string Wikipedia = "https://de.wikipedia.org/wiki/Special:Search?search=";
        string Heise = "https://www.heise.de/download/search?terms=";
        string Amazon = "https://www.amazon.de/s?k=";

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            string fileName = @"search.dat";
            if (File.Exists(fileName))
            {
                System.IO.StreamReader Filer = new System.IO.StreamReader("search.dat");
                Reader = Filer.ReadLine();
                Filer.Close();

            }
            else
            {
                using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("startconfig.dat"))
                {
                    Filew.WriteLine(Google);
                    Close();
                }
            }
            if (Reader == Google)
            {
                radioButton1.Checked = true;
            }
            if (Reader == Bing)
            {
                radioButton2.Checked = true;
            }
            if (Reader == Youtube)
            {
                radioButton3.Checked = true;
            }
            if (Reader == Wikipedia)
            {
                radioButton4.Checked = true;
            }
            else
            {
                using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("startconfig.dat"))
                {
                    Filew.WriteLine(Google);
                    Close();
                }
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("search.dat"))
            {
                Filew.WriteLine(Google);
                Close();
            }
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("search.dat"))
            {
                Filew.WriteLine(Bing);
                Close();
            }

        }
        private void RadioButton3_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("search.dat"))
            {
                Filew.WriteLine(Google);
                Close();
            }
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("search.dat"))
            {
                Filew.WriteLine(Wikipedia);
                Close();
            }
        }
    }
}
        
