namespace SQL_SecurityService
{
    partial class Guards
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefWorkExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardsviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.guardsviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.сhiefsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сhiefsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter();
            this.guards_viewTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.Guards_viewTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guardIDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.workExperienceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.chiefFIODataGridViewTextBoxColumn,
            this.chiefWorkExperienceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guardsviewBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // guardIDDataGridViewTextBoxColumn
            // 
            this.guardIDDataGridViewTextBoxColumn.DataPropertyName = "GuardID";
            this.guardIDDataGridViewTextBoxColumn.HeaderText = "GuardID";
            this.guardIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardIDDataGridViewTextBoxColumn.Name = "guardIDDataGridViewTextBoxColumn";
            this.guardIDDataGridViewTextBoxColumn.Width = 125;
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
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // chiefFIODataGridViewTextBoxColumn
            // 
            this.chiefFIODataGridViewTextBoxColumn.DataPropertyName = "Chief FIO";
            this.chiefFIODataGridViewTextBoxColumn.HeaderText = "Chief FIO";
            this.chiefFIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chiefFIODataGridViewTextBoxColumn.Name = "chiefFIODataGridViewTextBoxColumn";
            this.chiefFIODataGridViewTextBoxColumn.Width = 125;
            // 
            // chiefWorkExperienceDataGridViewTextBoxColumn
            // 
            this.chiefWorkExperienceDataGridViewTextBoxColumn.DataPropertyName = "Chief WorkExperience";
            this.chiefWorkExperienceDataGridViewTextBoxColumn.HeaderText = "Chief WorkExperience";
            this.chiefWorkExperienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chiefWorkExperienceDataGridViewTextBoxColumn.Name = "chiefWorkExperienceDataGridViewTextBoxColumn";
            this.chiefWorkExperienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardsviewBindingSource1
            // 
            this.guardsviewBindingSource1.DataMember = "Guards_view";
            this.guardsviewBindingSource1.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // sQL_SecurityServiceDataSet
            // 
            this.sQL_SecurityServiceDataSet.DataSetName = "SQL_SecurityServiceDataSet";
            this.sQL_SecurityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guardsviewBindingSource
            // 
            this.guardsviewBindingSource.DataMember = "Guards_view";
            this.guardsviewBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.сhiefsBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "СhiefID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // сhiefsBindingSource
            // 
            this.сhiefsBindingSource.DataMember = "Сhiefs";
            this.сhiefsBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // сhiefsTableAdapter
            // 
            this.сhiefsTableAdapter.ClearBeforeFill = true;
            // 
            // guards_viewTableAdapter
            // 
            this.guards_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Guards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Guards";
            this.Text = "Guards";
            this.Load += new System.EventHandler(this.Guards_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_SecurityServiceDataSet sQL_SecurityServiceDataSet;
        private System.Windows.Forms.BindingSource guardsviewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefWorkExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource сhiefsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter сhiefsTableAdapter;
        private System.Windows.Forms.BindingSource guardsviewBindingSource1;
        private SQL_SecurityServiceDataSetTableAdapters.Guards_viewTableAdapter guards_viewTableAdapter;
    }
}