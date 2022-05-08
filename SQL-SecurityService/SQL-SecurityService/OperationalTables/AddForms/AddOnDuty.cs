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
                //string sqlExpression = "UPDATE Guards SET FIO = @f, WorkExperience = @ff, Category = @fff, СhiefID = @ffff WHERE GuardID = @id";

                //SqlParameter Param;
                //command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                //Param = new SqlParameter("@f", textBox1.Text);
                //command.Parameters.Add(Param);
                //Param = new SqlParameter("@ff", textBox2.Text);
                //command.Parameters.Add(Param);
                //Param = new SqlParameter("@fff", textBox3.Text);
                //command.Parameters.Add(Param);
                //Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                //command.Parameters.Add(Param);
                //Param = new SqlParameter("@id", GuardID.ToString());
                //command.Parameters.Add(Param);
                //command.ExecuteNonQuery();
            }
            else
            {
                string sqlExpression = "INSERT INTO OnDuty (ExitTime, GuardID, СhiefID, PostId)" +
                                        "VALUES (@f, @ff, @fff, @ffff)";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", DateTime.Parse(textBox1.Text));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", Int32.Parse(comboBox2.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox3.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
