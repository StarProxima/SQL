﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_SecurityService
{
    public partial class Guards : Form
    {
        public Guards()
        {
            InitializeComponent();
        }

        private void Guards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards_view". При необходимости она может быть перемещена или удалена.
            this.guards_viewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards_view);

        }
        SqlDataAdapter dataAdapter = null;
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM Guards_View", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGuards addGuards = new AddGuards(null, null, null, null);
            DialogResult d = addGuards.ShowDialog();
            guards_viewTableAdapter.Fill(sQL_SecurityServiceDataSet.Guards_view);
            
        }
    }
}
