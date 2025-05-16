namespace Checker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            pnlNav = new Panel();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            btnExtra = new Button();
            btnWeb = new Button();
            btnReg = new Button();
            btnProgs = new Button();
            btnFindFiles = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlContainer = new Bunifu.UI.WinForms.BunifuPanel();
            pnlContainer2 = new Bunifu.UI.WinForms.BunifuPanel();
            panel1.SuspendLayout();
            pnlNav.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnExtra);
            panel1.Controls.Add(btnWeb);
            panel1.Controls.Add(btnReg);
            panel1.Controls.Add(btnProgs);
            panel1.Controls.Add(btnFindFiles);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 561);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Controls.Add(checkedListBox1);
            pnlNav.Location = new Point(0, 254);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(0, 74);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 129, 240);
            label3.Location = new Point(12, 526);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "v1.0 ";
            label3.Click += label2_Click;
            // 
            // btnExtra
            // 
            btnExtra.AutoSize = true;
            btnExtra.BackColor = Color.Gray;
            btnExtra.Dock = DockStyle.Top;
            btnExtra.FlatAppearance.BorderSize = 0;
            btnExtra.FlatStyle = FlatStyle.Flat;
            btnExtra.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtra.ForeColor = Color.FromArgb(252, 100, 99);
            btnExtra.Image = (Image)resources.GetObject("btnExtra.Image");
            btnExtra.Location = new Point(0, 368);
            btnExtra.Name = "btnExtra";
            btnExtra.Size = new Size(241, 50);
            btnExtra.TabIndex = 1;
            btnExtra.Text = "Дополнительно";
            btnExtra.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExtra.UseVisualStyleBackColor = false;
            btnExtra.Click += btnExtra_Click;
            btnExtra.Leave += btnExtra_Leave;
            // 
            // btnWeb
            // 
            btnWeb.AutoSize = true;
            btnWeb.BackColor = Color.Gray;
            btnWeb.Dock = DockStyle.Top;
            btnWeb.FlatAppearance.BorderSize = 0;
            btnWeb.FlatStyle = FlatStyle.Flat;
            btnWeb.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWeb.ForeColor = Color.FromArgb(252, 100, 99);
            btnWeb.Image = (Image)resources.GetObject("btnWeb.Image");
            btnWeb.Location = new Point(0, 318);
            btnWeb.Name = "btnWeb";
            btnWeb.Size = new Size(241, 50);
            btnWeb.TabIndex = 1;
            btnWeb.Text = "Провекра Web  ";
            btnWeb.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnWeb.UseVisualStyleBackColor = false;
            btnWeb.Click += btnWeb_Click;
            btnWeb.Leave += btnWeb_Leave;
            // 
            // btnReg
            // 
            btnReg.AutoSize = true;
            btnReg.BackColor = Color.Gray;
            btnReg.Dock = DockStyle.Top;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.FromArgb(252, 100, 99);
            btnReg.Image = (Image)resources.GetObject("btnReg.Image");
            btnReg.Location = new Point(0, 268);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(241, 50);
            btnReg.TabIndex = 1;
            btnReg.Text = "Реестр ПК        ";
            btnReg.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            btnReg.Leave += btnReg_Leave;
            // 
            // btnProgs
            // 
            btnProgs.AutoSize = true;
            btnProgs.BackColor = Color.Gray;
            btnProgs.Dock = DockStyle.Top;
            btnProgs.FlatAppearance.BorderSize = 0;
            btnProgs.FlatStyle = FlatStyle.Flat;
            btnProgs.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgs.ForeColor = Color.FromArgb(252, 100, 99);
            btnProgs.Image = (Image)resources.GetObject("btnProgs.Image");
            btnProgs.Location = new Point(0, 218);
            btnProgs.Name = "btnProgs";
            btnProgs.Size = new Size(241, 50);
            btnProgs.TabIndex = 1;
            btnProgs.Text = "Программы      ";
            btnProgs.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProgs.UseVisualStyleBackColor = false;
            btnProgs.Click += btnProgs_Click;
            btnProgs.Enter += btnProgs_Enter;
            btnProgs.Leave += btnProgs_Leave;
            // 
            // btnFindFiles
            // 
            btnFindFiles.AutoSize = true;
            btnFindFiles.BackColor = Color.Gray;
            btnFindFiles.Dock = DockStyle.Top;
            btnFindFiles.FlatAppearance.BorderSize = 0;
            btnFindFiles.FlatStyle = FlatStyle.Flat;
            btnFindFiles.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindFiles.ForeColor = Color.FromArgb(252, 100, 99);
            btnFindFiles.Image = (Image)resources.GetObject("btnFindFiles.Image");
            btnFindFiles.Location = new Point(0, 168);
            btnFindFiles.Name = "btnFindFiles";
            btnFindFiles.Size = new Size(241, 50);
            btnFindFiles.TabIndex = 1;
            btnFindFiles.Text = "Поиск файлов";
            btnFindFiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFindFiles.UseVisualStyleBackColor = false;
            btnFindFiles.Click += btnFindFiles_Click;
            btnFindFiles.Leave += btnFindFiles_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 168);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 100, 99);
            label1.Location = new Point(28, 130);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 1;
            label1.Text = "CRIMSON PROJECT";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1084, 561);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackgroundColor = Color.Gray;
            pnlContainer.BackgroundImage = (Image)resources.GetObject("pnlContainer.BackgroundImage");
            pnlContainer.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContainer.BorderColor = Color.IndianRed;
            pnlContainer.BorderRadius = 15;
            pnlContainer.BorderThickness = 1;
            pnlContainer.Location = new Point(258, 130);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.ShowBorders = true;
            pnlContainer.Size = new Size(570, 400);
            pnlContainer.TabIndex = 6;
            // 
            // pnlContainer2
            // 
            pnlContainer2.BackgroundColor = Color.Gray;
            pnlContainer2.BackgroundImage = (Image)resources.GetObject("pnlContainer2.BackgroundImage");
            pnlContainer2.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContainer2.BorderColor = Color.IndianRed;
            pnlContainer2.BorderRadius = 15;
            pnlContainer2.BorderThickness = 1;
            pnlContainer2.Location = new Point(852, 130);
            pnlContainer2.Name = "pnlContainer2";
            pnlContainer2.ShowBorders = true;
            pnlContainer2.Size = new Size(210, 400);
            pnlContainer2.TabIndex = 7;
            pnlContainer2.Click += pnlContainer2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1084, 561);
            Controls.Add(pnlContainer2);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlNav.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnFindFiles;
     
        private Label label1;
        private Button btnReg;
        private Button btnProgs;
        private Button btnExtra;
        private Button btnWeb;
        private Label label3;
        private Panel pnlNav;
        private CheckedListBox checkedListBox1;
        private Panel dasd;
        private PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel pnlContainer;
        private Bunifu.UI.WinForms.BunifuPanel pnlContainer2;
    }
}
