namespace Tarantula_V0._2
{
    partial class Tarantula
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarantula));
            this.startseiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInternetadresse = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fwdbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CloseTab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabbutton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SuchBox = new System.Windows.Forms.ListBox();
            optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionenToolStripMenuItem
            // 
            optionenToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startseiteToolStripMenuItem,
            this.editBookmarksToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.beendenToolStripMenuItem});
            optionenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Firebrick;
            optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            optionenToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            optionenToolStripMenuItem.Text = "Options";
            // 
            // startseiteToolStripMenuItem
            // 
            this.startseiteToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.startseiteToolStripMenuItem.Name = "startseiteToolStripMenuItem";
            this.startseiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startseiteToolStripMenuItem.Text = "Set Startpage";
            this.startseiteToolStripMenuItem.Click += new System.EventHandler(this.StartseiteToolStripMenuItem_Click);
            // 
            // editBookmarksToolStripMenuItem
            // 
            this.editBookmarksToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.editBookmarksToolStripMenuItem.Name = "editBookmarksToolStripMenuItem";
            this.editBookmarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editBookmarksToolStripMenuItem.Text = "Edit Bookmarks";
            this.editBookmarksToolStripMenuItem.Click += new System.EventHandler(this.EditBookmarksToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Exit";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Location = new System.Drawing.Point(-1, 91);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1040, 367);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage.Controls.Add(this.webBrowser);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage.Size = new System.Drawing.Size(1032, 341);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "TabPage";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(2, 2);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1028, 337);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1_Navigated);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebBrowser_ProgressChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Firebrick;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            optionenToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(1038, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            this.bookmarksToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BookmarksToolStripMenuItem_DropDownItemClicked);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // txtInternetadresse
            // 
            this.txtInternetadresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInternetadresse.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternetadresse.FormattingEnabled = true;
            this.txtInternetadresse.Location = new System.Drawing.Point(282, 40);
            this.txtInternetadresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInternetadresse.Name = "txtInternetadresse";
            this.txtInternetadresse.Size = new System.Drawing.Size(564, 20);
            this.txtInternetadresse.TabIndex = 9;
            this.txtInternetadresse.Text = "http://";
            this.txtInternetadresse.SelectedIndexChanged += new System.EventHandler(this.TxtInternetadresse_SelectedIndexChanged);
            this.txtInternetadresse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInternetadresse_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(232, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "🏡";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(197, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "💫";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // fwdbutton
            // 
            this.fwdbutton.BackColor = System.Drawing.Color.Firebrick;
            this.fwdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwdbutton.Location = new System.Drawing.Point(117, 31);
            this.fwdbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fwdbutton.Name = "fwdbutton";
            this.fwdbutton.Size = new System.Drawing.Size(30, 37);
            this.fwdbutton.TabIndex = 12;
            this.fwdbutton.Text = "▷";
            this.fwdbutton.UseVisualStyleBackColor = false;
            this.fwdbutton.Click += new System.EventHandler(this.Fwdbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Firebrick;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(82, 30);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(30, 37);
            this.backbutton.TabIndex = 13;
            this.backbutton.Text = "◁";
            this.backbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(884, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "TARANTULA Version 0.2";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(4, 464);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 9);
            this.progressBar1.TabIndex = 15;
            // 
            // CloseTab
            // 
            this.CloseTab.BackColor = System.Drawing.Color.Firebrick;
            this.CloseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseTab.Location = new System.Drawing.Point(37, 31);
            this.CloseTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseTab.Name = "CloseTab";
            this.CloseTab.Size = new System.Drawing.Size(30, 37);
            this.CloseTab.TabIndex = 1;
            this.CloseTab.Text = "X";
            this.CloseTab.UseVisualStyleBackColor = false;
            this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImage = global::Tarantula_V0._2.Properties.Resources.bookmark1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(164, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 37);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabbutton
            // 
            this.tabbutton.BackColor = System.Drawing.Color.Firebrick;
            this.tabbutton.BackgroundImage = global::Tarantula_V0._2.Properties.Resources.tab;
            this.tabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabbutton.Location = new System.Drawing.Point(2, 31);
            this.tabbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabbutton.Name = "tabbutton";
            this.tabbutton.Size = new System.Drawing.Size(30, 37);
            this.tabbutton.TabIndex = 16;
            this.tabbutton.UseVisualStyleBackColor = false;
            this.tabbutton.Click += new System.EventHandler(this.Tabbutton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(722, 3);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(124, 20);
            this.searchBox.TabIndex = 18;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Firebrick;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Black;
            this.SearchLabel.Location = new System.Drawing.Point(635, 3);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(90, 15);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Search the web:";
            // 
            // SuchBox
            // 
            this.SuchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuchBox.FormattingEnabled = true;
            this.SuchBox.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Heise",
            "Wikipedia",
            "Amazon",
            "Youtube",
            "DuckDuckGo",
            "Wikileaks",
            "Github"});
            this.SuchBox.Location = new System.Drawing.Point(850, 3);
            this.SuchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SuchBox.Name = "SuchBox";
            this.SuchBox.Size = new System.Drawing.Size(91, 17);
            this.SuchBox.TabIndex = 20;
            this.SuchBox.SelectedIndexChanged += new System.EventHandler(this.SuchBox_SelectedIndexChanged);
            // 
            // Tarantula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1038, 480);
            this.Controls.Add(this.SuchBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseTab);
            this.Controls.Add(this.tabbutton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.fwdbutton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtInternetadresse);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tarantula";
            this.Text = "...::::: Tarantula - The spider knows the web ::::::::::.......";
            this.Load += new System.EventHandler(this.Tarantula_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem startseiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ComboBox txtInternetadresse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button fwdbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button tabbutton;
        private System.Windows.Forms.Button CloseTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookmarksToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ListBox SuchBox;
    }
}

