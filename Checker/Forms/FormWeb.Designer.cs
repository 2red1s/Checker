namespace Checker.Forms
{
    partial class FormWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnXone = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXone);
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 353);
            panel1.TabIndex = 0;
            // 
            // btnXone
            // 
            btnXone.AutoSize = true;
            btnXone.BackColor = Color.FromArgb(252, 100, 99);
            btnXone.FlatAppearance.BorderSize = 0;
            btnXone.FlatStyle = FlatStyle.Flat;
            btnXone.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXone.ForeColor = Color.White;
            btnXone.Location = new Point(25, 163);
            btnXone.Name = "btnXone";
            btnXone.Size = new Size(142, 43);
            btnXone.TabIndex = 3;
            btnXone.Text = "XONE";
            btnXone.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnXone.UseVisualStyleBackColor = false;
            btnXone.Click += btnXone_Click;
            // 
            // FormWeb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormWeb";
            Text = "FormWeb";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnXone;
    }
}