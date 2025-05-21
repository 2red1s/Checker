namespace Checker.UserControls
{
    partial class UC_FindFiles2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FindFiles2));
            btnReport = new Button();
            btnStopfind = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.AutoSize = true;
            btnReport.BackColor = Color.FromArgb(252, 100, 99);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.Location = new Point(49, 20);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(52, 52);
            btnReport.TabIndex = 18;
            btnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnStopfind
            // 
            btnStopfind.AutoSize = true;
            btnStopfind.BackColor = Color.FromArgb(252, 100, 99);
            btnStopfind.FlatAppearance.BorderSize = 0;
            btnStopfind.FlatStyle = FlatStyle.Flat;
            btnStopfind.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnStopfind.ForeColor = Color.White;
            btnStopfind.Image = (Image)resources.GetObject("btnStopfind.Image");
            btnStopfind.Location = new Point(163, 20);
            btnStopfind.Name = "btnStopfind";
            btnStopfind.Size = new Size(52, 52);
            btnStopfind.TabIndex = 18;
            btnStopfind.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStopfind.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(252, 100, 99);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(550, 20);
            button2.Name = "button2";
            button2.Size = new Size(252, 52);
            button2.TabIndex = 18;
            button2.Text = "   Найдено файлов:";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 100, 99);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(404, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 22);
            label1.TabIndex = 19;
            label1.Text = "label1";
            // 
            // UC_FindFiles2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnStopfind);
            Controls.Add(btnReport);
            Name = "UC_FindFiles2";
            Size = new Size(810, 93);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReport;
        private Button btnStopfind;
        private Button button2;
        private Label label1;
    }
}
