namespace Checker.UserControls
{
    partial class UC_Extra2
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
            btnOFcs2 = new Button();
            SuspendLayout();
            // 
            // btnOFcs2
            // 
            btnOFcs2.AutoSize = true;
            btnOFcs2.BackColor = Color.FromArgb(252, 100, 99);
            btnOFcs2.FlatAppearance.BorderSize = 0;
            btnOFcs2.FlatStyle = FlatStyle.Flat;
            btnOFcs2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnOFcs2.ForeColor = Color.White;
            btnOFcs2.Location = new Point(19, 49);
            btnOFcs2.Name = "btnOFcs2";
            btnOFcs2.Size = new Size(163, 43);
            btnOFcs2.TabIndex = 26;
            btnOFcs2.Text = "Open Folder CS2";
            btnOFcs2.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOFcs2.UseVisualStyleBackColor = false;
            btnOFcs2.Click += btnOFcs2_Click;
            // 
            // UC_Extra2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOFcs2);
            Name = "UC_Extra2";
            Size = new Size(210, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOFcs2;
    }
}
