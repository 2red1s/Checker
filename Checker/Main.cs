using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Checker.UserControls;


namespace Checker
{
    public partial class Main : Form
    {

        // Для перемещения формы
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Для создания скругленного региона
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        Color btnColor = Color.FromArgb(40, 40, 40);
        Color btnColor_Leave = Color.FromArgb(20, 20, 20);





        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            //btnFindFiles.BackColor = btnColor;


            this.MouseDown += Main_MouseDown;



        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }



        private void addUserControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            bunifuPanel1.BackColor = Color.FromArgb(110, Color.Black);
            bunifuPanel2.BackColor = Color.FromArgb(110, Color.Black);

        }


        // || =============================================== Вкладка Поиск Файлов ============================================ ||
        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            btnFindFiles.BackColor = btnColor;   //da


            bunifuPanel1.Size = new Size(810, 290);
            bunifuPanel1.Location = new Point(17, 97);

            bunifuPanel2.Size = new Size(810, 93);
            bunifuPanel2.Location = new Point(17, 394);



            lblStatus.Text = "Автоматический поиск файлов";

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;




            addUserControl(bunifuPanel1, new UC_FindFiles());
            addUserControl(bunifuPanel2, new UC_FindFiles2());


        }


        // || =============================================== Вкладка Реестр ПК ============================================ ||
        private void btnReg_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReg.Height;
            pnlNav.Top = btnReg.Top;
            btnReg.BackColor = btnColor; // net

            lblStatus.Text = "Проверка реестра ПК";

        }


        // || =============================================== Вкладка Программы ============================================ ||
        private void btnProgs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProgs.Height;
            pnlNav.Top = btnProgs.Top;
            btnProgs.BackColor = btnColor;

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = false;

            // Меняем размер и позицию панели под нужный стиль этой вкладки
            bunifuPanel1.Size = new Size(810, 230);
            bunifuPanel1.Location = new Point(16, 97);

            bunifuPanel2.Size = new Size(810, 120);
            bunifuPanel2.Location = new Point(16, 367);



            lblStatus.Text = "Программы для проверки";

            lblInfo.Text = "История щапусков / Работа с файлами";
            lblInfo.Location = new Point(17, 93);

            lblInfo2.Text = "Советы по проверки программами";
            //lblInfo2.Location = new Point(17, )

            // Загружаем UserControls
            addUserControl(bunifuPanel1, new UC_Progs());
            addUserControl(bunifuPanel2, new UC_Progs2());

        }


        // || =============================================== Вкладка Веб проверка ============================================ ||
        private void btnWeb_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnWeb.Height;
            pnlNav.Top = btnWeb.Top;
            btnWeb.BackColor = btnColor;

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            bunifuPanel1.Size = new Size(570, 400);
            bunifuPanel1.Location = new Point(17, 97);

            bunifuPanel2.Size = new Size(210, 400);
            bunifuPanel2.Location = new Point(615, 97);



            lblStatus.Text = "Проверка веб-сайтов";

            lblInfo.Text = "Проверка сайтов в браузере";
            lblInfo.Location = new Point(17, 73);

            lblInfo2.Text = "Информация о браузерах";
            lblInfo2.Location = new Point(373, 97);

            addUserControl(bunifuPanel1, new UC_Web());
            // addUserControl(pnlContainer, new UC_Web());
            addUserControl(bunifuPanel2, new UC_Web2());



        }


        // || =============================================== Вкладка Дополнительно ============================================ ||
        private void btnExtra_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExtra.Height;
            pnlNav.Top = btnExtra.Top;
            btnExtra.BackColor = btnColor;

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            bunifuPanel1.Size = new Size(570, 400);
            bunifuPanel1.Location = new Point(17, 97);

            bunifuPanel2.Size = new Size(210, 400);
            bunifuPanel2.Location = new Point(615, 97);


            lblStatus.Text = "Дополнительные функции";

            lblInfo.Text = "Проверка содержимого папок";
            lblInfo.Location = new Point(17,73);

            lblInfo2.Text = "Содержимое папки CS2";
            lblInfo2.Location = new Point(373, 97);

            addUserControl(bunifuPanel1, new UC_Extra());
            addUserControl(bunifuPanel2, new UC_Extra2());

        }
        // || =============================================== Вкладка Steam Аккаунты ============================================ ||
        private void btnSteamAcc_Click(object sender, EventArgs e)

        {
            pnlNav.Height = btnExtra.Height;
            pnlNav.Top = btnExtra.Top;
            btnSteamAcc.BackColor = btnColor;

            bunifuPanel1.Size = new Size(340, 280);
            bunifuPanel1.Location = new Point(17, 97);

            bunifuPanel2.Size = new Size(455, 340);
            bunifuPanel2.Location = new Point(373, 97);

            lblInfo.Text = "Текущий STEAM аккаунт";
            lblInfo.Location = new Point(17, 73);

            lblInfo2.Text = "Другие STEAM аккаунты";
            lblInfo2.Location = new Point(373, 73);

            addUserControl(bunifuPanel1, new UC_SteamAcc());
            addUserControl(bunifuPanel2, new UC_SteamAcc2());
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFindFiles_Leave(object sender, EventArgs e)
        {
            btnFindFiles.BackColor = btnColor_Leave;
        }

        private void btnProgs_Leave(object sender, EventArgs e)
        {
            btnProgs.BackColor = btnColor_Leave;
        }

        private void btnReg_Leave(object sender, EventArgs e)
        {
            btnReg.BackColor = btnColor_Leave;
        }

        private void btnWeb_Leave(object sender, EventArgs e)
        {
            btnWeb.BackColor = btnColor_Leave;
        }

        private void btnExtra_Leave(object sender, EventArgs e)
        {
            btnExtra.BackColor = btnColor_Leave;
        }

        private void btnProgs_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer2_Click(object sender, EventArgs e)
        {
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {

        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btndiscord_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://discord.gg/cJadErb6dr",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть Discrod: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gridFindfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSteamAcc_Leave(object sender, EventArgs e)
        {
            btnSteamAcc.BackColor = btnColor_Leave;
        }

        private void btnExtra_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlLine_Paint(object sender, PaintEventArgs e)
        {
            pnlLine.BackColor = Color.Red;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void pnlline_3_Paint(object sender, PaintEventArgs e)
        {
            pnlline_3.BackColor = Color.Red;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void pnlContainer_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlContainer2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRed1soff_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "https://t.me/red1s_off",
                    UseShellExecute = true
                };
                Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dev, предоставил не верную ссылку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
