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

        }
    }
}
