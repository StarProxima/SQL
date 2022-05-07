namespace SQL_SecurityService
{
    partial class Chiefs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.sQLSecurityServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сhiefsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сhiefsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter();
            this.сhiefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLSecurityServiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сhiefIDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.workExperienceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сhiefsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 410);
            this.dataGridView1.TabIndex = 0;
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
            // сhiefsBindingSource
            // 
            this.сhiefsBindingSource.DataMember = "Сhiefs";
            this.сhiefsBindingSource.DataSource = this.sQLSecurityServiceDataSetBindingSource;
            // 
            // сhiefsTableAdapter
            // 
            this.сhiefsTableAdapter.ClearBeforeFill = true;
            // 
            // сhiefIDDataGridViewTextBoxColumn
            // 
            this.сhiefIDDataGridViewTextBoxColumn.DataPropertyName = "СhiefID";
            this.сhiefIDDataGridViewTextBoxColumn.HeaderText = "СhiefID";
            this.сhiefIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сhiefIDDataGridViewTextBoxColumn.Name = "сhiefIDDataGridViewTextBoxColumn";
            this.сhiefIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Chiefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chiefs";
            this.Text = "Chiefs";
            this.Load += new System.EventHandler(this.Chiefs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLSecurityServiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sQLSecurityServiceDataSetBindingSource;
        private SQL_SecurityServiceDataSet sQL_SecurityServiceDataSet;
        private System.Windows.Forms.BindingSource сhiefsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter сhiefsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn сhiefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workExperienceDataGridViewTextBoxColumn;
    }
}