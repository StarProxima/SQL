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
    public partial class AddOnDuty : Form
    {
        string OnDutyID;
        public AddOnDuty(string OnDutyID, string GuardID, string ChiefID, string PostId, string ExitTime)
        {
            InitializeComponent();
            this.OnDutyID = OnDutyID;

            try
            {
                if (GuardID != null && ChiefID != null && PostId != null && ExitTime != null)
                {
                    textBox1.Text = ExitTime;
                    comboBox1.SelectedValue = GuardID;
                    comboBox2.SelectedValue = ChiefID;
                    comboBox3.SelectedValue = PostId;
                }
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }

        private void AddOnDuty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
