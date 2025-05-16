namespace Checker.UserControl
{
    partial class UC_Web2 : System.Windows.Forms.UserControl
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
            btnopenFolderCS = new Button();
            SuspendLayout();
            // 
            // btnopenFolderCS
            // 
            btnopenFolderCS.AutoSize = true;
            btnopenFolderCS.BackColor = Color.FromArgb(252, 100, 99);
            btnopenFolderCS.FlatAppearance.BorderSize = 0;
            btnopenFolderCS.FlatStyle = FlatStyle.Flat;
            btnopenFolderCS.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnopenFolderCS.ForeColor = Color.White;
            btnopenFolderCS.Location = new Point(32, 84);
            btnopenFolderCS.Name = "btnopenFolderCS";
            btnopenFolderCS.Size = new Size(142, 43);
            btnopenFolderCS.TabIndex = 4;
            btnopenFolderCS.Text = "Open Folder CS2";
            btnopenFolderCS.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnopenFolderCS.UseVisualStyleBackColor = false;
            // 
            // UC_Web2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnopenFolderCS);
            Name = "UC_Web2";
            Size = new Size(210, 400);
            Load += UC_Web2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnopenFolderCS;
    }
}
