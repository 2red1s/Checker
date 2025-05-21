namespace Checker.UserControls
{
    partial class UC_Progs2
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
            lblInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(3, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(642, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "- Первая программа заменяет LastActivity и многие разделы реестра. Проверьте абсолютно каждую строчку в ней";
            lblInfo.Click += lblInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(664, 15);
            label1.TabIndex = 0;
            label1.Text = "- Если в 4 программе вы заметите. что человек перед проверкой отсоединил устройство. попросите его подсоеденить\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(694, 15);
            label2.TabIndex = 0;
            label2.Text = "- Если шестая программа пустая, это может указывать на то, что пользователь либо очистил все загрузки, либо использует\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(257, 15);
            label3.TabIndex = 0;
            label3.Text = "- браузер в режиме инкогнито (NN-браузер).";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 48);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 0;
            label4.Text = "- устройство обратно.";
            // 
            // UC_Progs2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblInfo);
            ForeColor = Color.Transparent;
            Name = "UC_Progs2";
            Size = new Size(730, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
