using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker.UserControls
{
    public partial class UC_Web : UserControl
    {
        public UC_Web()
        {
            InitializeComponent();
        }

        private void UC_Web_Load(object sender, EventArgs e)
        {

        }

        private void btnGdisk_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://drive.google.com",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Google Drive: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYdisk_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://360.yandex.ru/disk/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Yandex Disk: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFurios_Click(object sender, EventArgs e)
        {

        }

        private void btnXone_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://xone.fun/login",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Xone: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOnetap_Click(object sender, EventArgs e)
        {

            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://www.onetap.com/client/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть OneTap: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMidnight_Click(object sender, EventArgs e)
        {

            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://midnight.im/store/chity-cs-2/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Midnight: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInterium_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://interium.ooo/login/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Interium: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNixware_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://nixware.cc/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть NixWare: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhoenixhack_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://wh-satano.ru/cheats/cs2",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Phoenix-Hack: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNeverlose_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://ru.neverlose.cc/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Neverlose: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpAllcheats_Click(object sender, EventArgs e)
        {

        }
    }
}
