using Kartoteka;
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
using System.Xml;

namespace Kartoteka.Controls
{
    public partial class Sotrudniki : UserControl
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
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
        }

        private void dataGridViewSotrudniki_DoubleClick(object sender, EventArgs e)
        {
            textBoxKodSot.Text = dataGridViewSotrudniki.CurrentRow.Cells[0].Value.ToString();
            textBoxFam.Text = dataGridViewSotrudniki.CurrentRow.Cells[1].Value.ToString();
            textBoxIma.Text = dataGridViewSotrudniki.CurrentRow.Cells[2].Value.ToString();
            textBoxOtc.Text = dataGridViewSotrudniki.CurrentRow.Cells[3].Value.ToString();
            textBoxSP.Text = dataGridViewSotrudniki.CurrentRow.Cells[4].Value.ToString();
            textBoxNP.Text = dataGridViewSotrudniki.CurrentRow.Cells[5].Value.ToString();
            textBoxDR.Text = dataGridViewSotrudniki.CurrentRow.Cells[6].Value.ToString();
            textBoxPol.Text = dataGridViewSotrudniki.CurrentRow.Cells[7].Value.ToString();
            textBoxTel.Text = dataGridViewSotrudniki.CurrentRow.Cells[8].Value.ToString();
            textBoxAdres.Text = dataGridViewSotrudniki.CurrentRow.Cells[9].Value.ToString();
            textBoxDol.Text = dataGridViewSotrudniki.CurrentRow.Cells[10].Value.ToString();
            textBoxObr.Text = dataGridViewSotrudniki.CurrentRow.Cells[11].Value.ToString();
            textBoxSpec.Text = dataGridViewSotrudniki.CurrentRow.Cells[12].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKodSot.Text = "";
            textBoxFam.Text = "";
            textBoxIma.Text = "";
            textBoxOtc.Text = "";
            textBoxSP.Text = "";
            textBoxNP.Text = "";
            textBoxDR.Text = "";
            textBoxPol.Text = "";
            textBoxTel.Text = "";
            textBoxAdres.Text = "";
            textBoxDol.Text = "";
            textBoxObr.Text = "";
            textBoxSpec.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFam.Text != "" && textBoxIma.Text != "" && textBoxOtc.Text != "" && textBoxSP.Text != "" && textBoxNP.Text != "" && textBoxDR.Text != "" && textBoxPol.Text != "" && textBoxTel.Text != "" && textBoxAdres.Text != "" && textBoxDol.Text != "" && textBoxObr.Text != "" && textBoxSpec.Text != "")
            {
                DialogResult result = MessageBox.Show("Добавить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"insert into Sotrudniki values ('{textBoxFam.Text}','{textBoxIma.Text}','{textBoxOtc.Text}','{textBoxSP.Text}','{textBoxNP.Text}','{textBoxDR.Text}','{textBoxPol.Text}','{textBoxTel.Text}','{textBoxAdres.Text}',{textBoxDol.Text},{textBoxObr.Text},{textBoxSpec.Text}) ";
                    using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlText, con);
                        int kol = cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Записей добавлено: " + kol.ToString(),
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int Kod_Sot = Convert.ToInt32(dataGridViewSotrudniki.CurrentRow.Cells[0].Value);
            if (textBoxFam.Text != "" && textBoxIma.Text != "" && textBoxOtc.Text != "" && textBoxSP.Text != "" && textBoxNP.Text != "" && textBoxDR.Text != "" && textBoxPol.Text != "" && textBoxTel.Text != "" && textBoxAdres.Text != "" && textBoxDol.Text != "" && textBoxObr.Text != "" && textBoxSpec.Text != "")
            {
                DialogResult result = MessageBox.Show("Изменить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Update Sotrudniki Set Fam = '{textBoxFam.Text}', Ima = '{textBoxIma.Text}', Otc = '{textBoxOtc.Text}', Pas_Seria = '{textBoxSP.Text}', Pas_Number = '{textBoxNP.Text}', God_Rojdenia = '{textBoxDR.Text}', Pol = '{textBoxPol.Text}', Tel = '{textBoxTel.Text}', Adres = '{textBoxAdres.Text}', FK_Kod_D = {Convert.ToInt32(textBoxDol.Text)}, FK_Kod_O = {Convert.ToInt32(textBoxObr.Text)}, FK_Kod_S_P = {Convert.ToInt32(textBoxSpec.Text)} Where Kod_Sot = {Kod_Sot}";
                    using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlText, con);
                        int kol = cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Запись изменин: ",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSpravkaD_Click(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select * From Doljnosti";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSpravka.DataSource = table;
                dataGridViewSpravka.Columns[0].HeaderText = "Код должности";
                dataGridViewSpravka.Columns[1].HeaderText = "Должность";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSpravkaO_Click(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select * From Obrazovanie";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSpravka.DataSource = table;
                dataGridViewSpravka.Columns[0].HeaderText = "Код образования";
                dataGridViewSpravka.Columns[1].HeaderText = "Образование";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSpravkaS_Click(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select * From Spec_Or_Prof";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSpravka.DataSource = table;
                dataGridViewSpravka.Columns[0].HeaderText = "Код специальности";
                dataGridViewSpravka.Columns[1].HeaderText = "Специальность";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxKodSot.Text != "")
            {
                DialogResult result = MessageBox.Show("Удалить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Delete from Sotrudniki where Kod_Sot = {Convert.ToInt32(textBoxKodSot.Text)}";
                    using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlText, con);
                        int kol = cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Запись удалена: ",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
