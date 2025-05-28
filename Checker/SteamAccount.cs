using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checker
{
    public class SteamAccount
    {
        public string SteamID { get; set; }
        public string AccountName { get; set; }
        public string PersonaName { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsMostRecent { get; set; }
    }
}
