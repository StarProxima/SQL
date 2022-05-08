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
    public partial class Guards : Form
    {
        public Guards()
        {
            InitializeComponent();
        }

        private void Guards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Guards_view". При необходимости она может быть перемещена или удалена.
            this.guards_viewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Guards_view);

        }
    }
}
