using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker.UserControls
{
    public partial class UC_FindFiles : UserControl
    {
        public UC_FindFiles()
        {
            InitializeComponent();
        }

        private async Task btnPoisk_Click(object sender, EventArgs e)
        {
            //btnPoisk.Visible = false;
            //gridFindFiles.Rows.Clear();

            //var results = await Task.Run(() => FindCheatFiles());

            //foreach (var row in results)
            //{
            //    gridFindFiles.Rows.Add(row);
            //}
        }
        private List<string[]> FindCheatFiles()
        {
            // Список названий для поиска
            string[] cheatNames = {
        "Nixware", "Aimware", "Interium", "Vredux", "Onetap", "Neverlose",
        "Iniuria", "Midnight", "Pandora", "Monolith", "Gamesense", "Exitium",
        "Tabzware", "Xone", "Pussycat", "Anyx", "Cartel", "CheatKings", "Darkaim",
        "Hexui", "Fatality", "iCheat", "Insanity", "Invision", "Memesense", "Ovix",
        "Oxide", "Phantom Overlay", "Plague Cheat", "Predator Systems", "Primordial",
        "Clutch-Solution", "Skeet", "Kernaim", "Blacksector"
    };

            string[] loaderNames = {
        "ExLoader", "MVPloader", "CS2Browser Launcher", "Xsintashi", "MadLoader",
        "GuidedHacking Injector", "ExChanger", "Tabzware Loader", "Phantom Overlay Loader",
        "Plague Cheat Launcher", "Predator Systems Loader", "W1nnerFree CS2 Launcher",
        "Enigma Tech Launcher", "Darkaim Loader", "Hexui Launcher", "Fatality Loader",
        "iCheat Launcher", "Insanity Loader", "Invision Loader", "Ovix Loader",
        "Oxide Launcher", "Primordial Launcher", "Clutch-Solution Loader", "Skeet Launcher",
        "Kernaim Loader", "Blacksector Loader"
    };

            List<string[]> foundItems = new List<string[]>();

            foreach (var drive in DriveInfo.GetDrives().Where(d => d.IsReady))
            {
                try
                {
                    foreach (var file in Directory.EnumerateFiles(drive.RootDirectory.FullName, "*", SearchOption.AllDirectories))
                    {
                        string fileName = Path.GetFileName(file);

                        string type = "";
                        if (cheatNames.Any(n => fileName.IndexOf(n, StringComparison.OrdinalIgnoreCase) >= 0))
                            type = "Cheat";
                        else if (loaderNames.Any(n => fileName.IndexOf(n, StringComparison.OrdinalIgnoreCase) >= 0))
                            type = "Loader";

                        if (!string.IsNullOrEmpty(type))
                        {
                            var info = new FileInfo(file);
                            foundItems.Add(new string[]
                            {
                                file,                      // Имя
                                type,                      // Тип поиска
                                info.Length.ToString(),    // Размер
                                info.LastWriteTime.ToString() // Дата изменения
                            });
                        }
                    }
                }
                catch { /* Пропускаем ошибки */ }
            }

            return foundItems;
        }


        private void UC_FindFiles_Load(object sender, EventArgs e)
        {

        }

        private void gridFindFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
