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
using System.Drawing.Imaging;
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
            //LoadDefaultBrowser();
        }


        private void SetupDataGrid()
        {

            gridBrowsers.Columns.Clear();
            gridBrowsers.Rows.Clear();

            gridBrowsers.Size = new Size(200, 120);

            gridBrowsers.AllowUserToAddRows = false;                             // запрет на добавление новых строк.
            gridBrowsers.RowHeadersVisible = false;                              // скрывает заголовки строк.
            gridBrowsers.AllowUserToResizeRows = false;                         // запрещает изменять высоту строк.
            gridBrowsers.ReadOnly = true;                                       // только чтение 

            // gridBrowsers.BorderStyle = BorderStyle.None;                        // Убирает внешнюю границу таблицы.
            gridBrowsers.CellBorderStyle = DataGridViewCellBorderStyle.None;    // Убирает границы между ячейками таблицы.
            gridBrowsers.GridColor = Color.Black;                               // Устанавливает цвет линий сетки 

            gridBrowsers.Columns.Add("Browser", "Браузер");                     // Добавляет столбец 
            gridBrowsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // авто размер 

            // Цвета таблицы
            gridBrowsers.BackgroundColor = Color.FromArgb(105, 105, 105);          // цвет фона таблицы .
            gridBrowsers.DefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105); //  цвет фона ячеек таблицы (чуть светлее серый).
            gridBrowsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 92, 252);     //  цвет фона выделенных ячеек (синий).
            gridBrowsers.DefaultCellStyle.SelectionForeColor = Color.White;             // цвет текста выделенных ячеек (белый).
            gridBrowsers.DefaultCellStyle.ForeColor = Color.White;                          // цвет текста не выделенной ячейки

            // Цвета заголовков
            gridBrowsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 100, 99); // цвет фона заголовков столбцов (красный).
            gridBrowsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // цвет текста заголовков столбцов (белый).
            gridBrowsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;         // Выравнивает текст заголовков столбцов по левому краю с центром по вертикали.
            gridBrowsers.EnableHeadersVisualStyles = false;                      // Отключает стандартные стили Windows для заголовков столбцов


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

        private void SetDefaultBrowserIcon(string browserKey)
        {
            browserKey = browserKey.ToLower();

            byte[] imageBytes = browserKey switch
            {
                "chrome" => Properties.Resources.chrome,
                "firefox" => Properties.Resources.firefox,
                "opera" => Properties.Resources.opera,
                "edge" => Properties.Resources.edge,
                "brave" => Properties.Resources.brave,
                _ => null
            };

            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    picdefBrowser.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
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

                            string browserName = "Неизвестно";
                            string iconName = "";

                            if (progIdStr.Contains("chrome"))
                            {
                                browserName = "Google Chrome";
                                iconName = "chrome";
                            }
                            else if (progIdStr.Contains("firefox"))
                            {
                                browserName = "Mozilla Firefox";
                                iconName = "firefox";
                            }
                            else if (progIdStr.Contains("edge"))
                            {
                                browserName = "Microsoft Edge";
                                iconName = "edge";
                            }
                            else if (progIdStr.Contains("brave"))
                            {
                                browserName = "Brave";
                                iconName = "brave";
                            }
                            else if (progIdStr.Contains("opera"))
                            {
                                browserName = "Opera GX";
                                iconName = "opera";
                            }
                            else
                            {
                                browserName = progIdStr;
                            }

                            lbldefBrowser.Text = browserName;
                            SetDefaultBrowserIcon(iconName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbldefBrowser.Text = "Ошибка: " + ex.Message;
            }
        }


        private void lbldefBrowser_Click(object sender, EventArgs e)
        {

        }

        private void gridBrowsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlLine_Paint(object sender, PaintEventArgs e)
        {
            pnlLine.BackColor = Color.Red;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //glow = new GlowEffect_Line(pnlLine);
            //glow.Start();
        }

        private void pnlliner_Paint(object sender, PaintEventArgs e)
        {
            pnlliner.BackColor = Color.Red;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //glow = new GlowEffect_Line(pnlliner);
            //glow.Start();
        }

        private void picdefBrowser_Click(object sender, EventArgs e)
        {

        }
    }
}
