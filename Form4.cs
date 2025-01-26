using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//new
using Newtonsoft.Json.Linq;//new

namespace Agenda2
{
    public partial class Form4 : Form
    {
        public Form1 Formul1;
        public Form4(Form1 F1)
        {
            InitializeComponent();
            this.Formul1 = F1;
            LoadBookmarks();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void LoadBookmarks()
        {
            try
            {
                // Calea către folderul de profil Chrome al utilizatorului
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string chromeBookmarksPath = Path.Combine(userProfile, "AppData", "Local", "Google", "Chrome", "User Data", "Default", "Bookmarks");

                if (!File.Exists(chromeBookmarksPath))
                {
                    MessageBox.Show("Fișierul de marcaje Google Chrome nu a fost găsit.");
                    return;
                }

                // Citește fișierul JSON al marcajelor
                string bookmarksJson = File.ReadAllText(chromeBookmarksPath);

                // Parsează JSON-ul
                JObject bookmarksData = JObject.Parse(bookmarksJson);

                var roots = bookmarksData["roots"];

                // Procesează toate secțiunile principale: bookmark_bar, other și mobile
                ProcessFolder(roots["bookmark_bar"], "Bookmark Bar");
                ProcessFolder(roots["other"], "Other Bookmarks");
                ProcessFolder(roots["synced"], "Mobile Bookmarks");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }

        private void ProcessFolder(JToken folder, string folderName)
        {
            if (folder == null) return;

            // Adaugă titlul folderului în ListBox
            listBoxBookmarks.Items.Add($"--- {folderName} ---");

            // Procesează conținutul folderului
            var children = folder["children"];
            if (children != null)
            {
                foreach (var child in children)
                {
                    string type = child["type"]?.ToString();

                    if (type == "folder")
                    {
                        // Dacă este un folder, procesează-l recursiv
                        string subFolderName = child["name"]?.ToString() ?? "Folder fără nume";
                        ProcessFolder(child, subFolderName);
                    }
                    else if (type == "url")
                    {
                        // Dacă este un marcaj, adaugă-l la ListBox
                        string name = child["name"]?.ToString();
                        string url = child["url"]?.ToString();
                        if (this.Formul1.verify_exista_deja_siteul_siteului_for_import(url.Trim().ToString()))
                        {
                            //MessageBox.Show(url.ToString());
                            //return;
                            listBoxBookmarks.Items.Add($"{url}");//name
                        }
                    }
                }
            }
        }
    }
}

