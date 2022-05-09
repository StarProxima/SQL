using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_SecurityService
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);

        }
    }
}
