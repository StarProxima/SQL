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
    public partial class AddRemarks : Form
    {
        string RemarkID;
        string GuardID;
        string ChiefID;
        string PostId;
        string Remark;
        public AddRemarks(string RemarkID, string Reamark, string GuardID, string ChiefID, string PostId)
        {
            InitializeComponent();
            this.RemarkID = RemarkID;
            this.GuardID = GuardID;
            this.ChiefID = ChiefID;
            this.PostId = PostId;
            this.Remark = Reamark;
        }

        private void AddRemarks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Posts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Сhiefs". При необходимости она может быть перемещена или удалена.
            this.сhiefsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Сhiefs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);

            try
            {
                if (GuardID != null && ChiefID != null && PostId != null && Remark != null)
                {
                    textBox1.Text = Remark;
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

            SqlCommand command;
            //if (FIO != null && WorkExperience != null && Category != null)
            if (RemarkID != null)
            {
                string sqlExpression = "UPDATE Remarks SET Remark = @f, GuardID = @ff, СhiefID = @fff, PostId = @ffff WHERE RemarkID = @id";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", textBox1.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", Int32.Parse(comboBox2.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", Int32.Parse(comboBox3.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Int32.Parse(comboBox1.SelectedValue.ToString()));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@id", RemarkID);
                command.Parameters.Add(Param);
                command.ExecuteNonQuery();
            }
            else
            {
                string sqlExpression = "INSERT INTO Remarks (Remark, GuardID, СhiefID, PostId)" +
                                        "VALUES (@f, @ff, @fff, @ffff)";

                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);

                Param = new SqlParameter("@f", textBox1.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
