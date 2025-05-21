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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
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
            pnlContainer = new Panel();
            pnlContainer2 = new Panel();
            btncross = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnhide = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btndiscord = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            panel3 = new Panel();
            lblStatus = new Label();
            pictureBox2 = new PictureBox();
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
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Location = new Point(258, 130);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(570, 400);
            pnlContainer.TabIndex = 8;
            pnlContainer.Paint += pnlContainer_Paint_1;
            // 
            // pnlContainer2
            // 
            pnlContainer2.BackColor = Color.DimGray;
            pnlContainer2.Location = new Point(853, 130);
            pnlContainer2.Name = "pnlContainer2";
            pnlContainer2.Size = new Size(210, 400);
            pnlContainer2.TabIndex = 9;
            // 
            // btncross
            // 
            btncross.AllowAnimations = true;
            btncross.AllowMouseEffects = true;
            btncross.AllowToggling = false;
            btncross.AnimationSpeed = 200;
            btncross.AutoGenerateColors = false;
            btncross.AutoRoundBorders = false;
            btncross.AutoSizeLeftIcon = true;
            btncross.AutoSizeRightIcon = true;
            btncross.BackColor = Color.Transparent;
            btncross.BackColor1 = Color.FromArgb(51, 122, 183);
            btncross.BackgroundImage = (Image)resources.GetObject("btncross.BackgroundImage");
            btncross.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btncross.ButtonText = "";
            btncross.ButtonTextMarginLeft = 0;
            btncross.ColorContrastOnClick = 45;
            btncross.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btncross.CustomizableEdges = borderEdges1;
            btncross.DialogResult = DialogResult.None;
            btncross.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btncross.DisabledFillColor = Color.Empty;
            btncross.DisabledForecolor = Color.Empty;
            btncross.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btncross.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncross.ForeColor = Color.White;
            btncross.IconLeft = (Image)resources.GetObject("btncross.IconLeft");
            btncross.IconLeftAlign = ContentAlignment.MiddleCenter;
            btncross.IconLeftCursor = Cursors.Hand;
            btncross.IconLeftPadding = new Padding(11, 3, 3, 3);
            btncross.IconMarginLeft = 11;
            btncross.IconPadding = 10;
            btncross.IconRight = null;
            btncross.IconRightAlign = ContentAlignment.MiddleRight;
            btncross.IconRightCursor = Cursors.Default;
            btncross.IconRightPadding = new Padding(3, 3, 7, 3);
            btncross.IconSize = 25;
            btncross.IdleBorderColor = Color.Empty;
            btncross.IdleBorderRadius = 0;
            btncross.IdleBorderThickness = 0;
            btncross.IdleFillColor = Color.Empty;
            btncross.IdleIconLeftImage = (Image)resources.GetObject("btncross.IdleIconLeftImage");
            btncross.IdleIconRightImage = null;
            btncross.IndicateFocus = false;
            btncross.Location = new Point(1023, 8);
            btncross.Name = "btncross";
            btncross.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btncross.OnDisabledState.BorderRadius = 1;
            btncross.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btncross.OnDisabledState.BorderThickness = 1;
            btncross.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btncross.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btncross.OnDisabledState.IconLeftImage = null;
            btncross.OnDisabledState.IconRightImage = null;
            btncross.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btncross.onHoverState.BorderRadius = 1;
            btncross.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btncross.onHoverState.BorderThickness = 1;
            btncross.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btncross.onHoverState.ForeColor = Color.White;
            btncross.onHoverState.IconLeftImage = null;
            btncross.onHoverState.IconRightImage = null;
            btncross.OnIdleState.BorderColor = Color.DodgerBlue;
            btncross.OnIdleState.BorderRadius = 1;
            btncross.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btncross.OnIdleState.BorderThickness = 1;
            btncross.OnIdleState.FillColor = Color.DodgerBlue;
            btncross.OnIdleState.ForeColor = Color.White;
            btncross.OnIdleState.IconLeftImage = (Image)resources.GetObject("btncross.OnIdleState.IconLeftImage");
            btncross.OnIdleState.IconRightImage = null;
            btncross.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btncross.OnPressedState.BorderRadius = 1;
            btncross.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btncross.OnPressedState.BorderThickness = 1;
            btncross.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btncross.OnPressedState.ForeColor = Color.White;
            btncross.OnPressedState.IconLeftImage = null;
            btncross.OnPressedState.IconRightImage = null;
            btncross.Size = new Size(40, 40);
            btncross.TabIndex = 0;
            btncross.TextAlign = ContentAlignment.MiddleCenter;
            btncross.TextAlignment = HorizontalAlignment.Center;
            btncross.TextMarginLeft = 0;
            btncross.TextPadding = new Padding(0);
            btncross.UseDefaultRadiusAndThickness = true;
            btncross.Click += btncross_Click;
            // 
            // btnhide
            // 
            btnhide.AllowAnimations = true;
            btnhide.AllowMouseEffects = true;
            btnhide.AllowToggling = false;
            btnhide.AnimationSpeed = 200;
            btnhide.AutoGenerateColors = false;
            btnhide.AutoRoundBorders = false;
            btnhide.AutoSizeLeftIcon = true;
            btnhide.AutoSizeRightIcon = true;
            btnhide.BackColor = Color.Transparent;
            btnhide.BackColor1 = Color.FromArgb(51, 122, 183);
            btnhide.BackgroundImage = (Image)resources.GetObject("btnhide.BackgroundImage");
            btnhide.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnhide.ButtonText = "";
            btnhide.ButtonTextMarginLeft = 0;
            btnhide.ColorContrastOnClick = 45;
            btnhide.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnhide.CustomizableEdges = borderEdges2;
            btnhide.DialogResult = DialogResult.None;
            btnhide.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnhide.DisabledFillColor = Color.Empty;
            btnhide.DisabledForecolor = Color.Empty;
            btnhide.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnhide.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhide.ForeColor = Color.White;
            btnhide.IconLeft = (Image)resources.GetObject("btnhide.IconLeft");
            btnhide.IconLeftAlign = ContentAlignment.MiddleCenter;
            btnhide.IconLeftCursor = Cursors.Hand;
            btnhide.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnhide.IconMarginLeft = 11;
            btnhide.IconPadding = 10;
            btnhide.IconRight = null;
            btnhide.IconRightAlign = ContentAlignment.MiddleRight;
            btnhide.IconRightCursor = Cursors.Default;
            btnhide.IconRightPadding = new Padding(3, 3, 7, 3);
            btnhide.IconSize = 25;
            btnhide.IdleBorderColor = Color.Empty;
            btnhide.IdleBorderRadius = 0;
            btnhide.IdleBorderThickness = 0;
            btnhide.IdleFillColor = Color.Empty;
            btnhide.IdleIconLeftImage = (Image)resources.GetObject("btnhide.IdleIconLeftImage");
            btnhide.IdleIconRightImage = null;
            btnhide.IndicateFocus = false;
            btnhide.Location = new Point(955, 8);
            btnhide.Name = "btnhide";
            btnhide.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnhide.OnDisabledState.BorderRadius = 1;
            btnhide.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnhide.OnDisabledState.BorderThickness = 1;
            btnhide.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnhide.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnhide.OnDisabledState.IconLeftImage = null;
            btnhide.OnDisabledState.IconRightImage = null;
            btnhide.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnhide.onHoverState.BorderRadius = 1;
            btnhide.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnhide.onHoverState.BorderThickness = 1;
            btnhide.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnhide.onHoverState.ForeColor = Color.White;
            btnhide.onHoverState.IconLeftImage = null;
            btnhide.onHoverState.IconRightImage = null;
            btnhide.OnIdleState.BorderColor = Color.DodgerBlue;
            btnhide.OnIdleState.BorderRadius = 1;
            btnhide.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnhide.OnIdleState.BorderThickness = 1;
            btnhide.OnIdleState.FillColor = Color.DodgerBlue;
            btnhide.OnIdleState.ForeColor = Color.White;
            btnhide.OnIdleState.IconLeftImage = (Image)resources.GetObject("btnhide.OnIdleState.IconLeftImage");
            btnhide.OnIdleState.IconRightImage = null;
            btnhide.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnhide.OnPressedState.BorderRadius = 1;
            btnhide.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnhide.OnPressedState.BorderThickness = 1;
            btnhide.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnhide.OnPressedState.ForeColor = Color.White;
            btnhide.OnPressedState.IconLeftImage = null;
            btnhide.OnPressedState.IconRightImage = null;
            btnhide.Size = new Size(40, 40);
            btnhide.TabIndex = 0;
            btnhide.TextAlign = ContentAlignment.MiddleCenter;
            btnhide.TextAlignment = HorizontalAlignment.Center;
            btnhide.TextMarginLeft = 0;
            btnhide.TextPadding = new Padding(0);
            btnhide.UseDefaultRadiusAndThickness = true;
            btnhide.Click += btnhide_Click;
            // 
            // btndiscord
            // 
            btndiscord.AllowAnimations = true;
            btndiscord.AllowMouseEffects = true;
            btndiscord.AllowToggling = false;
            btndiscord.AnimationSpeed = 200;
            btndiscord.AutoGenerateColors = false;
            btndiscord.AutoRoundBorders = false;
            btndiscord.AutoSizeLeftIcon = true;
            btndiscord.AutoSizeRightIcon = true;
            btndiscord.BackColor = Color.Transparent;
            btndiscord.BackColor1 = Color.FromArgb(51, 122, 183);
            btndiscord.BackgroundImage = (Image)resources.GetObject("btndiscord.BackgroundImage");
            btndiscord.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btndiscord.ButtonText = "";
            btndiscord.ButtonTextMarginLeft = 0;
            btndiscord.ColorContrastOnClick = 45;
            btndiscord.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btndiscord.CustomizableEdges = borderEdges3;
            btndiscord.DialogResult = DialogResult.None;
            btndiscord.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btndiscord.DisabledFillColor = Color.Empty;
            btndiscord.DisabledForecolor = Color.Empty;
            btndiscord.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btndiscord.Font = new Font("Segoe UI", 9F);
            btndiscord.ForeColor = Color.White;
            btndiscord.IconLeft = (Image)resources.GetObject("btndiscord.IconLeft");
            btndiscord.IconLeftAlign = ContentAlignment.MiddleLeft;
            btndiscord.IconLeftCursor = Cursors.Default;
            btndiscord.IconLeftPadding = new Padding(11, 3, 3, 3);
            btndiscord.IconMarginLeft = 11;
            btndiscord.IconPadding = 10;
            btndiscord.IconRight = null;
            btndiscord.IconRightAlign = ContentAlignment.MiddleRight;
            btndiscord.IconRightCursor = Cursors.Default;
            btndiscord.IconRightPadding = new Padding(3, 3, 7, 3);
            btndiscord.IconSize = 25;
            btndiscord.IdleBorderColor = Color.Empty;
            btndiscord.IdleBorderRadius = 0;
            btndiscord.IdleBorderThickness = 0;
            btndiscord.IdleFillColor = Color.Empty;
            btndiscord.IdleIconLeftImage = (Image)resources.GetObject("btndiscord.IdleIconLeftImage");
            btndiscord.IdleIconRightImage = null;
            btndiscord.IndicateFocus = false;
            btndiscord.Location = new Point(667, 8);
            btndiscord.Name = "btndiscord";
            btndiscord.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btndiscord.OnDisabledState.BorderRadius = 1;
            btndiscord.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btndiscord.OnDisabledState.BorderThickness = 1;
            btndiscord.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btndiscord.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btndiscord.OnDisabledState.IconLeftImage = null;
            btndiscord.OnDisabledState.IconRightImage = null;
            btndiscord.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btndiscord.onHoverState.BorderRadius = 1;
            btndiscord.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btndiscord.onHoverState.BorderThickness = 1;
            btndiscord.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btndiscord.onHoverState.ForeColor = Color.White;
            btndiscord.onHoverState.IconLeftImage = null;
            btndiscord.onHoverState.IconRightImage = null;
            btndiscord.OnIdleState.BorderColor = Color.DodgerBlue;
            btndiscord.OnIdleState.BorderRadius = 1;
            btndiscord.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btndiscord.OnIdleState.BorderThickness = 1;
            btndiscord.OnIdleState.FillColor = Color.DodgerBlue;
            btndiscord.OnIdleState.ForeColor = Color.White;
            btndiscord.OnIdleState.IconLeftImage = (Image)resources.GetObject("btndiscord.OnIdleState.IconLeftImage");
            btndiscord.OnIdleState.IconRightImage = null;
            btndiscord.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btndiscord.OnPressedState.BorderRadius = 1;
            btndiscord.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btndiscord.OnPressedState.BorderThickness = 1;
            btndiscord.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btndiscord.OnPressedState.ForeColor = Color.White;
            btndiscord.OnPressedState.IconLeftImage = null;
            btndiscord.OnPressedState.IconRightImage = null;
            btndiscord.Size = new Size(43, 40);
            btndiscord.TabIndex = 10;
            btndiscord.TextAlign = ContentAlignment.MiddleCenter;
            btndiscord.TextAlignment = HorizontalAlignment.Center;
            btndiscord.TextMarginLeft = 0;
            btndiscord.TextPadding = new Padding(0);
            btndiscord.UseDefaultRadiusAndThickness = true;
            btndiscord.Click += btndiscord_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(240, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 504);
            panel3.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatus.Location = new Point(297, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(275, 21);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Автоматический поиск файлов";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(281, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1084, 561);
            Controls.Add(pnlContainer2);
            Controls.Add(pnlContainer);
            Controls.Add(pictureBox2);
            Controls.Add(lblStatus);
            Controls.Add(btndiscord);
            Controls.Add(btnhide);
            Controls.Add(btncross);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
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
            PerformLayout();
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
       
        private Panel pnlContainer;
        private Panel pnlContainer2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btncross;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnhide;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btndiscord;
        private Panel panel3;
        private Label lblStatus;
        private PictureBox pictureBox2;
    }
}
