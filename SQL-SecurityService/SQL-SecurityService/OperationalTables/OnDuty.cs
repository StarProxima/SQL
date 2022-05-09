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
    public partial class OnDuty : Form
    {
        public OnDuty()
        {
            InitializeComponent();
        }

        private void OnDuty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOnDuty addOnDuty = new AddOnDuty(null, null, null, null, null);
            addOnDuty.ShowDialog();
            onDuty_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.OnDuty_View);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string OnDutyID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string sqlExpression = "SELECT GuardID FROM OnDuty WHERE OnDutyID = " + OnDutyID;
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string GuardID = command.ExecuteScalar().ToString();

            sqlExpression = "SELECT СhiefID FROM OnDuty WHERE OnDutyID = " + OnDutyID;
            command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string ChiefID = command.ExecuteScalar().ToString();

            sqlExpression = "SELECT PostID FROM OnDuty WHERE OnDutyID = " + OnDutyID;
            command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string PostID = command.ExecuteScalar().ToString();

            AddOnDuty addOnDuty = new AddOnDuty(OnDutyID, dataGridView1.CurrentRow.Cells[1].Value.ToString(), GuardID, ChiefID, PostID);
            addOnDuty.ShowDialog();
            onDuty_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.OnDuty_View);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = "DELETE FROM OnDuty WHERE OnDutyID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            command.ExecuteNonQuery();
            onDuty_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.OnDuty_View);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }
        SqlDataAdapter dataAdapter = null;
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM OnDuty_View inner join OnDuty on OnDuty_View.OnDutyID = OnDuty.OnDutyID inner join Guards on OnDuty.GuardID = Guards.GuardID " +
                "inner join Сhiefs on OnDuty.СhiefID = Сhiefs.СhiefID inner join Posts on OnDuty.PostID = Posts.PostID  WHERE OnDuty.GuardID = " +
                comboBox1.SelectedValue + " AND OnDuty.СhiefID = " + comboBox2.SelectedValue + " AND OnDuty.PostID = " + comboBox3.SelectedValue, Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        bool b = true;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                if (b)
                {
                    comboBox2.SelectedIndex = 1;
                    comboBox3.SelectedIndex = 1;
                    b = false;
                }
                UpdateView();
            }
               
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                if (b)
                {
                    comboBox1.SelectedIndex = 1;
                    comboBox3.SelectedIndex = 1;
                    b = false;
                }
                UpdateView();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
            {
                if(b)
                {
                    comboBox2.SelectedIndex = 1;
                    comboBox1.SelectedIndex = 1;
                    b = false;
                }
                UpdateView();
            }
        }
    }
}
