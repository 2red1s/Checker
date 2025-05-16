using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker.Forms
{
    public partial class FormPrograms : Form
    {
        // кэ пути
        private string? _cs2Path = null;

        public FormPrograms()
        {
            InitializeComponent();
        }

        private void FormPrograms_Load(object sender, EventArgs e)
        {

        }

        private void btnRoaming_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        }

        private void btnProgData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.GetTempPath());
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void btnProgFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        private void btnCDumps_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CrashDumps"));
        }

        private void btnopenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            System.Diagnostics.Process.Start("explorer.exe", Path.GetTempPath());
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            System.Diagnostics.Process.Start("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CrashDumps"));
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads");
        }

        private void btnDownloads_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads");
        }

        private void btnopenFolderCS_Click(object sender, EventArgs e)
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
