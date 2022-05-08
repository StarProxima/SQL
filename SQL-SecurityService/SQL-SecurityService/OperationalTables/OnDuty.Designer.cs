namespace SQL_SecurityService
{
    partial class OnDuty
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onDutyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardWorkExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefWorkExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onDutyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.onDuty_ViewTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.OnDuty_ViewTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onDutyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onDutyIDDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn,
            this.guardFIODataGridViewTextBoxColumn,
            this.guardWorkExperienceDataGridViewTextBoxColumn,
            this.chiefFIODataGridViewTextBoxColumn,
            this.chiefWorkExperienceDataGridViewTextBoxColumn,
            this.postNameDataGridViewTextBoxColumn,
            this.postLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.onDutyViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 2;
            // 
            // onDutyIDDataGridViewTextBoxColumn
            // 
            this.onDutyIDDataGridViewTextBoxColumn.DataPropertyName = "OnDutyID";
            this.onDutyIDDataGridViewTextBoxColumn.HeaderText = "OnDutyID";
            this.onDutyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onDutyIDDataGridViewTextBoxColumn.Name = "onDutyIDDataGridViewTextBoxColumn";
            this.onDutyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // exitTimeDataGridViewTextBoxColumn
            // 
            this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.HeaderText = "ExitTime";
            this.exitTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
            this.exitTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardFIODataGridViewTextBoxColumn
            // 
            this.guardFIODataGridViewTextBoxColumn.DataPropertyName = "Guard FIO";
            this.guardFIODataGridViewTextBoxColumn.HeaderText = "Guard FIO";
            this.guardFIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardFIODataGridViewTextBoxColumn.Name = "guardFIODataGridViewTextBoxColumn";
            this.guardFIODataGridViewTextBoxColumn.Width = 125;
            // 
            // guardWorkExperienceDataGridViewTextBoxColumn
            // 
            this.guardWorkExperienceDataGridViewTextBoxColumn.DataPropertyName = "Guard WorkExperience";
            this.guardWorkExperienceDataGridViewTextBoxColumn.HeaderText = "Guard WorkExperience";
            this.guardWorkExperienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardWorkExperienceDataGridViewTextBoxColumn.Name = "guardWorkExperienceDataGridViewTextBoxColumn";
            this.guardWorkExperienceDataGridViewTextBoxColumn.Width = 125;
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
            // postNameDataGridViewTextBoxColumn
            // 
            this.postNameDataGridViewTextBoxColumn.DataPropertyName = "Post Name";
            this.postNameDataGridViewTextBoxColumn.HeaderText = "Post Name";
            this.postNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postNameDataGridViewTextBoxColumn.Name = "postNameDataGridViewTextBoxColumn";
            this.postNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // postLocationDataGridViewTextBoxColumn
            // 
            this.postLocationDataGridViewTextBoxColumn.DataPropertyName = "Post Location";
            this.postLocationDataGridViewTextBoxColumn.HeaderText = "Post Location";
            this.postLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postLocationDataGridViewTextBoxColumn.Name = "postLocationDataGridViewTextBoxColumn";
            this.postLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // onDutyViewBindingSource
            // 
            this.onDutyViewBindingSource.DataMember = "OnDuty_View";
            this.onDutyViewBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // sQL_SecurityServiceDataSet
            // 
            this.sQL_SecurityServiceDataSet.DataSetName = "SQL_SecurityServiceDataSet";
            this.sQL_SecurityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onDuty_ViewTableAdapter
            // 
            this.onDuty_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // OnDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OnDuty";
            this.Text = "OnDuty";
            this.Load += new System.EventHandler(this.OnDuty_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onDutyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource onDutyViewBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.OnDuty_ViewTableAdapter onDuty_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn onDutyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardWorkExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefWorkExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postLocationDataGridViewTextBoxColumn;
    }
}