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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void охранникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guards guards = new Guards();
            guards.Show();
        }

        private void начальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Chiefs chiefs = new Chiefs();
            chiefs.Show();
           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void постыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Posts posts = new Posts();
            posts.Show();
        }

        private void дежурстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnDuty onDuty = new OnDuty();
            onDuty.Show();
        }

        private void замечанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remarks remarks = new Remarks();
            remarks.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }

        private void журналВыходаНаДежурствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnDutyReport onDutyReport = new OnDutyReport();
            onDutyReport.Show();
        }

        private void журналУчётаЗамечанийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemarksReport remarksReport = new RemarksReport();
            remarksReport.Show();
        }
    }
}
