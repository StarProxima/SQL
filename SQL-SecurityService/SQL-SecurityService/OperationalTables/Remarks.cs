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
    public partial class Remarks : Form
    {
        public Remarks()
        {
            InitializeComponent();
        }

        private void Remarks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddRemarks addRemarks = new AddRemarks(null, null, null, null, null);
            addRemarks.ShowDialog();
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
        }

        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string OnDutyID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string sqlExpression = "SELECT GuardID FROM Remarks WHERE RemarksID = " + OnDutyID;
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string GuardID = command.ExecuteScalar().ToString();

            sqlExpression = "SELECT СhiefID FROM Remarks WHERE RemarksID = " + OnDutyID;
            command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string ChiefID = command.ExecuteScalar().ToString();

            sqlExpression = "SELECT PostID FROM Remarks WHERE RemarksID = " + OnDutyID;
            command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            string PostID = command.ExecuteScalar().ToString();

            AddRemarks addRemarks = new AddRemarks(OnDutyID, dataGridView1.CurrentRow.Cells[1].Value.ToString(), GuardID, ChiefID, PostID);
            addRemarks.ShowDialog();
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string sqlExpression = "DELETE FROM Remarks WHERE RemarksID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            command.ExecuteNonQuery();
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        SqlDataAdapter dataAdapter = null;
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM Remarks_View inner join Remarks on Remarks_View.RemarkID = Remarks.RemarkID inner join Guards on Remarks.GuardID = Guards.GuardID " +
                "inner join Сhiefs on Remarks.СhiefID = Сhiefs.СhiefID inner join Posts on Remarks.PostID = Posts.PostID  WHERE Remarks.GuardID = " +
                comboBox1.SelectedValue + " AND Remarks.СhiefID = " + comboBox2.SelectedValue + " AND Remarks.PostID = " + comboBox3.SelectedValue, Program.MainForm.connect);
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
                if (b)
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
