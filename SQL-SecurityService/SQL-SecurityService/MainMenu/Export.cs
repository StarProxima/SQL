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
        SaveFileDialog saveFileDialog1;

        public void ExportExcel(DataTable table)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriterStream1 = new StreamWriter(Stream1, Encoding.Unicode);

                    foreach (DataColumn Column in table.Columns)
                        StreamWriterStream1.Write(Column.Caption + "\t");

                    StreamWriterStream1.WriteLine();
                    foreach (DataRow Row in table.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWriterStream1.Write(Entity.ToString() + "\t");
                        }
                        StreamWriterStream1.WriteLine();
                    }
                    StreamWriterStream1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Stream1.Close();
                    return;
                }
                
            }
        }
        void ExportHTML(DataTable table, string ThisTitle)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriter1 = new StreamWriter(Stream1);

                    StreamWriter1.WriteLine("<html>");
                    StreamWriter1.WriteLine("<head>");
                    StreamWriter1.WriteLine("<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">");
                    StreamWriter1.WriteLine("<title>" + ThisTitle + "</title>");
                    StreamWriter1.WriteLine("</head>");
                    StreamWriter1.WriteLine("<body bgcolor=\"#888888\">");
                    StreamWriter1.WriteLine("<table align=\"center\" cols =0 cellspacing =0>");
                    StreamWriter1.WriteLine("<tr>");
                    StreamWriter1.WriteLine("</td>");
                    StreamWriter1.WriteLine("</tr>");
                    StreamWriter1.WriteLine("<tr>");
                    int i, j;
                    for (j = 0; j < table.Columns.Count; j++)
                    {
                        StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\"><b>");
                        StreamWriter1.WriteLine("" + table.Columns[j].ColumnName);
                        StreamWriter1.WriteLine("</b></font></td>");
                    }
                    StreamWriter1.WriteLine("</tr>");
                    for (i = 0; i < table.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            StreamWriter1.WriteLine("<tr bgcolor=\"#888888\">");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#000000\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                        else
                        {
                            StreamWriter1.WriteLine("<tr>");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                    }
                    StreamWriter1.WriteLine("</table></center></body></html>");
                    StreamWriter1.Flush();
                }
                catch
                {
                    MessageBox.Show("При сохранении файла было вызвано исключение", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Stream1.Close();
                    return;
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            if (checkBox4.Checked)
            {
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
                saveFileDialog1.Title = "Экспорт: Excel";
                if (checkBox1.Checked)
                {
                    remarks_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.Remarks_View);
                    ExportExcel(sQL_SecurityServiceDataSet.Remarks_View);
                    saveFileDialog1.FileName = "";
                }
                if (checkBox2.Checked)
                {
                    onDuty_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.OnDuty_View);
                    ExportExcel(sQL_SecurityServiceDataSet.OnDuty_View);
                    saveFileDialog1.FileName = "";
                }
            }

            if (checkBox3.Checked)
            {
                saveFileDialog1.DefaultExt = "html";
                saveFileDialog1.Filter = "HTML files(*.html)|*.html";
                saveFileDialog1.Title = "Экспорт: HTML";
                if (checkBox1.Checked)
                {
                    remarks_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.Remarks_View);
                    ExportHTML(sQL_SecurityServiceDataSet.Remarks_View, checkBox1.Text);
                    saveFileDialog1.FileName = "";
                }
                if (checkBox2.Checked)
                {
                    onDuty_ViewTableAdapter.Fill(sQL_SecurityServiceDataSet.OnDuty_View);
                    ExportHTML(sQL_SecurityServiceDataSet.OnDuty_View, checkBox2.Text);
                    saveFileDialog1.FileName = "";
                }
            }
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.Remarks_View". При необходимости она может быть перемещена или удалена.
            this.remarks_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.Remarks_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_SecurityServiceDataSet.OnDuty_View". При необходимости она может быть перемещена или удалена.
            this.onDuty_ViewTableAdapter.Fill(this.sQL_SecurityServiceDataSet.OnDuty_View);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
