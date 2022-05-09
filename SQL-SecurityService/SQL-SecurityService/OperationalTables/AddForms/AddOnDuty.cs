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
        string GuardID;
        string ChiefID; 
        string PostId; 
        string ExitTime;
        public AddOnDuty(string OnDutyID, string ExitTime, string GuardID, string ChiefID, string PostId)
        {
            InitializeComponent();
            this.OnDutyID = OnDutyID;
            this.GuardID = GuardID;
            this.ChiefID = ChiefID;
            this.PostId = PostId;
            this.ExitTime = ExitTime;
        }

        private void AddOnDuty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);

            try
            {
                if (GuardID != null && ChiefID != null && PostId != null && ExitTime != null)
                {
                    textBox1.Text = ExitTime;
                    comboBox2.SelectedValue = GuardID;
                    comboBox3.SelectedValue = ChiefID;
                    comboBox1.SelectedValue = PostId;
                    Console.WriteLine("-----");
                    Console.WriteLine(GuardID);
                    Console.WriteLine(ChiefID);
                    Console.WriteLine(PostId);
                }
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime n;
            if (!DateTime.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введены некорректыне данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCommand command;
            //if (FIO != null && WorkExperience != null && Category != null)
            if (OnDutyID != null)
            {
                string sqlExpression = "UPDATE OnDuty SET ExitTime = @f, GuardID = @ff, СhiefID = @fff, PostId = @ffff WHERE OnDutyID = @id";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", DateTime.Parse(textBox1.Text));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", Int32.Parse(comboBox2.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", Int32.Parse(comboBox3.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@id", OnDutyID);
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }
            else
            {
                string sqlExpression = "INSERT INTO OnDuty (ExitTime, GuardID, СhiefID, PostId)" +
                                        "VALUES (@f, @ff, @fff, @ffff)";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", DateTime.Parse(textBox1.Text));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", Int32.Parse(comboBox2.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", Int32.Parse(comboBox3.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
