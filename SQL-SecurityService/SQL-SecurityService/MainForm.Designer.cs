namespace SQL_SecurityService
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.sQLSecurityServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter();
            this.guardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сhiefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLSecurityServiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guardIDDataGridViewTextBoxColumn,
            this.сhiefIDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.workExperienceDataGridViewTextBoxColumn,
            this.сategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guardsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 407);
            this.dataGridView1.TabIndex = 1;
            // 
            // sQL_SecurityServiceDataSet
            // 
            this.sQL_SecurityServiceDataSet.DataSetName = "SQL_SecurityServiceDataSet";
            this.sQL_SecurityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLSecurityServiceDataSetBindingSource
            // 
            this.sQLSecurityServiceDataSetBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            this.sQLSecurityServiceDataSetBindingSource.Position = 0;
            // 
            // guardsBindingSource
            // 
            this.guardsBindingSource.DataMember = "Guards";
            this.guardsBindingSource.DataSource = this.sQLSecurityServiceDataSetBindingSource;
            // 
            // guardsTableAdapter
            // 
            this.guardsTableAdapter.ClearBeforeFill = true;
            // 
            // guardIDDataGridViewTextBoxColumn
            // 
            this.guardIDDataGridViewTextBoxColumn.DataPropertyName = "GuardID";
            this.guardIDDataGridViewTextBoxColumn.HeaderText = "GuardID";
            this.guardIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardIDDataGridViewTextBoxColumn.Name = "guardIDDataGridViewTextBoxColumn";
            this.guardIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.guardIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // сhiefIDDataGridViewTextBoxColumn
            // 
            this.сhiefIDDataGridViewTextBoxColumn.DataPropertyName = "СhiefID";
            this.сhiefIDDataGridViewTextBoxColumn.HeaderText = "СhiefID";
            this.сhiefIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сhiefIDDataGridViewTextBoxColumn.Name = "сhiefIDDataGridViewTextBoxColumn";
            this.сhiefIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // workExperienceDataGridViewTextBoxColumn
            // 
            this.workExperienceDataGridViewTextBoxColumn.DataPropertyName = "WorkExperience";
            this.workExperienceDataGridViewTextBoxColumn.HeaderText = "WorkExperience";
            this.workExperienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workExperienceDataGridViewTextBoxColumn.Name = "workExperienceDataGridViewTextBoxColumn";
            this.workExperienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // сategoryDataGridViewTextBoxColumn
            // 
            this.сategoryDataGridViewTextBoxColumn.DataPropertyName = "Сategory";
            this.сategoryDataGridViewTextBoxColumn.HeaderText = "Сategory";
            this.сategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сategoryDataGridViewTextBoxColumn.Name = "сategoryDataGridViewTextBoxColumn";
            this.сategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SQL_SecurityService";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLSecurityServiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sQLSecurityServiceDataSetBindingSource;
        private SQL_SecurityServiceDataSet sQL_SecurityServiceDataSet;
        private System.Windows.Forms.BindingSource guardsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter guardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сhiefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сategoryDataGridViewTextBoxColumn;
    }
}

