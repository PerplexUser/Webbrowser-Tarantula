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
using System.Net;

namespace Tarantula_V0._2
{
    public partial class Tarantula : Form
    {
        string pathFav = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt");
        string pathHist = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\history.txt");
        string Zeile;
        string Laenge;
        string Suche;
        string Suchtext;
        string Reader;


        public Tarantula()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader Filer = new System.IO.StreamReader("startconfig.dat");
            Zeile = Filer.ReadLine();
            Filer.Close();
            webBrowser.Navigate(Zeile);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                webBrowser.Refresh();
            }
        }

        private void Fwdbutton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void StartseiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startpage optionsForm = new Startpage();
            optionsForm.Show();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TARANTULA Version 0.2" + Environment.NewLine + "is Freeware." + Environment.NewLine + Environment.NewLine + "Made by:" + Environment.NewLine + "Michael Lappenbusch" + Environment.NewLine + Environment.NewLine + "Lizenz: Creative Commons" + Environment.NewLine + "CC BY-NC-ND 3.0 DE" + Environment.NewLine + Environment.NewLine + "http://www.perplex.click" + Environment.NewLine);
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtInternetadresse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(txtInternetadresse.Text);
                }


            }
        }
        WebBrowser webTab = null;
        private void TxtInternetadresse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Updates the URL in TextBoxAddress upon navigation.
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                txtInternetadresse.Text = "" + webBrowser.Url;
            }
            if (File.Exists(pathHist))
            {
                StreamReader hist = new StreamReader(pathHist);
                List<string> historyList = hist.ReadToEnd().Split('\n').Select(h => h.Trim()).ToList();
                hist.Close();
                historyList.Remove(historyList.Last());
                int i = historyList.Count;
                if (new FileInfo(pathHist).Length > 0)
                {
                    if (!historyList[i - 1].Equals((webBrowser.Url.ToString())))
                    {
                        using (StreamWriter history = new StreamWriter((pathHist), true))
                        {
                            history.WriteLine(webBrowser.Url.ToString());
                        }
                    }
                }
                else
                {
                    using (StreamWriter history = new StreamWriter(pathHist, true))
                    {
                        history.WriteLine(webBrowser.Url.ToString());
                    }
                }
            }
            else
            {
                File.CreateText(pathHist).Close();
                using (StreamWriter history = new StreamWriter(pathHist, true))
                {
                    history.WriteLine(webBrowser.Url.ToString());
                }
            }
        }

        private void Tarantula_Load(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            Suche = "https://www.google.com/search?q=";
            if (File.Exists(pathFav))
            {
                StreamReader fav = new StreamReader(pathFav);
                List<string> favLista = fav.ReadToEnd().Split('\n').ToList();
                fav.Close();
                favLista.Remove(favLista.Last());
                foreach (string itens in favLista)
                {
                    ToolStripMenuItem favItem = new ToolStripMenuItem();
                    favItem.Text = itens;
                    bookmarksToolStripMenuItem.DropDownItems.Insert(bookmarksToolStripMenuItem.DropDownItems.Count, favItem);
                }
            }
            else
            {
                File.CreateText((pathFav)).Close();
            }

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            txtInternetadresse.Text = "" + webBrowser.Url;
            TabPage tab = new TabPage();
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.DocumentCompleted += WebTab_DocumentCompleted;

        }

        private void Tabbutton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
            txtInternetadresse.Text = ("https://");

        }
        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            Laenge = webTab.DocumentTitle.Substring(0, 6) + "...";

            tabControl.SelectedTab.Text = Laenge;
            txtInternetadresse.Text = "" + webTab.Url;
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void WebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.ForeColor = Color.Red;
            try
            {
                progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            { }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathFav))
            {
                StreamReader favFile = new StreamReader(pathFav);
                string favList = favFile.ReadToEnd();
                favFile.Close();
                using (StreamWriter file = new StreamWriter(pathFav, true))
                {
                    if (!favList.Contains(webBrowser.Url.ToString()))
                    {
                        file.WriteLine(webBrowser.Url.ToString());
                        ToolStripMenuItem favItem = new ToolStripMenuItem();
                        favItem.Text = webBrowser.Url.ToString();
                        bookmarksToolStripMenuItem.DropDownItems.Insert(bookmarksToolStripMenuItem.DropDownItems.Count, favItem);
                    }
                }
            }
            else
            {
                File.CreateText(pathFav).Close();
                StreamReader favFile = new StreamReader(pathFav);
                string favList = favFile.ReadToEnd();
                favFile.Close();
                using (StreamWriter file = new StreamWriter(pathFav, true))
                {
                    if (!favList.Contains(webBrowser.Url.ToString()))
                    {
                        file.WriteLine(webBrowser.Url.ToString());
                        ToolStripMenuItem favItem = new ToolStripMenuItem();
                        favItem.Text = webBrowser.Url.ToString();
                        bookmarksToolStripMenuItem.DropDownItems.Insert(bookmarksToolStripMenuItem.DropDownItems.Count, favItem);
                    }
                }
            }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historyForm = new History();
            historyForm.Show();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void EditBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmarks bookmarksForm = new Bookmarks();
            bookmarksForm.Show();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Suchtext = (searchBox.Text);
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(Suche + Suchtext);
                }


            }
            
            //webBrowser.Navigate(Suche + Suchtext);

        }
    
        

        private void ConfigSearchbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //überflüssig
        }

        private void SuchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SuchBox.Text == "Google")
            {
                Suche = "https://www.google.com/search?q=";
            }
            if (SuchBox.Text == "Bing")
            {
                Suche = "https://www.bing.com/search?q=";
            }
            if (SuchBox.Text == "Youtube")
            {
                Suche = "https://www.youtube.com/results?search_query=";
            }
            if (SuchBox.Text == "Wikipedia")
            {
                Suche = "https://de.wikipedia.org/wiki/Special:Search?search=";
            }
            if (SuchBox.Text == "Heise")
            {
                Suche = "https://www.heise.de/download/search?terms=";
            }
            if (SuchBox.Text == "Amazon")
            {
                Suche = "https://www.amazon.de/s?k=";
            }
            if (SuchBox.Text == "DuckDuckGo")
            {
                Suche = "https://duckduckgo.com/?q=";
            }
            if (SuchBox.Text == "Wikileaks")
            {
                Suche = "https://search.wikileaks.org/?q=";
            }
            if (SuchBox.Text == "Github")
            {
                Suche = "https://github.com/search?q=";
            }
        
        }

        private void BookmarksToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Lesezeichen klickbar machen
        }
    }
}
