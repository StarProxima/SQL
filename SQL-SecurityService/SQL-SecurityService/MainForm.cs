using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_SecurityService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public System.Data.SqlClient.SqlConnection connect;
        private void MainForm_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-GABBJA4;Initial Catalog=SQL_SecurityService;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();


            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards". При необходимости она может быть перемещена или удалена.
            this.guardsTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards);

        }
    }
}
