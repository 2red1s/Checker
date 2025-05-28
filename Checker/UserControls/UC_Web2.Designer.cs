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
            picdefBrowser = new PictureBox();
            pnlLine = new Panel();
            pnlliner = new Panel();
            lbldefBrowser = new Label();
            gridBrowsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picdefBrowser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBrowsers).BeginInit();
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
            lblBrowser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lblBrowser.ForeColor = Color.White;
            lblBrowser.Location = new Point(16, 276);
            lblBrowser.Name = "lblBrowser";
            lblBrowser.RightToLeft = RightToLeft.No;
            lblBrowser.Size = new Size(122, 21);
            lblBrowser.TabIndex = 18;
            lblBrowser.Text = "Default Browser";
            lblBrowser.TextAlignment = ContentAlignment.TopLeft;
            lblBrowser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picdefBrowser
            // 
            picdefBrowser.BackColor = Color.Transparent;
            picdefBrowser.Location = new Point(16, 331);
            picdefBrowser.Name = "picdefBrowser";
            picdefBrowser.Size = new Size(32, 32);
            picdefBrowser.SizeMode = PictureBoxSizeMode.Zoom;
            picdefBrowser.TabIndex = 21;
            picdefBrowser.TabStop = false;
            picdefBrowser.Click += picdefBrowser_Click;
            // 
            // pnlLine
            // 
            pnlLine.Location = new Point(5, 312);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(200, 2);
            pnlLine.TabIndex = 22;
            pnlLine.Paint += pnlLine_Paint;
            // 
            // pnlliner
            // 
            pnlliner.Location = new Point(5, 379);
            pnlliner.Name = "pnlliner";
            pnlliner.Size = new Size(200, 2);
            pnlliner.TabIndex = 23;
            pnlliner.Paint += pnlliner_Paint;
            // 
            // lbldefBrowser
            // 
            lbldefBrowser.AutoSize = true;
            lbldefBrowser.BackColor = Color.Transparent;
            lbldefBrowser.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldefBrowser.ForeColor = Color.White;
            lbldefBrowser.Location = new Point(54, 337);
            lbldefBrowser.Name = "lbldefBrowser";
            lbldefBrowser.Size = new Size(72, 20);
            lbldefBrowser.TabIndex = 24;
            lbldefBrowser.Text = "def brow";
            // 
            // gridBrowsers
            // 
            gridBrowsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBrowsers.Location = new Point(5, 111);
            gridBrowsers.Name = "gridBrowsers";
            gridBrowsers.Size = new Size(200, 120);
            gridBrowsers.TabIndex = 26;
            // 
            // UC_Web2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridBrowsers);
            Controls.Add(lbldefBrowser);
            Controls.Add(pnlliner);
            Controls.Add(pnlLine);
            Controls.Add(picdefBrowser);
            Controls.Add(lblBrowser);
            Controls.Add(btnBrowsers);
            Name = "UC_Web2";
            Size = new Size(210, 400);
            Load += UC_Web2_Load;
            ((System.ComponentModel.ISupportInitialize)picdefBrowser).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBrowsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowsers;
        private Button button1;
        private Bunifu.UI.WinForms.BunifuLabel lblBrowser;
        private PictureBox picdefBrowser;
        private Panel pnlLine;
        private Panel pnlliner;
        private Label lbldefBrowser;
        private DataGridView gridBrowsers;
    }
}
