namespace Checker.UserControls
{
    partial class UC_Web2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Web2));
            btnBrowsers = new Button();
            lblBrowser = new Bunifu.UI.WinForms.BunifuLabel();
            lbldefBrowser = new Bunifu.UI.WinForms.BunifuLabel();
            gridBrowsers = new DataGridView();
            picdefBrowser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridBrowsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picdefBrowser).BeginInit();
            SuspendLayout();
            // 
            // btnBrowsers
            // 
            btnBrowsers.AutoSize = true;
            btnBrowsers.BackColor = Color.FromArgb(252, 100, 99);
            btnBrowsers.FlatAppearance.BorderSize = 0;
            btnBrowsers.FlatStyle = FlatStyle.Flat;
            btnBrowsers.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnBrowsers.ForeColor = Color.White;
            btnBrowsers.Location = new Point(16, 32);
            btnBrowsers.Name = "btnBrowsers";
            btnBrowsers.Size = new Size(178, 43);
            btnBrowsers.TabIndex = 17;
            btnBrowsers.Text = "Installed Browsers";
            btnBrowsers.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBrowsers.UseVisualStyleBackColor = false;
            btnBrowsers.Click += btnBrowsers_Click;
            // 
            // lblBrowser
            // 
            lblBrowser.AllowParentOverrides = false;
            lblBrowser.AutoEllipsis = false;
            lblBrowser.CursorType = Cursors.Default;
            lblBrowser.Font = new Font("Segoe UI", 9F);
            lblBrowser.Location = new Point(16, 299);
            lblBrowser.Name = "lblBrowser";
            lblBrowser.RightToLeft = RightToLeft.No;
            lblBrowser.Size = new Size(83, 15);
            lblBrowser.TabIndex = 18;
            lblBrowser.Text = "Default Browser";
            lblBrowser.TextAlignment = ContentAlignment.TopLeft;
            lblBrowser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbldefBrowser
            // 
            lbldefBrowser.AllowParentOverrides = false;
            lbldefBrowser.AutoEllipsis = false;
            lbldefBrowser.CursorType = Cursors.Default;
            lbldefBrowser.Font = new Font("Segoe UI", 9F);
            lbldefBrowser.Location = new Point(54, 340);
            lbldefBrowser.Name = "lbldefBrowser";
            lbldefBrowser.RightToLeft = RightToLeft.No;
            lbldefBrowser.Size = new Size(83, 15);
            lbldefBrowser.TabIndex = 18;
            lbldefBrowser.Text = "Default Browser";
            lbldefBrowser.TextAlignment = ContentAlignment.TopLeft;
            lbldefBrowser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            lbldefBrowser.Click += lbldefBrowser_Click;
            // 
            // gridBrowsers
            // 
            gridBrowsers.AllowUserToResizeColumns = false;
            gridBrowsers.AllowUserToResizeRows = false;
            gridBrowsers.BackgroundColor = Color.IndianRed;
            gridBrowsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBrowsers.Location = new Point(5, 109);
            gridBrowsers.Name = "gridBrowsers";
            gridBrowsers.RowHeadersVisible = false;
            gridBrowsers.ScrollBars = ScrollBars.Vertical;
            gridBrowsers.Size = new Size(200, 120);
            gridBrowsers.TabIndex = 20;
            // 
            // picdefBrowser
            // 
            picdefBrowser.Location = new Point(16, 331);
            picdefBrowser.Name = "picdefBrowser";
            picdefBrowser.Size = new Size(32, 32);
            picdefBrowser.SizeMode = PictureBoxSizeMode.Zoom;
            picdefBrowser.TabIndex = 21;
            picdefBrowser.TabStop = false;
            // 
            // UC_Web2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picdefBrowser);
            Controls.Add(gridBrowsers);
            Controls.Add(lbldefBrowser);
            Controls.Add(lblBrowser);
            Controls.Add(btnBrowsers);
            Name = "UC_Web2";
            Size = new Size(210, 400);
            Load += UC_Web2_Load;
            ((System.ComponentModel.ISupportInitialize)gridBrowsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picdefBrowser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowsers;
        private Button button1;
        private Bunifu.UI.WinForms.BunifuLabel lblBrowser;
        private Bunifu.UI.WinForms.BunifuLabel lbldefBrowser;
        private DataGridView gridBrowsers;
        private PictureBox picdefBrowser;
    }
}
