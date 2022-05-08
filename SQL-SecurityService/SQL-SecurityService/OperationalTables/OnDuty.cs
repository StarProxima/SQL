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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);

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

        }
    }
}
