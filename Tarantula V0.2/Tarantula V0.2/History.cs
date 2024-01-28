using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarantula_V0._2
{
    public partial class History : Form
    {

        string pathHist = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\history.txt");
        public History()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the History?", "Clean History", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\history.txt")));
            }
            else
            { }
            listBox1.DataSource = null;
        }

        private void History_Load(object sender, EventArgs e)
        {

            if (File.Exists(pathHist))
            {
                StreamReader history = new StreamReader((pathHist));
                List<string> historyList = history.ReadToEnd().Split('\n').ToList();
                historyList.Remove(historyList.Last());
                listBox1.DataSource = historyList;
            }
            else
            {
                File.CreateText((pathHist)).Close();
                StreamReader history = new StreamReader((pathHist));
                List<string> historyList = history.ReadToEnd().Split('\n').ToList();
                history.Close();
                listBox1.DataSource = historyList;
            }
        }
    }
}
