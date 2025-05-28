using System.Net.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Checker.UserControls
{
    public partial class UC_SteamAcc : UserControl
    {
        public UC_SteamAcc()
        {
            InitializeComponent();
        }

        private void UC_SteamAcc_Load(object sender, EventArgs e)
        {
            ShowCurrentAccount();
        }
        private void ShowCurrentAccount()
        {
            
            var accounts = SteamHelper.LoadSteamAccounts();
            var current = accounts.FirstOrDefault(a => a.IsMostRecent);

            if (current != null)
            {
                lblUser.Text = current.PersonaName.Length > 25
                    ? current.PersonaName.Substring(0,25) + "..." : current.PersonaName;
                //labelLogin.Text = $"Логин: {current.AccountName}";
                lblSteamID.Text = $"SteamID: {current.SteamID}";
                //labelLastLogin.Text = $"Последний вход: {current.LastLogin}";
                
            }
            else
            {
                // labelNickname.Text = "Нет активного аккаунта";
            }
            LoadSteamProfileInfo(current.SteamID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string steamId = lblSteamID.Text.Replace("SteamID: ", "").Trim();

            if (!string.IsNullOrEmpty(steamId))
            {
                string url = "https://steamcommunity.com/profiles/" + steamId;
                try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
                }
            }
        }

        private async void LoadSteamProfileInfo(string steamId)
        {
            try
            {
                string profileUrl = $"https://steamcommunity.com/profiles/{steamId}?xml=1";

                using (var client = new HttpClient())
                {
                    string xml = await client.GetStringAsync(profileUrl);

                    var doc = new System.Xml.XmlDocument();
                    doc.LoadXml(xml);

                    // ===== Аватар =====
                    var avatarNode = doc.SelectSingleNode("//avatarMedium");
                    if (avatarNode != null)
                    {
                        string avatarUrl = avatarNode.InnerText.Trim();
                        pictureBox2.Load(avatarUrl);
                    }
                    else
                    {
                       // pictureBox2.Image = Properties.Resources.default_avatar; // если добавишь
                    }

                    // ===== Дата регистрации =====
                    var memberSinceNode = doc.SelectSingleNode("//memberSince");
                    if (memberSinceNode != null)
                    {
                        lblDateReg.Text = "Дата регистрации: " + memberSinceNode.InnerText.Trim();
                    }
                    else
                    {
                        lblDateReg.Text = "Дата регистрации: ?";
                    }

                    // ===== Тип профиля =====
                    var visibilityNode = doc.SelectSingleNode("//privacyState");
                    if (visibilityNode != null)
                    {
                        string profileType = visibilityNode.InnerText.Trim();
                        lblTypeProf.Text = "Тип профиля: " + profileType; // public / private
                    }
                    else
                    {
                        lblTypeProf.Text = "Тип: ?";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки профиля: " + ex.Message);
            }
           await CheckGameBanHtml(steamId);
        }

        private async Task CheckGameBanHtml(string steamId)
        {
            try
            {
                string url = $"https://steamcommunity.com/profiles/{steamId}/";
                using (HttpClient client = new HttpClient())
                {
                    string html = await client.GetStringAsync(url);
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    var banBlock = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'profile_ban_status')]");
                    if (banBlock != null)
                    {
                        string text = Regex.Replace(banBlock.InnerText.Trim(), @"\s+", " ");

                        // Проверяем, есть ли упоминание блокировки
                        var match = Regex.Match(text, @"(\d+)\s+игровая блокировка.*?Дней с последней блокировки:\s*(\d+)", RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            int days = int.Parse(match.Groups[2].Value);
                            lblStatusVac.Text = $"Detected ({days} дней назад)";
                            lblStatusVac.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblStatusVac.Text = $"Detected";
                            lblStatusVac.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblStatusVac.Text = "Undetected";
                        lblStatusVac.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatusVac.Text = "Ошибка проверки VAC";
                Console.WriteLine(ex.Message);
            }
        }








        private void bunifupnllinear_1_Paint(object sender, PaintEventArgs e)
        {
            bunifupnllinear_1.BackColor = Color.Red;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
