namespace Checker.UserControls
{
    partial class UC_SteamAcc
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SteamAcc));
            lblUser = new Label();
            lblSteamID = new Label();
            lblCountry = new Label();
            lblCrimsonBan = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblDateReg = new Label();
            lblTypeProf = new Label();
            lblVac = new Label();
            lblStatusVac = new Label();
            bunifupnllinear_1 = new Bunifu.UI.WinForms.BunifuPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(88, 23);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(189, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "jkkjfkdslfjskjfdfsdkfjsdf";
            // 
            // lblSteamID
            // 
            lblSteamID.AutoSize = true;
            lblSteamID.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSteamID.Location = new Point(88, 60);
            lblSteamID.Name = "lblSteamID";
            lblSteamID.Size = new Size(43, 15);
            lblSteamID.TabIndex = 0;
            lblSteamID.Text = "Steam";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblCountry.Location = new Point(12, 177);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(84, 17);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Страна:   ?";
            // 
            // lblCrimsonBan
            // 
            lblCrimsonBan.AutoSize = true;
            lblCrimsonBan.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblCrimsonBan.Location = new Point(12, 134);
            lblCrimsonBan.Name = "lblCrimsonBan";
            lblCrimsonBan.Size = new Size(168, 17);
            lblCrimsonBan.TabIndex = 0;
            lblCrimsonBan.Text = "Блокировка CRIMSON: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.steam;
            pictureBox1.Location = new Point(295, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(12, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblDateReg
            // 
            lblDateReg.AutoSize = true;
            lblDateReg.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblDateReg.Location = new Point(12, 203);
            lblDateReg.Name = "lblDateReg";
            lblDateReg.Size = new Size(147, 17);
            lblDateReg.TabIndex = 0;
            lblDateReg.Text = "Дата регистрации:";
            // 
            // lblTypeProf
            // 
            lblTypeProf.AutoSize = true;
            lblTypeProf.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblTypeProf.Location = new Point(12, 230);
            lblTypeProf.Name = "lblTypeProf";
            lblTypeProf.Size = new Size(109, 17);
            lblTypeProf.TabIndex = 0;
            lblTypeProf.Text = "Тип профиля:";
            // 
            // lblVac
            // 
            lblVac.AutoSize = true;
            lblVac.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblVac.Location = new Point(12, 107);
            lblVac.Name = "lblVac";
            lblVac.Size = new Size(130, 17);
            lblVac.TabIndex = 0;
            lblVac.Text = "Блокировка VAC:";
            // 
            // lblStatusVac
            // 
            lblStatusVac.AutoSize = true;
            lblStatusVac.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblStatusVac.Location = new Point(148, 107);
            lblStatusVac.Name = "lblStatusVac";
            lblStatusVac.Size = new Size(46, 17);
            lblStatusVac.TabIndex = 26;
            lblStatusVac.Text = "Status";
            // 
            // bunifupnllinear_1
            // 
            bunifupnllinear_1.BackgroundColor = Color.Red;
            bunifupnllinear_1.BackgroundImage = (Image)resources.GetObject("bunifupnllinear_1.BackgroundImage");
            bunifupnllinear_1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifupnllinear_1.BorderColor = Color.Transparent;
            bunifupnllinear_1.BorderRadius = 3;
            bunifupnllinear_1.BorderThickness = 1;
            bunifupnllinear_1.ForeColor = SystemColors.ControlText;
            bunifupnllinear_1.Location = new Point(10, 163);
            bunifupnllinear_1.Name = "bunifupnllinear_1";
            bunifupnllinear_1.ShowBorders = true;
            bunifupnllinear_1.Size = new Size(320, 2);
            bunifupnllinear_1.TabIndex = 27;
            // 
            // UC_SteamAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(bunifupnllinear_1);
            Controls.Add(lblStatusVac);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblVac);
            Controls.Add(lblCrimsonBan);
            Controls.Add(lblTypeProf);
            Controls.Add(lblDateReg);
            Controls.Add(lblCountry);
            Controls.Add(lblSteamID);
            Controls.Add(lblUser);
            ForeColor = Color.White;
            Name = "UC_SteamAcc";
            Size = new Size(340, 280);
            Load += UC_SteamAcc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblSteamID;
        private Label lblCountry;
        private Label lblCrimsonBan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblDateReg;
        private Label lblTypeProf;
        private Label lblVac;
        private Label lblStatusVac;
        private Bunifu.UI.WinForms.BunifuPanel bunifupnllinear_1;
    }
}
