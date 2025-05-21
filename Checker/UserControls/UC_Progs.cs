using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Checker.UserControls
{
    public partial class UC_Progs : UserControl
    {
        public UC_Progs()
        {
            InitializeComponent();
        }

        private void btnLastActiv_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "ExecutedProgramsList.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("ExecuteProgramsList сломан!", "Ошибка");
            }
        }

        private void btnLastDoc_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "JumpListsView.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("JumpListsView сломан!", "Ошибка");
            }
        }

        private void btnUAView_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "UserAssistView.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("UserAssistView сломан!", "Ошибка");
            }
        }

        private void btnHistUsb_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "DevManView.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("DevManView сломан!", "Ошибка");
            }
        }

        private void btnFoldActiv_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "shellbag.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("Shellbag сломан!", "Ошибка");
            }
        }

        private void btnHistDown_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Tools", "BrowserDownloadsView.exe");

            if (File.Exists(exePath))
            {
                Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("BrowserDownloadsView сломан!", "Ошибка");
            }
        }
    }
}
