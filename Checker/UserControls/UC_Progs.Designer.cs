namespace Checker.UserControls
{
    partial class UC_Progs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Progs));
            btnLastActiv = new Button();
            btnLastDoc = new Button();
            btnUAView = new Button();
            btnHistUsb = new Button();
            btnFoldActiv = new Button();
            btnHistDown = new Button();
            SuspendLayout();
            // 
            // btnLastActiv
            // 
            btnLastActiv.AutoSize = true;
            btnLastActiv.BackColor = Color.FromArgb(252, 100, 99);
            btnLastActiv.FlatAppearance.BorderSize = 0;
            btnLastActiv.FlatStyle = FlatStyle.Flat;
            btnLastActiv.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLastActiv.ForeColor = Color.White;
            btnLastActiv.Image = (Image)resources.GetObject("btnLastActiv.Image");
            btnLastActiv.ImageAlign = ContentAlignment.MiddleLeft;
            btnLastActiv.Location = new Point(62, 22);
            btnLastActiv.Name = "btnLastActiv";
            btnLastActiv.Size = new Size(273, 43);
            btnLastActiv.TabIndex = 18;
            btnLastActiv.Text = "   #1   Последняя активность";
            btnLastActiv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLastActiv.UseVisualStyleBackColor = false;
            btnLastActiv.Click += btnLastActiv_Click;
            // 
            // btnLastDoc
            // 
            btnLastDoc.AutoSize = true;
            btnLastDoc.BackColor = Color.FromArgb(252, 100, 99);
            btnLastDoc.FlatAppearance.BorderSize = 0;
            btnLastDoc.FlatStyle = FlatStyle.Flat;
            btnLastDoc.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLastDoc.ForeColor = Color.White;
            btnLastDoc.Image = (Image)resources.GetObject("btnLastDoc.Image");
            btnLastDoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnLastDoc.Location = new Point(62, 93);
            btnLastDoc.Name = "btnLastDoc";
            btnLastDoc.Size = new Size(274, 43);
            btnLastDoc.TabIndex = 18;
            btnLastDoc.Text = "   #2   Последние Документы";
            btnLastDoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLastDoc.UseVisualStyleBackColor = false;
            btnLastDoc.Click += btnLastDoc_Click;
            // 
            // btnUAView
            // 
            btnUAView.AutoSize = true;
            btnUAView.BackColor = Color.FromArgb(252, 100, 99);
            btnUAView.FlatAppearance.BorderSize = 0;
            btnUAView.FlatStyle = FlatStyle.Flat;
            btnUAView.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnUAView.ForeColor = Color.White;
            btnUAView.Image = (Image)resources.GetObject("btnUAView.Image");
            btnUAView.ImageAlign = ContentAlignment.MiddleLeft;
            btnUAView.Location = new Point(61, 164);
            btnUAView.Name = "btnUAView";
            btnUAView.Size = new Size(275, 43);
            btnUAView.TabIndex = 18;
            btnUAView.Text = "   #3   UserAssistView";
            btnUAView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUAView.UseVisualStyleBackColor = false;
            btnUAView.Click += btnUAView_Click;
            // 
            // btnHistUsb
            // 
            btnHistUsb.AutoSize = true;
            btnHistUsb.BackColor = Color.FromArgb(252, 100, 99);
            btnHistUsb.FlatAppearance.BorderSize = 0;
            btnHistUsb.FlatStyle = FlatStyle.Flat;
            btnHistUsb.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnHistUsb.ForeColor = Color.White;
            btnHistUsb.Image = (Image)resources.GetObject("btnHistUsb.Image");
            btnHistUsb.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistUsb.Location = new Point(411, 22);
            btnHistUsb.Name = "btnHistUsb";
            btnHistUsb.Size = new Size(253, 43);
            btnHistUsb.TabIndex = 18;
            btnHistUsb.Text = "   #4   История устройств";
            btnHistUsb.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistUsb.UseVisualStyleBackColor = false;
            btnHistUsb.Click += btnHistUsb_Click;
            // 
            // btnFoldActiv
            // 
            btnFoldActiv.AutoSize = true;
            btnFoldActiv.BackColor = Color.FromArgb(252, 100, 99);
            btnFoldActiv.FlatAppearance.BorderSize = 0;
            btnFoldActiv.FlatStyle = FlatStyle.Flat;
            btnFoldActiv.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnFoldActiv.ForeColor = Color.White;
            btnFoldActiv.Image = (Image)resources.GetObject("btnFoldActiv.Image");
            btnFoldActiv.ImageAlign = ContentAlignment.MiddleLeft;
            btnFoldActiv.Location = new Point(411, 93);
            btnFoldActiv.Name = "btnFoldActiv";
            btnFoldActiv.Size = new Size(253, 43);
            btnFoldActiv.TabIndex = 18;
            btnFoldActiv.Text = "   #5   Активность в папках";
            btnFoldActiv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFoldActiv.UseVisualStyleBackColor = false;
            btnFoldActiv.Click += btnFoldActiv_Click;
            // 
            // btnHistDown
            // 
            btnHistDown.AutoSize = true;
            btnHistDown.BackColor = Color.FromArgb(252, 100, 99);
            btnHistDown.FlatAppearance.BorderSize = 0;
            btnHistDown.FlatStyle = FlatStyle.Flat;
            btnHistDown.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnHistDown.ForeColor = Color.White;
            btnHistDown.Image = (Image)resources.GetObject("btnHistDown.Image");
            btnHistDown.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistDown.Location = new Point(411, 164);
            btnHistDown.Name = "btnHistDown";
            btnHistDown.Size = new Size(253, 43);
            btnHistDown.TabIndex = 18;
            btnHistDown.Text = "   #6   История загрузок";
            btnHistDown.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistDown.UseVisualStyleBackColor = false;
            btnHistDown.Click += btnHistDown_Click;
            // 
            // UC_Progs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHistDown);
            Controls.Add(btnFoldActiv);
            Controls.Add(btnHistUsb);
            Controls.Add(btnUAView);
            Controls.Add(btnLastDoc);
            Controls.Add(btnLastActiv);
            Name = "UC_Progs";
            Size = new Size(730, 230);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLastActiv;
        private Button btnLastDoc;
        private Button btnUAView;
        private Button btnHistUsb;
        private Button btnFoldActiv;
        private Button btnHistDown;
    }
}
