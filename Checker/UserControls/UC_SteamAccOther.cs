using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker.UserControls
{
    public partial class UC_SteamAccOther : UserControl
    {
        public UC_SteamAccOther()
        {
            InitializeComponent();
        }

        private void UC_SteamAccOther_Load(object sender, EventArgs e)
        {



        }
        public void LoadAccount(string steamId, string personaName)
        {
            lblUser.Text = personaName.Length > 25 ? personaName.Substring(0, 25) + "..." : personaName;
            lblSteamID.Text = "SteamID: " + steamId;
            LoadSteamProfileInfo(steamId);
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

                    var avatarNode = doc.SelectSingleNode("//avatarMedium");
                    if (avatarNode != null)
                        pictureBox1.Load(avatarNode.InnerText.Trim());

                }
            }
            catch
            {

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
                        var match = Regex.Match(text, @"(\d+)\s+игровая блокировка.*?Дней с последней блокировки:\s*(\d+)", RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            int days = int.Parse(match.Groups[2].Value);
                            lblStatusVac.Text = $"Detected ({days} дней назад)";
                            lblStatusVac.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblStatusVac.Text = "Detected";
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
            catch
            {
                lblStatusVac.Text = "Ошибка проверки VAC";
            }
        }

        private void lblStatusVac_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
