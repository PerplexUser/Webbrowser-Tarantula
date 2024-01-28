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
    public partial class Startpage : Form
    {
        public Startpage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter Filew = new System.IO.StreamWriter("startconfig.dat"))
            {
                Filew.WriteLine(textBox1.Text);
                Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Startpage_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
