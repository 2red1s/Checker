using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Checker.UserControls
{
    public partial class UC_Web2 : UserControl
    {
        List<string> browserPaths = new List<string>();
        List<string> browsers = new List<string>

        {
        @"C:\Program Files\Google\Chrome\Application\chrome.exe",
        @"C:\Program Files\Mozilla Firefox\firefox.exe",
        @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe",
        @"C:\Program Files\Microsoft\Edge\Application\msedge.exe"
        };
        public UC_Web2()
        {
            InitializeComponent();

        }

        private void UC_Web2_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            SetDefaultBrowserLabel();
            LoadDefaultBrowser();
        }


        private void SetupDataGrid()
        {
            gridBrowsers.Columns.Clear();

            gridBrowsers.Rows.Clear();
            gridBrowsers.Size = new Size(200, 120);

            gridBrowsers.Columns.Add("Browser", "Браузер");

        }

        private void LoadDefaultBrowser()
        {
            try
            {
                string regPath = @"HTTP\shell\open\command";
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(regPath))
                {
                    if (key != null)
                    {
                        string command = key.GetValue(null)?.ToString();
                        if (!string.IsNullOrEmpty(command))
                        {
                            string exePath = command.Trim('"');

                            if (exePath.Contains(".exe"))
                                exePath = exePath.Substring(0, exePath.IndexOf(".exe") + 4);

                            string browserName = Path.GetFileNameWithoutExtension(exePath);
                            lbldefBrowser.Text = browserName;

                            SetDefaultBrowserIcon(browserName);
                        }
                    }
                }
            }
            catch
            {
                lbldefBrowser.Text = "Не удалось определить";
            }
        }

        private void SetDefaultBrowserIcon(string browserName)
        {
            browserName = browserName.ToLower();
            string baseDir = @"Checker\Checker\Checker\Icons";

            string iconPath = browserName switch
            {
                "chrome" => Path.Combine(baseDir, "chrome.png"),
                "firefox" => Path.Combine(baseDir, "firefox.png"),
                "opera" => Path.Combine(baseDir, "opera.png"),
                "msedge" => Path.Combine(baseDir, "edge.png"),
                "brave" => Path.Combine(baseDir, "brave.png"),
                _ => null
            };

            if (iconPath != null && File.Exists(iconPath))
            {
                picdefBrowser.Image = Image.FromFile(iconPath);
            }
            else
            {
                picdefBrowser.Image = null;
            }
        }

        private void btnBrowsers_Click(object sender, EventArgs e)
        {
            gridBrowsers.Rows.Clear();
            browserPaths.Clear();

            string[] roots = { @"SOFTWARE\Clients\StartMenuInternet", @"SOFTWARE\WOW6432Node\Clients\StartMenuInternet" };
            RegistryKey[] hives = { Registry.LocalMachine, Registry.CurrentUser };

            foreach (var hive in hives)
            {
                foreach (var root in roots)
                {
                    using (RegistryKey key = hive.OpenSubKey(root))
                    {
                        if (key == null) continue;

                        foreach (string subKeyName in key.GetSubKeyNames())
                        {
                            using (RegistryKey browserKey = key.OpenSubKey(subKeyName))
                            {
                                string name = browserKey.GetValue(null)?.ToString();
                                using (RegistryKey pathKey = browserKey.OpenSubKey(@"shell\open\command"))
                                {
                                    string exePath = pathKey?.GetValue(null)?.ToString();
                                    if (!string.IsNullOrEmpty(exePath))
                                    {
                                        exePath = exePath.Trim('"');
                                        if (exePath.Contains(".exe"))
                                            exePath = exePath.Substring(0, exePath.IndexOf(".exe") + 4);

                                        if (!browserPaths.Contains(exePath)) // избегаем дубликатов
                                        {
                                            gridBrowsers.Rows.Add(name);
                                            browserPaths.Add(exePath);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (gridBrowsers.Rows.Count == 0)
                MessageBox.Show("Браузеры не найдены.");
        }



        private void gridBrowsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridBrowsers.Columns[e.ColumnIndex].Name == "Open")
            {
                string browserName = gridBrowsers.Rows[e.RowIndex].Cells["Browser"].Value.ToString();

                string path = browsers.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p).Equals(browserName, StringComparison.OrdinalIgnoreCase));

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    string folderPath = Path.GetDirectoryName(path);
                    Process.Start("explorer.exe", folderPath);
                }
                else
                {
                    MessageBox.Show("Путь не найден.");
                }
            }
        }

        private void SetDefaultBrowserLabel()
        {
            string defaultBrowser = "";

            try
            {
                using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
                {
                    if (userChoiceKey != null)
                    {
                        object progId = userChoiceKey.GetValue("ProgId");
                        if (progId != null)
                        {
                            string progIdStr = progId.ToString().ToLower();

                            if (progIdStr.Contains("chrome"))
                                defaultBrowser = "Google Chrome";
                            else if (progIdStr.Contains("firefox"))
                                defaultBrowser = "Mozilla Firefox";
                            else if (progIdStr.Contains("edge"))
                                defaultBrowser = "Microsoft Edge";
                            else if (progIdStr.Contains("brave"))
                                defaultBrowser = "Brave";
                            else if (progIdStr.Contains("opera"))
                                defaultBrowser = "Opera GX";
                            else
                                defaultBrowser = progIdStr; // неизвестный, покажем как есть
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                defaultBrowser = "Ошибка: " + ex.Message;
            }

            lbldefBrowser.Text = "По умолчанию: " + defaultBrowser;
        }

        private void lbldefBrowser_Click(object sender, EventArgs e)
        {

        }
    }
}
