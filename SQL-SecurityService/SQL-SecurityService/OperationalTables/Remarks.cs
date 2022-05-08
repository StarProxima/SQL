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
    public partial class Remarks : Form
    {
        public Remarks()
        {
            InitializeComponent();
        }

        private void Remarks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);

        }
    }
}
