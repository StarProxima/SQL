using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards_view". При необходимости она может быть перемещена или удалена.
            this.guards_viewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards_view);
            comboBox1.Text = "";
        }

        SqlDataAdapter dataAdapter = null;
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM Guards_View inner join Guards on Guards_View.GuardID = Guards.GuardID WHERE Guards.СhiefID = " + comboBox1.SelectedValue, Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGuards addGuards = new AddGuards(null, null, null, null, null);
            addGuards.ShowDialog();
            guards_viewTableAdapter.Fill(sQL_SecurityServiceDataSet.Guards_view);
            
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT СhiefID FROM Guards WHERE GuardID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            

            AddGuards addGuards = new AddGuards(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                command.ExecuteScalar().ToString());
            addGuards.ShowDialog();
            guards_viewTableAdapter.Fill(sQL_SecurityServiceDataSet.Guards_view);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = "DELETE FROM Guards WHERE GuardID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            command.ExecuteNonQuery();
            guards_viewTableAdapter.Fill(sQL_SecurityServiceDataSet.Guards_view);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
                UpdateView();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }
    }
}
