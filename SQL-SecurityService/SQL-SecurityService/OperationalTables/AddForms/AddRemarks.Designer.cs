using System;

namespace SQL_SecurityService
{
    partial class AddRemarks
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sQL_SecurityServiceDataSet = new SQL_SecurityService.SQL_SecurityServiceDataSet();
            this.guardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter();
            this.сhiefsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сhiefsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new SQL_SecurityService.SQL_SecurityServiceDataSetTableAdapters.PostsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.сhiefsBindingSource;
            this.comboBox3.DisplayMember = "FIO";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(368, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 24);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.ValueMember = "СhiefID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.guardsBindingSource;
            this.comboBox2.DisplayMember = "FIO";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(368, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "GuardID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 29;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "PostID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ChiefID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "GuardID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Remark";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.postsBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "PostID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 22;
            // 
            // sQL_SecurityServiceDataSet
            // 
            this.sQL_SecurityServiceDataSet.DataSetName = "SQL_SecurityServiceDataSet";
            this.sQL_SecurityServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guardsBindingSource
            // 
            this.guardsBindingSource.DataMember = "Guards";
            this.guardsBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // guardsTableAdapter
            // 
            this.guardsTableAdapter.ClearBeforeFill = true;
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
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.sQL_SecurityServiceDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // AddRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddRemarks";
            this.Text = "AddRemarks";
            this.Load += new System.EventHandler(this.AddRemarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sQL_SecurityServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сhiefsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private SQL_SecurityServiceDataSet sQL_SecurityServiceDataSet;
        private System.Windows.Forms.BindingSource guardsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.GuardsTableAdapter guardsTableAdapter;
        private System.Windows.Forms.BindingSource сhiefsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.СhiefsTableAdapter сhiefsTableAdapter;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private SQL_SecurityServiceDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
    }
}