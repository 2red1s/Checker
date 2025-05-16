using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Checker.Forms;
using Checker.UserControl;

namespace Checker
{
    public partial class Main : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthellipse,
        int nHeightellipse
        );

        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            btnFindFiles.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);

            pnlContainer2.Controls.Clear();
            pnlContainer2.Controls.Add(userControl);
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFindFiles.Height;
            pnlNav.Top = btnFindFiles.Top;
            pnlNav.Left = btnFindFiles.Left;
            btnFindFiles.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReg.Height;
            pnlNav.Top = btnReg.Top;
            btnReg.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnProgs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProgs.Height;
            pnlNav.Top = btnProgs.Top;
            btnProgs.BackColor = Color.FromArgb(46, 51, 73);


        }
        private void btnWeb_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnWeb.Height;
            pnlNav.Top = btnWeb.Top;
            btnWeb.BackColor = Color.FromArgb(46, 51, 73);

            UC_Web uc = new UC_Web();
            addUserControl(uc);
             UC_Web2 uc2 = new UC_Web2();
            addUserControl(uc2);
        }
        private void btnExtra_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExtra.Height;
            pnlNav.Top = btnExtra.Top;
            btnExtra.BackColor = Color.FromArgb(46, 51, 73);

            //UC_Extra uc = new UC_Extra();
            //addUserControl(uc);
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
    }
}
