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
            this.охранникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дежурстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замечанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начальникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.sQLSecurityServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter();
            this.постыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.охранникиToolStripMenuItem,
            this.дежурстваToolStripMenuItem,
            this.замечанияToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.данныеToolStripMenuItem_Click);
            // 
            // охранникиToolStripMenuItem
            // 
            this.охранникиToolStripMenuItem.Name = "охранникиToolStripMenuItem";
            this.охранникиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.охранникиToolStripMenuItem.Text = "Охранники";
            this.охранникиToolStripMenuItem.Click += new System.EventHandler(this.охранникиToolStripMenuItem_Click);
            // 
            // дежурстваToolStripMenuItem
            // 
            this.дежурстваToolStripMenuItem.Name = "дежурстваToolStripMenuItem";
            this.дежурстваToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дежурстваToolStripMenuItem.Text = "Дежурства";
            // 
            // замечанияToolStripMenuItem
            // 
            this.замечанияToolStripMenuItem.Name = "замечанияToolStripMenuItem";
            this.замечанияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.замечанияToolStripMenuItem.Text = "Замечания";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начальникиToolStripMenuItem,
            this.постыToolStripMenuItem1});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // начальникиToolStripMenuItem
            // 
            this.начальникиToolStripMenuItem.Name = "начальникиToolStripMenuItem";
            this.начальникиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.начальникиToolStripMenuItem.Text = "Начальники";
            this.начальникиToolStripMenuItem.Click += new System.EventHandler(this.начальникиToolStripMenuItem_Click);
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
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
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
            // постыToolStripMenuItem1
            // 
            this.постыToolStripMenuItem1.Name = "постыToolStripMenuItem1";
            this.постыToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.постыToolStripMenuItem1.Text = "Посты";
            this.постыToolStripMenuItem1.Click += new System.EventHandler(this.постыToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SQL_SecurityService";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingSource sQLSecurityServiceDataSetBindingSource;
        private SQL_SecurityServiceDataSet sQL_SecurityServiceDataSet;
        private System.Windows.Forms.BindingSource guardsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter guardsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem охранникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дежурстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замечанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начальникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постыToolStripMenuItem1;
    }
}

