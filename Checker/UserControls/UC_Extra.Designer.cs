namespace Checker.UserControls
{
    partial class UC_Extra
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
            btnUser = new Button();
            btnCrDp = new Button();
            btnPrfiles = new Button();
            btnDwn = new Button();
            btnTemp = new Button();
            btnLocal = new Button();
            btnDoc = new Button();
            btnPrDt = new Button();
            btnRoaming = new Button();
            btnAllFl = new Button();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.AutoSize = true;
            btnUser.BackColor = Color.FromArgb(252, 100, 99);
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(35, 217);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(142, 43);
            btnUser.TabIndex = 16;
            btnUser.Text = "User";
            btnUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnCrDp
            // 
            btnCrDp.AutoSize = true;
            btnCrDp.BackColor = Color.FromArgb(252, 100, 99);
            btnCrDp.FlatAppearance.BorderSize = 0;
            btnCrDp.FlatStyle = FlatStyle.Flat;
            btnCrDp.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnCrDp.ForeColor = Color.White;
            btnCrDp.Location = new Point(394, 217);
            btnCrDp.Name = "btnCrDp";
            btnCrDp.Size = new Size(142, 43);
            btnCrDp.TabIndex = 17;
            btnCrDp.Text = "Crash Dumps";
            btnCrDp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCrDp.UseVisualStyleBackColor = false;
            btnCrDp.Click += btnCrDp_Click;
            // 
            // btnPrfiles
            // 
            btnPrfiles.AutoSize = true;
            btnPrfiles.BackColor = Color.FromArgb(252, 100, 99);
            btnPrfiles.FlatAppearance.BorderSize = 0;
            btnPrfiles.FlatStyle = FlatStyle.Flat;
            btnPrfiles.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnPrfiles.ForeColor = Color.White;
            btnPrfiles.Location = new Point(216, 217);
            btnPrfiles.Name = "btnPrfiles";
            btnPrfiles.Size = new Size(142, 43);
            btnPrfiles.TabIndex = 18;
            btnPrfiles.Text = "Program Files";
            btnPrfiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrfiles.UseVisualStyleBackColor = false;
            btnPrfiles.Click += btnPrfiles_Click;
            // 
            // btnDwn
            // 
            btnDwn.AutoSize = true;
            btnDwn.BackColor = Color.FromArgb(252, 100, 99);
            btnDwn.FlatAppearance.BorderSize = 0;
            btnDwn.FlatStyle = FlatStyle.Flat;
            btnDwn.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnDwn.ForeColor = Color.White;
            btnDwn.Location = new Point(394, 136);
            btnDwn.Name = "btnDwn";
            btnDwn.Size = new Size(142, 43);
            btnDwn.TabIndex = 19;
            btnDwn.Text = "Downloads";
            btnDwn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDwn.UseVisualStyleBackColor = false;
            btnDwn.Click += btnDwn_Click;
            // 
            // btnTemp
            // 
            btnTemp.AutoSize = true;
            btnTemp.BackColor = Color.FromArgb(252, 100, 99);
            btnTemp.FlatAppearance.BorderSize = 0;
            btnTemp.FlatStyle = FlatStyle.Flat;
            btnTemp.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnTemp.ForeColor = Color.White;
            btnTemp.Location = new Point(216, 53);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new Size(142, 43);
            btnTemp.TabIndex = 20;
            btnTemp.Text = "Temp";
            btnTemp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTemp.UseVisualStyleBackColor = false;
            btnTemp.Click += btnTemp_Click;
            // 
            // btnLocal
            // 
            btnLocal.AutoSize = true;
            btnLocal.BackColor = Color.FromArgb(252, 100, 99);
            btnLocal.FlatAppearance.BorderSize = 0;
            btnLocal.FlatStyle = FlatStyle.Flat;
            btnLocal.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLocal.ForeColor = Color.White;
            btnLocal.Location = new Point(35, 136);
            btnLocal.Name = "btnLocal";
            btnLocal.Size = new Size(142, 43);
            btnLocal.TabIndex = 21;
            btnLocal.Text = "Local";
            btnLocal.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLocal.UseVisualStyleBackColor = false;
            btnLocal.Click += btnLocal_Click;
            // 
            // btnDoc
            // 
            btnDoc.AutoSize = true;
            btnDoc.BackColor = Color.FromArgb(252, 100, 99);
            btnDoc.FlatAppearance.BorderSize = 0;
            btnDoc.FlatStyle = FlatStyle.Flat;
            btnDoc.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnDoc.ForeColor = Color.White;
            btnDoc.Location = new Point(394, 53);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(142, 43);
            btnDoc.TabIndex = 22;
            btnDoc.Text = "Documents";
            btnDoc.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnPrDt
            // 
            btnPrDt.AutoSize = true;
            btnPrDt.BackColor = Color.FromArgb(252, 100, 99);
            btnPrDt.FlatAppearance.BorderSize = 0;
            btnPrDt.FlatStyle = FlatStyle.Flat;
            btnPrDt.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnPrDt.ForeColor = Color.White;
            btnPrDt.Location = new Point(216, 136);
            btnPrDt.Name = "btnPrDt";
            btnPrDt.Size = new Size(142, 43);
            btnPrDt.TabIndex = 23;
            btnPrDt.Text = "ProgramData";
            btnPrDt.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrDt.UseVisualStyleBackColor = false;
            btnPrDt.Click += btnPrDt_Click;
            // 
            // btnRoaming
            // 
            btnRoaming.AutoSize = true;
            btnRoaming.BackColor = Color.FromArgb(252, 100, 99);
            btnRoaming.FlatAppearance.BorderSize = 0;
            btnRoaming.FlatStyle = FlatStyle.Flat;
            btnRoaming.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnRoaming.ForeColor = Color.White;
            btnRoaming.Location = new Point(35, 53);
            btnRoaming.Name = "btnRoaming";
            btnRoaming.Size = new Size(142, 43);
            btnRoaming.TabIndex = 24;
            btnRoaming.Text = "Roaming";
            btnRoaming.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRoaming.UseVisualStyleBackColor = false;
            btnRoaming.Click += btnRoaming_Click;
            // 
            // btnAllFl
            // 
            btnAllFl.AutoSize = true;
            btnAllFl.BackColor = Color.FromArgb(252, 100, 99);
            btnAllFl.FlatAppearance.BorderSize = 0;
            btnAllFl.FlatStyle = FlatStyle.Flat;
            btnAllFl.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnAllFl.ForeColor = Color.White;
            btnAllFl.Location = new Point(162, 305);
            btnAllFl.Name = "btnAllFl";
            btnAllFl.Size = new Size(242, 43);
            btnAllFl.TabIndex = 25;
            btnAllFl.Text = "Open All Folder";
            btnAllFl.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAllFl.UseVisualStyleBackColor = false;
            btnAllFl.Click += btnAllFl_Click;
            // 
            // UC_Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUser);
            Controls.Add(btnCrDp);
            Controls.Add(btnPrfiles);
            Controls.Add(btnDwn);
            Controls.Add(btnTemp);
            Controls.Add(btnLocal);
            Controls.Add(btnDoc);
            Controls.Add(btnPrDt);
            Controls.Add(btnRoaming);
            Controls.Add(btnAllFl);
            Name = "UC_Extra";
            Size = new Size(570, 400);
            Load += UC_Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUser;
        private Button btnCrDp;
        private Button btnPrfiles;
        private Button btnDwn;
        private Button btnTemp;
        private Button btnLocal;
        private Button btnDoc;
        private Button btnPrDt;
        private Button btnRoaming;
        private Button btnAllFl;
    }
}
