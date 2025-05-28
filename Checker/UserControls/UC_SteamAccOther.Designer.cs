namespace Checker.UserControls
{
    partial class UC_SteamAccOther
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
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            lblSteamID = new Label();
            lblVac = new Label();
            lblCrimsonBan = new Label();
            pictureBox2 = new PictureBox();
            lblStatusVac = new Label();
            lblStatusCrimson = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(82, 11);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(35, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            // 
            // lblSteamID
            // 
            lblSteamID.AutoSize = true;
            lblSteamID.BackColor = Color.Transparent;
            lblSteamID.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblSteamID.ForeColor = Color.White;
            lblSteamID.Location = new Point(12, 84);
            lblSteamID.Name = "lblSteamID";
            lblSteamID.Size = new Size(64, 17);
            lblSteamID.TabIndex = 2;
            lblSteamID.Text = "SteamID:";
            // 
            // lblVac
            // 
            lblVac.AutoSize = true;
            lblVac.BackColor = Color.Transparent;
            lblVac.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblVac.ForeColor = Color.White;
            lblVac.Location = new Point(82, 37);
            lblVac.Name = "lblVac";
            lblVac.Size = new Size(130, 17);
            lblVac.TabIndex = 3;
            lblVac.Text = "Блокировка VAC:";
            // 
            // lblCrimsonBan
            // 
            lblCrimsonBan.AutoSize = true;
            lblCrimsonBan.BackColor = Color.Transparent;
            lblCrimsonBan.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblCrimsonBan.ForeColor = Color.White;
            lblCrimsonBan.Location = new Point(82, 63);
            lblCrimsonBan.Name = "lblCrimsonBan";
            lblCrimsonBan.Size = new Size(164, 17);
            lblCrimsonBan.TabIndex = 4;
            lblCrimsonBan.Text = "Блокировка CRIMSON:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.steam;
            pictureBox2.Location = new Point(320, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblStatusVac
            // 
            lblStatusVac.AutoSize = true;
            lblStatusVac.BackColor = Color.Transparent;
            lblStatusVac.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblStatusVac.ForeColor = Color.White;
            lblStatusVac.Location = new Point(218, 37);
            lblStatusVac.Name = "lblStatusVac";
            lblStatusVac.Size = new Size(46, 17);
            lblStatusVac.TabIndex = 6;
            lblStatusVac.Text = "Status";
            lblStatusVac.Click += lblStatusVac_Click;
            // 
            // lblStatusCrimson
            // 
            lblStatusCrimson.AutoSize = true;
            lblStatusCrimson.BackColor = Color.Transparent;
            lblStatusCrimson.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lblStatusCrimson.ForeColor = Color.Green;
            lblStatusCrimson.Location = new Point(252, 63);
            lblStatusCrimson.Name = "lblStatusCrimson";
            lblStatusCrimson.Size = new Size(78, 17);
            lblStatusCrimson.TabIndex = 7;
            lblStatusCrimson.Text = "Undetected";
            // 
            // UC_SteamAccOther
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblStatusCrimson);
            Controls.Add(lblStatusVac);
            Controls.Add(pictureBox2);
            Controls.Add(lblCrimsonBan);
            Controls.Add(lblVac);
            Controls.Add(lblSteamID);
            Controls.Add(lblUser);
            Controls.Add(pictureBox1);
            Name = "UC_SteamAccOther";
            Size = new Size(365, 110);
            Load += UC_SteamAccOther_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUser;
        private Label lblSteamID;
        private Label lblVac;
        private Label lblCrimsonBan;
        private PictureBox pictureBox2;
        private Label lblStatusVac;
        private Label lblStatusCrimson;
    }
}
