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
    public partial class AddGuards : Form
    {
        string GuardID;
        //string FIO;
        //string WorkExperience;
        //string Category;
        //string ChiefID;
        public AddGuards(string GuardID, string FIO, string WorkExperience, string Category, string ChiefID)
        {
            InitializeComponent();
            this.GuardID = GuardID;
            //this.FIO = FIO;
            //this.WorkExperience = WorkExperience;
            //this.Category = Category;
            //this.ChiefID = ChiefID;
             
            try
            {
                if(FIO != null && WorkExperience != null && Category != null)
                {
                    textBox1.Text = FIO;
                    textBox2.Text = WorkExperience;
                    textBox3.Text = Category;
                    comboBox1.SelectedValue = ChiefID;
                }
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0 || textBox2.Text.Length <= 0 || textBox2.Text.Length <= 0 || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int n;
            if(!Int32.TryParse(textBox2.Text, out n) || !Int32.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введены некорректыне данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCommand command;
            //if (FIO != null && WorkExperience != null && Category != null)
            if(GuardID != null)
            {
                string sqlExpression = "UPDATE Guards SET FIO = @f, WorkExperience = @ff, Category = @fff, СhiefID = @ffff WHERE GuardID = @id";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", textBox1.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", textBox2.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", textBox3.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@id", GuardID.ToString());
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }
            else
            {
                string sqlExpression = "INSERT INTO Guards (FIO, WorkExperience, Category, СhiefID)" +
                                        "VALUES (@f, @ff, @fff, @ffff)";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
             
                Param = new SqlParameter("@f", textBox1.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", textBox2.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", textBox3.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }
            
            this.Close();
        }

        private void AddGuards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }
    }
}
