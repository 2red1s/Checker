using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameloop.Vdf;
using Microsoft.Win32;
using System.IO;
using Gameloop.Vdf.Linq;


namespace Checker
{
    public static class SteamHelper
    {
        public static string GetLoginUsersPath()
        {
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
            if (key != null)
            {
                string steamPath = key.GetValue("SteamPath")?.ToString();
                if (!string.IsNullOrEmpty(steamPath))
                {
                    return Path.Combine(steamPath, @"config\loginusers.vdf");
                }
            }

            return @"C:\Program Files (x86)\Steam\config\loginusers.vdf"; // fallback
        }

        public static List<SteamAccount> LoadSteamAccounts()
        {
            string path = GetLoginUsersPath();
            if (!File.Exists(path)) return new();

            var vdf = VdfConvert.Deserialize(File.ReadAllText(path));
            var root = (VObject)vdf.Value;
            var accounts = new List<SteamAccount>();

            foreach (var userNode in root)
            {
                string steamId = userNode.Key;
                var info = (VObject)userNode.Value;

                accounts.Add(new SteamAccount
                {
                    SteamID = steamId,
                    AccountName = info["AccountName"].ToString(),
                    PersonaName = info["PersonaName"].ToString(),
                    LastLogin = DateTimeOffset.FromUnixTimeSeconds(long.Parse(info["Timestamp"].ToString())).DateTime,
                    IsMostRecent = info["MostRecent"].ToString() == "1"
                });
            }

            return accounts;
        }
    }
}
