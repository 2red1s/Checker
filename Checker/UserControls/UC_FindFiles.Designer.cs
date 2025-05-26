namespace Checker.UserControls
{
    partial class UC_FindFiles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gridFindFiles = new Bunifu.UI.WinForms.BunifuDataGridView();
            name = new DataGridViewTextBoxColumn();
            Typefind = new DataGridViewTextBoxColumn();
            columnSize = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridFindFiles).BeginInit();
            SuspendLayout();
            // 
            // gridFindFiles
            // 
            gridFindFiles.AllowCustomTheming = false;
            gridFindFiles.AllowUserToAddRows = false;
            gridFindFiles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            gridFindFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridFindFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridFindFiles.BorderStyle = BorderStyle.None;
            gridFindFiles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridFindFiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridFindFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridFindFiles.ColumnHeadersHeight = 40;
            gridFindFiles.Columns.AddRange(new DataGridViewColumn[] { name, Typefind, columnSize, Date });
            gridFindFiles.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            gridFindFiles.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            gridFindFiles.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            gridFindFiles.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridFindFiles.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            gridFindFiles.CurrentTheme.BackColor = Color.White;
            gridFindFiles.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            gridFindFiles.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            gridFindFiles.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            gridFindFiles.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            gridFindFiles.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            gridFindFiles.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            gridFindFiles.CurrentTheme.Name = null;
            gridFindFiles.CurrentTheme.RowsStyle.BackColor = Color.White;
            gridFindFiles.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            gridFindFiles.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            gridFindFiles.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridFindFiles.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridFindFiles.DefaultCellStyle = dataGridViewCellStyle3;
            gridFindFiles.EnableHeadersVisualStyles = false;
            gridFindFiles.GridColor = Color.FromArgb(221, 238, 255);
            gridFindFiles.HeaderBackColor = Color.DodgerBlue;
            gridFindFiles.HeaderBgColor = Color.Empty;
            gridFindFiles.HeaderForeColor = Color.White;
            gridFindFiles.Location = new Point(0, 0);
            gridFindFiles.Name = "gridFindFiles";
            gridFindFiles.ReadOnly = true;
            gridFindFiles.RowHeadersVisible = false;
            gridFindFiles.RowTemplate.Height = 40;
            gridFindFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFindFiles.Size = new Size(810, 290);
            gridFindFiles.TabIndex = 0;
            gridFindFiles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            gridFindFiles.CellContentClick += gridFindFiles_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "# Имя";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Typefind
            // 
            Typefind.HeaderText = "Тип поиска";
            Typefind.Name = "Typefind";
            Typefind.ReadOnly = true;
            // 
            // columnSize
            // 
            columnSize.HeaderText = "Размер";
            columnSize.Name = "columnSize";
            columnSize.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Дата изменения";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // UC_FindFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridFindFiles);
            Name = "UC_FindFiles";
            Size = new Size(810, 290);
            Load += UC_FindFiles_Load;
            ((System.ComponentModel.ISupportInitialize)gridFindFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gridFindFiles;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Typefind;
        private DataGridViewTextBoxColumn columnSize;
        private DataGridViewTextBoxColumn Date;
    }
}
