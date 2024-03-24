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

namespace Kartoteka.Controls
{
    public partial class Soiskateli : UserControl
    {
        public Soiskateli()
        {
            InitializeComponent();
        }

        private void Soiskateli_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
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

        private void dataGridViewSoiskateli_DoubleClick(object sender, EventArgs e)
        {
            textBoxKodSois.Text = dataGridViewSoiskateli.CurrentRow.Cells[0].Value.ToString();
            textBoxFam.Text = dataGridViewSoiskateli.CurrentRow.Cells[1].Value.ToString();
            textBoxIma.Text = dataGridViewSoiskateli.CurrentRow.Cells[2].Value.ToString();
            textBoxOtc.Text = dataGridViewSoiskateli.CurrentRow.Cells[3].Value.ToString();
            textBoxSP.Text = dataGridViewSoiskateli.CurrentRow.Cells[4].Value.ToString();
            textBoxNP.Text = dataGridViewSoiskateli.CurrentRow.Cells[5].Value.ToString();
            textBoxDR.Text = dataGridViewSoiskateli.CurrentRow.Cells[6].Value.ToString();
            textBoxPol.Text = dataGridViewSoiskateli.CurrentRow.Cells[7].Value.ToString();
            textBoxTel.Text = dataGridViewSoiskateli.CurrentRow.Cells[8].Value.ToString();
            textBoxAdres.Text = dataGridViewSoiskateli.CurrentRow.Cells[9].Value.ToString();
            textBoxObr.Text = dataGridViewSoiskateli.CurrentRow.Cells[10].Value.ToString();
            textBoxSpec.Text = dataGridViewSoiskateli.CurrentRow.Cells[11].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKodSois.Text = "";
            textBoxFam.Text = "";
            textBoxIma.Text = "";
            textBoxOtc.Text = "";
            textBoxSP.Text = "";
            textBoxNP.Text = "";
            textBoxDR.Text = "";
            textBoxPol.Text = "";
            textBoxTel.Text = "";
            textBoxAdres.Text = "";
            textBoxObr.Text = "";
            textBoxSpec.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFam.Text != "" && textBoxIma.Text != "" && textBoxOtc.Text != "" && textBoxSP.Text != "" && textBoxNP.Text != "" && textBoxDR.Text != "" && textBoxPol.Text != "" && textBoxTel.Text != "" && textBoxAdres.Text != "" && textBoxObr.Text != "" && textBoxSpec.Text != "")
            {
                DialogResult result = MessageBox.Show("Добавить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"insert into Soiskateli values ('{textBoxFam.Text}','{textBoxIma.Text}','{textBoxOtc.Text}','{textBoxSP.Text}','{textBoxNP.Text}','{textBoxDR.Text}','{textBoxPol.Text}','{textBoxTel.Text}','{textBoxAdres.Text}',{textBoxObr.Text},{textBoxSpec.Text}) ";
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
            int Kod_Sois = Convert.ToInt32(dataGridViewSoiskateli.CurrentRow.Cells[0].Value);
            if (textBoxFam.Text != "" && textBoxIma.Text != "" && textBoxOtc.Text != "" && textBoxSP.Text != "" && textBoxNP.Text != "" && textBoxDR.Text != "" && textBoxPol.Text != "" && textBoxTel.Text != "" && textBoxAdres.Text != "" && textBoxObr.Text != "" && textBoxSpec.Text != "")
            {
                DialogResult result = MessageBox.Show("Изменить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Update Soiskateli Set Fam = '{textBoxFam.Text}', Ima = '{textBoxIma.Text}', Otc = '{textBoxOtc.Text}', Pas_Seria = '{textBoxSP.Text}', Pas_Number = '{textBoxNP.Text}', God_Rojdenia = '{textBoxDR.Text}', Pol = '{textBoxPol.Text}', Tel = '{textBoxTel.Text}', Adres = '{textBoxAdres.Text}', FK_Kod_O = {Convert.ToInt32(textBoxObr.Text)}, FK_Kod_S_P = {Convert.ToInt32(textBoxSpec.Text)} Where Kod_Sois = {Kod_Sois}";
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
            if (textBoxKodSois.Text != "")
            {
                DialogResult result = MessageBox.Show("Удалить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Delete from Soiskateli where Kod_Sois = {Convert.ToInt32(textBoxKodSois.Text)}";
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
