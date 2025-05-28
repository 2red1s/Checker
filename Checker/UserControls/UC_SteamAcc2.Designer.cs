namespace Checker.UserControls
{
    partial class UC_SteamAcc2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SteamAcc2));
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            SuspendLayout();
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.AutoScroll = true;
            bunifuPanel1.BackgroundColor = Color.Transparent;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 15;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Location = new Point(0, 0);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(455, 340);
            bunifuPanel1.TabIndex = 0;
            // 
            // UC_SteamAcc2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(bunifuPanel1);
            Name = "UC_SteamAcc2";
            Size = new Size(455, 340);
            Load += UC_SteamAcc2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}
