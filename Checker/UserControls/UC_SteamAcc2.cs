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
    public partial class UC_SteamAcc2 : UserControl
    {
        private int offsetY;
        public UC_SteamAcc2()
        {
            InitializeComponent();
        }

        private void UC_SteamAcc2_Load(object sender, EventArgs e)
        {
            //ShowCurrentAccount();
            LoadOtherAccounts();
        }

        //private void LoadOtherAccounts()
        //{
        //    var accounts = SteamHelper.LoadSteamAccounts();
        //    var current = accounts.FirstOrDefault(a => a.IsMostRecent);

        //    var others = accounts.Where(a => a.SteamID != current?.SteamID).ToList();

        //    foreach (var acc in others)
        //    {
        //        // Добавляем отступ перед карточкой, кроме первой
        //        if (bunifuPanel1.Controls.Count > 0)
        //        {
        //            var spacer = new Panel
        //            {
        //                Width = 20,
        //                Height = 20, // высота отступа
        //                Dock = DockStyle.Top
        //            };
        //            bunifuPanel1.Controls.Add(spacer);
        //        }

        //        var card = new UC_SteamAccOther();
        //        card.Anchor = AnchorStyles.Top;
        //        card.Location = new Point(10, offsetY); // можно управлять положением
        //        card.Size = new Size(365, 110);
        //        card.Dock = DockStyle.Top;
        //        card.LoadAccount(acc.SteamID, acc.PersonaName);

        //        bunifuPanel1.Controls.Add(card);
        //    }
        //}

        private void LoadOtherAccounts()
        {
            var accounts = SteamHelper.LoadSteamAccounts();
            var current = accounts.FirstOrDefault(a => a.IsMostRecent);

            var others = accounts.Where(a => a.SteamID != current?.SteamID).ToList();

            offsetY = 10; // Начальный отступ сверху

            foreach (var acc in others)
            {
                var card = new UC_SteamAccOther
                {
                    Size = new Size(365, 110), // Фиксированный размер
                    Margin = new Padding(10, 10, 10, 10), // Отступы: слева, сверху, справа, снизу
                    Location = new Point(45, offsetY), // Позиция карточки
                    Anchor = AnchorStyles.Top | AnchorStyles.Left // Фиксация к верхнему левому углу
                };

                card.LoadAccount(acc.SteamID, acc.PersonaName);
                bunifuPanel1.Controls.Add(card);

                // Увеличиваем offsetY для следующей карточки
                offsetY += card.Height + card.Margin.Top + card.Margin.Bottom; // Высота карточки + отступы
            }
        }
    }
}
