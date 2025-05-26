namespace Checker.UserControls
{
    partial class UC_overlay
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
            btnPoisk = new Button();
            SuspendLayout();
            // 
            // btnPoisk
            // 
            btnPoisk.AutoSize = true;
            btnPoisk.BackColor = Color.FromArgb(252, 100, 99);
            btnPoisk.FlatAppearance.BorderSize = 0;
            btnPoisk.FlatStyle = FlatStyle.Flat;
            btnPoisk.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnPoisk.ForeColor = Color.White;
            btnPoisk.Location = new Point(311, 185);
            btnPoisk.Name = "btnPoisk";
            btnPoisk.Size = new Size(189, 30);
            btnPoisk.TabIndex = 20;
            btnPoisk.Text = "Поиск файлов";
            btnPoisk.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPoisk.UseVisualStyleBackColor = false;
            btnPoisk.Click += btnPoisk_Click;
            // 
            // UC_overlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.HD_wallpaper_windowskali_2d_mastrmarco_hydra_windows_kali_linux_linux;
            Controls.Add(btnPoisk);
            Name = "UC_overlay";
            Size = new Size(810, 400);
            Load += UC_overlay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPoisk;
    }
}
