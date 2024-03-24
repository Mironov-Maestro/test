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
using Excel = Microsoft.Office.Interop.Excel;

namespace Kartoteka.Controls
{
    public partial class Otcheti : UserControl
    {
        public Otcheti()
        {
            InitializeComponent();
        }

        private void Otcheti_Load(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select * From Sotrudniki";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, Kartoteka.DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSotrudniki.DataSource = table;
                dataGridViewSotrudniki.Columns[0].HeaderText = "Код Сотрудника";
                dataGridViewSotrudniki.Columns[1].HeaderText = "Фамилия";
                dataGridViewSotrudniki.Columns[2].HeaderText = "Имя";
                dataGridViewSotrudniki.Columns[3].HeaderText = "Отчество";
                dataGridViewSotrudniki.Columns[4].HeaderText = "Серия паспорта";
                dataGridViewSotrudniki.Columns[5].HeaderText = "Номер паспорта";
                dataGridViewSotrudniki.Columns[6].HeaderText = "Дата рождения";
                dataGridViewSotrudniki.Columns[7].HeaderText = "Пол";
                dataGridViewSotrudniki.Columns[8].HeaderText = "Телефон";
                dataGridViewSotrudniki.Columns[9].HeaderText = "Адрес";
                dataGridViewSotrudniki.Columns[10].HeaderText = "Код должности";
                dataGridViewSotrudniki.Columns[11].HeaderText = "Код образования";
                dataGridViewSotrudniki.Columns[12].HeaderText = "Код специальности";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            try
            {
                string sqltext = "Select * From Soiskateli";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, Kartoteka.DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSoiskateli.DataSource = table;
                dataGridViewSoiskateli.Columns[0].HeaderText = "Код Соискателя";
                dataGridViewSoiskateli.Columns[1].HeaderText = "Фамилия";
                dataGridViewSoiskateli.Columns[2].HeaderText = "Имя";
                dataGridViewSoiskateli.Columns[3].HeaderText = "Отчество";
                dataGridViewSoiskateli.Columns[4].HeaderText = "Серия паспорта";
                dataGridViewSoiskateli.Columns[5].HeaderText = "Номер паспорта";
                dataGridViewSoiskateli.Columns[6].HeaderText = "Дата рождения";
                dataGridViewSoiskateli.Columns[7].HeaderText = "Пол";
                dataGridViewSoiskateli.Columns[8].HeaderText = "Телефон";
                dataGridViewSoiskateli.Columns[9].HeaderText = "Адрес";
                dataGridViewSoiskateli.Columns[10].HeaderText = "Код образования";
                dataGridViewSoiskateli.Columns[11].HeaderText = "Код специальности";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSotOtchet_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            worksheet.Name = "Отчет по сотрудникам";
            worksheet.Cells[2, 3] = "Список Сотрудниковя";
            Excel.Range rng1 = worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 3]];
            rng1.Cells.Font.Name = "Times New Roman";
            rng1.Cells.Font.Size = 24;
            rng1.Font.Bold = true;
            rng1.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);

