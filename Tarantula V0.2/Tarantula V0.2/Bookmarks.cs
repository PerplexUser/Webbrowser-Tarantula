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
    public partial class Bookmarks : Form
    {
        string pathFav = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt");
        public Bookmarks()
        {
            InitializeComponent();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ALL BOOKMARKS? :O", "Bookmarks deleted", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt")));
            }
            else
            { }
            listBox1.DataSource = null;
        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {

            if (File.Exists(pathFav))
            {
                StreamReader bookmarks = new StreamReader((pathFav));
                List<string> bookmarksList = bookmarks.ReadToEnd().Split('\n').ToList();
                bookmarksList.Remove(bookmarksList.Last());
                listBox1.DataSource = bookmarksList;
            }
            else
            {
                File.CreateText((pathFav)).Close();
                StreamReader bookmarks = new StreamReader((pathFav));
                List<string> bookmarksList = bookmarks.ReadToEnd().Split('\n').ToList();
                bookmarks.Close();
                listBox1.DataSource = bookmarksList;
            }
        }
    }
}
