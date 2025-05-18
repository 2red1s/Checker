using Microsoft.Win32;
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
    public partial class UC_Extra2 : UserControl
    {
        private string? _cs2Path = null;

        public UC_Extra2()
        {
            InitializeComponent();
        }

        private void btnOFcs2_Click(object sender, EventArgs e)
        {
            try
            {
                _cs2Path ??= FindCS2Path(); // Ищем путь, только если null

                if (!string.IsNullOrEmpty(_cs2Path))
                    System.Diagnostics.Process.Start("explorer.exe", _cs2Path);
                else
                    MessageBox.Show("Папка CS2 не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии папки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Основной метод поиска пути
        private string? FindCS2Path()
        {
            string? steamPath = GetSteamPath();
            if (!string.IsNullOrEmpty(steamPath))
            {
                string? cs2Path = SearchLibraryFolders(steamPath);
                if (!string.IsNullOrEmpty(cs2Path))
                    return cs2Path;
            }
            return SearchAllDrives();
        }

        // Получение пути к Steam через реестр
        private string? GetSteamPath()
        {
            using RegistryKey? key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
            return key?.GetValue("SteamPath")?.ToString()?.Replace("/", "\\");
        }

        // Поиск CS2 в библиотеке Steam через libraryfolders.vdf
        private string? SearchLibraryFolders(string steamPath)
        {
            string libFile = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");
            if (!File.Exists(libFile)) return null;

            string[] possibleNames = { "Counter-Strike 2", "Counter-Strike Global Offensive" };
            foreach (string line in File.ReadAllLines(libFile))
            {
                if (line.Contains("\"path\"") && line.Split('"') is { Length: > 3 } split && split[3] is { } path)
                {
                    foreach (string name in possibleNames)
                    {
                        string fullPath = Path.Combine(path.Replace("\\\\", "\\"), "steamapps", "common", name);
                        if (Directory.Exists(fullPath)) return fullPath;
                    }
                }
            }
            return null;
        }

        // Поиск CS2 на дисках (ограниченный)
        private string? SearchAllDrives()
        {
            string[] possibleNames = { "Counter-Strike 2", "Counter-Strike Global Offensive" };
            string[] commonPaths = { "Program Files", "Program Files (x86)" };

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.DriveType == DriveType.Fixed)
                {
                    foreach (string commonPath in commonPaths)
                    {
                        foreach (string name in possibleNames)
                        {
                            try
                            {
                                string path = Path.Combine(drive.RootDirectory.FullName, commonPath, "Steam", "steamapps", "common", name);
                                if (Directory.Exists(path)) return path;
                            }
                            catch (UnauthorizedAccessException) { } // Игнорируем ошибки доступа
                        }
                    }
                }
            }
            return null;
        }
    }
}