            worksheet.Cells[3, 1] = "Код Сотрудника";
            worksheet.Columns[1].ColumnWidth = 20;
            worksheet.Cells[3, 2] = "Фамилия";
            worksheet.Columns[2].ColumnWidth = 18;
            worksheet.Cells[3, 3] = "Имя";
            worksheet.Columns[3].ColumnWidth = 18;
            worksheet.Cells[3, 4] = "Отчество";
            worksheet.Columns[4].ColumnWidth = 18;
            worksheet.Cells[3, 5] = "Серия паспорта";
            worksheet.Columns[5].ColumnWidth = 15;
            worksheet.Cells[3, 6] = "Номер паспорта";
            worksheet.Columns[6].ColumnWidth = 15;
            worksheet.Cells[3, 7] = "Дата рождения";
            worksheet.Columns[7].ColumnWidth = 15;
            worksheet.Cells[3, 8] = "Пол";
            worksheet.Columns[8].ColumnWidth = 5;
            worksheet.Cells[3, 9] = "Телефон";
            worksheet.Columns[9].ColumnWidth = 15;
            worksheet.Cells[3, 10] = "Адрес";
            worksheet.Columns[10].ColumnWidth = 60;
            worksheet.Cells[3, 11] = "Код должности";
            worksheet.Columns[11].ColumnWidth = 15;
            worksheet.Cells[3, 12] = "Код образования";
            worksheet.Columns[12].ColumnWidth = 15;
            worksheet.Cells[3, 13] = "Код специальности";
            worksheet.Columns[13].ColumnWidth = 15;
            Excel.Range rng2 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[4, 13]];
            rng2.Font.Bold = true;

            string SqlText = "select * from Sotrudniki";
            try
            {
                using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                {
                    con.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(SqlText, con);
                    DataTable table = new DataTable();
                    Adapter.Fill(table);
                    int i = 4;

                    foreach (DataRow row in table.Rows)
                    {
                        worksheet.Cells[i, 1] = row["Kod_Sot"];
                        worksheet.Cells[i, 2] = row["Fam"];
                        worksheet.Cells[i, 3] = row["Ima"];
                        worksheet.Cells[i, 4] = row["Otc"];
                        worksheet.Cells[i, 5] = row["Pas_Seria"];
                        worksheet.Cells[i, 6] = row["Pas_Number"];
                        worksheet.Cells[i, 7] = row["God_Rojdenia"];
                        worksheet.Cells[i, 8] = row["Pol"];
                        worksheet.Cells[i, 9] = row["Tel"];
                        worksheet.Cells[i, 10] = row["Adres"];
                        worksheet.Cells[i, 11] = row["FK_Kod_D"];
                        worksheet.Cells[i, 12] = row["FK_Kod_O"];
                        worksheet.Cells[i, 13] = row["FK_Kod_S_P"];
                        i++;

                        //Excel.Range rng3 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[i, 13]];

                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

                        excelApp.Visible = true;
                        excelApp.UserControl = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSoisOtchet_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            worksheet.Name = "Отчет по соискателям";
            worksheet.Cells[2, 3] = "Список соискателей";
            Excel.Range rng1 = worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 3]];
            rng1.Cells.Font.Name = "Times New Roman";
            rng1.Cells.Font.Size = 24;
            rng1.Font.Bold = true;
            rng1.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);

            worksheet.Cells[3, 1] = "Код Соискателя";
            worksheet.Columns[1].ColumnWidth = 20;
            worksheet.Cells[3, 2] = "Фамилия";
            worksheet.Columns[2].ColumnWidth = 18;
            worksheet.Cells[3, 3] = "Имя";
            worksheet.Columns[3].ColumnWidth = 18;
            worksheet.Cells[3, 4] = "Отчество";
            worksheet.Columns[4].ColumnWidth = 18;
            worksheet.Cells[3, 5] = "Серия паспорта";
            worksheet.Columns[5].ColumnWidth = 15;
            worksheet.Cells[3, 6] = "Номер паспорта";
            worksheet.Columns[6].ColumnWidth = 15;
            worksheet.Cells[3, 7] = "Дата рождения";
            worksheet.Columns[7].ColumnWidth = 15;
            worksheet.Cells[3, 8] = "Пол";
            worksheet.Columns[8].ColumnWidth = 5;
            worksheet.Cells[3, 9] = "Телефон";
            worksheet.Columns[9].ColumnWidth = 15;
            worksheet.Cells[3, 10] = "Адрес";
            worksheet.Columns[10].ColumnWidth = 60;
            worksheet.Cells[3, 11] = "Код образования";
            worksheet.Columns[11].ColumnWidth = 15;
            worksheet.Cells[3, 12] = "Код специальности";
            worksheet.Columns[12].ColumnWidth = 15;
            Excel.Range rng2 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[4, 12]];
            rng2.Font.Bold = true;

            string SqlText = "select * from Soiskateli";
            try
            {
                using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                {
                    con.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(SqlText, con);
                    DataTable table = new DataTable();
                    Adapter.Fill(table);
                    int i = 4;

                    foreach (DataRow row in table.Rows)
                    {
                        worksheet.Cells[i, 1] = row["Kod_Sois"];
                        worksheet.Cells[i, 2] = row["Fam"];
                        worksheet.Cells[i, 3] = row["Ima"];
                        worksheet.Cells[i, 4] = row["Otc"];
                        worksheet.Cells[i, 5] = row["Pas_Seria"];
                        worksheet.Cells[i, 6] = row["Pas_Number"];
                        worksheet.Cells[i, 7] = row["God_Rojdenia"];
                        worksheet.Cells[i, 8] = row["Pol"];
                        worksheet.Cells[i, 9] = row["Tel"];
                        worksheet.Cells[i, 10] = row["Adres"];
                        worksheet.Cells[i, 11] = row["FK_Kod_O"];
                        worksheet.Cells[i, 12] = row["FK_Kod_S_P"];
                        i++;

                        //Excel.Range rng3 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[i, 13]];

                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                        //rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

                        excelApp.Visible = true;
                        excelApp.UserControl = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
