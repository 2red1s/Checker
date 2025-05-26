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
using static System.Net.WebRequestMethods;

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

        private void btnVRedux_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://vredux.com/ru/login",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть VREDUX: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string[] sites =
            {
                "https://drive.google.com",
                "https://360.yandex.ru/disk/",
                "https://vredux.com/ru/login",
                "https://xone.fun/login",
                "https://www.onetap.com/client/",
                "https://midnight.im/store/chity-cs-2/",
                "https://interium.ooo/login/",
                "https://nixware.cc/",
                "https://wh-satano.ru/cheats/cs2",
                "https://ru.neverlose.cc/",
                "https://spurdo.me/ru/auth/login",
                "https://aimware.net/forum/user/login",
                "https://oplata.info/info/"

            };
            try
            {
                foreach(string site in sites)
                {
                    Process.Start(new ProcessStartInfo { FileName = site, UseShellExecute = true});
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpurdo_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://spurdo.me/ru/auth/login",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть SPURDO: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAimWare_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://aimware.net/forum/user/login",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть AIMWARE: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOpIn_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://oplata.info/info/",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Oplata Info: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
