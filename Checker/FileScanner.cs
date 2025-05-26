using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


public class FileScanner
{
    private readonly List<string> keywords;
    private readonly DataGridView dataGrid;

    public FileScanner(List<string> keywords, DataGridView dataGrid)
    {
        this.keywords = keywords;
        this.dataGrid = dataGrid;
    }

    public void StartScan()
    {
        List<string> foundFiles = new List<string>();

        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                ScanDirectory(drive.RootDirectory.FullName, foundFiles);
            }
        }

        foreach (string file in foundFiles.Distinct())
        {
            dataGrid.Rows.Add(file);
        }
    }

    private void ScanDirectory(string dir, List<string> foundFiles)
    {
        try
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                string fileName = Path.GetFileName(file);
                if (keywords.Any(k => fileName.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    foundFiles.Add(file);
                }
            }

            foreach (string subDir in Directory.GetDirectories(dir))
            {
                ScanDirectory(subDir, foundFiles);
            }
        }
        catch { /* игнорируем все ошибки */ }
    }
}