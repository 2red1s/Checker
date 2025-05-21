using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Checker.Forms;
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

        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            btnFindFiles.BackColor = Color.FromArgb(46, 51, 73);


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
            pnlContainer.BackColor = Color.FromArgb(50, 0, 0, 0);

        }


// || =============================================== Вкладка Поиск Файлов ============================================ ||
        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            btnFindFiles.BackColor = Color.FromArgb(46, 51, 73);

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            pnlContainer.Size = new Size(810, 290);
            pnlContainer.Location = new Point(258, 130);

            pnlContainer2.Size = new Size(810, 93);
            pnlContainer2.Location = new Point(258, 448);

            lblStatus.Text = "Автоматический поиск файлов";

            addUserControl(pnlContainer, new UC_FindFiles());
            addUserControl(pnlContainer2, new UC_FindFiles2());

            
        }


// || =============================================== Вкладка Реестр ПК ============================================ ||
        private void btnReg_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReg.Height;
            pnlNav.Top = btnReg.Top;
            btnReg.BackColor = Color.FromArgb(46, 51, 73);

            lblStatus.Text = "Проверка реестра ПК";
        }


// || =============================================== Вкладка Программы ============================================ ||
        private void btnProgs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProgs.Height;
            pnlNav.Top = btnProgs.Top;
            btnProgs.BackColor = Color.FromArgb(46, 51, 73);

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            // Меняем размер и позицию панели под нужный стиль этой вкладки
            pnlContainer.Size = new Size(730, 230);
            pnlContainer.Location = new Point(300, 130);

            pnlContainer2.Size = new Size(730, 120);
            pnlContainer2.Location = new Point(300, 420);

            lblStatus.Text = "Программы для проверки";

            // Загружаем UserControls
            addUserControl(pnlContainer, new UC_Progs());
            addUserControl(pnlContainer2, new UC_Progs2());

        }


// || =============================================== Вкладка Веб проверка ============================================ ||
        private void btnWeb_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnWeb.Height;
            pnlNav.Top = btnWeb.Top;
            btnWeb.BackColor = Color.FromArgb(46, 51, 73);

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            pnlContainer.Size = new Size(570, 400);
            pnlContainer.Location = new Point(258, 130);

            pnlContainer2.Size = new Size(210, 400);
            pnlContainer2.Location = new Point(853, 130);

            lblStatus.Text = "Проверка веб-сайтов";

            addUserControl(pnlContainer, new UC_Web());
            addUserControl(pnlContainer2, new UC_Web2());



        }


// || =============================================== Вкладка Дополнительно ============================================ ||
        private void btnExtra_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExtra.Height;
            pnlNav.Top = btnExtra.Top;
            btnExtra.BackColor = Color.FromArgb(46, 51, 73);

            //pnlContainer.Visible = true;
            //pnlContainer2.Visible = true;

            pnlContainer.Size = new Size(570, 400);
            pnlContainer.Location = new Point(258, 130);

            pnlContainer2.Size = new Size(210, 400);
            pnlContainer2.Location = new Point(853, 130);

            lblStatus.Text = "Дополнительные функции";

            addUserControl(pnlContainer, new UC_Extra());
            addUserControl(pnlContainer2, new UC_Extra2());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFindFiles_Leave(object sender, EventArgs e)
        {
            btnFindFiles.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProgs_Leave(object sender, EventArgs e)
        {
            btnProgs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReg_Leave(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnWeb_Leave(object sender, EventArgs e)
        {
            btnWeb.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExtra_Leave(object sender, EventArgs e)
        {
            btnExtra.BackColor = Color.FromArgb(24, 30, 54);
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
            this.WindowState = FormWindowState.Minimized;
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
                    FileName = " https://discord.gg/sstGh2TYWu",
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
    }
}
