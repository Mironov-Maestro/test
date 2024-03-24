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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kartoteka.Controls
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }
        private void LoadDataGrid()
        {
            try
            {
                string sqltext = "Select * From Users";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, Kartoteka.DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridUsers.DataSource = table;
                dataGridUsers.Columns[0].HeaderText = "Код пользователя";
                dataGridUsers.Columns[1].HeaderText = "Код сотрудника";
                dataGridUsers.Columns[2].HeaderText = "Уровень прав";
                dataGridUsers.Columns[3].HeaderText = "Логин пользователя";
                dataGridUsers.Columns[4].HeaderText = "Пароль пользователя";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void dataGridUsers_DoubleClick(object sender, EventArgs e)
        {
            textBoxKodUser.Text = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
            textBoxKS.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
            textBoxPP.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
            textBoxLP.Text = dataGridUsers.CurrentRow.Cells[3].Value.ToString();
            textBoxPasP.Text = dataGridUsers.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKodUser.Text = "";
            textBoxKS.Text = "";
            textBoxLP.Text = "";
            textBoxPasP.Text = "";
            textBoxPP.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxKS.Text != "" && textBoxLP.Text != "" && textBoxPasP.Text != "" && textBoxPP.Text != "")
            {
                DialogResult result = MessageBox.Show("Добавить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"insert into Users values ('{textBoxKS.Text}','{textBoxPP.Text}','{textBoxLP.Text}','{textBoxPasP.Text}') ";
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
            int Kod_U = Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value);
            if (textBoxKS.Text != "" && textBoxLP.Text != "" && textBoxPasP.Text != "" && textBoxPP.Text != "")
            {
                DialogResult result = MessageBox.Show("Изменить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Update Users set FK_Kod_Sot = {Convert.ToInt32(textBoxKS.Text)}, FK_Kod_P = {Convert.ToInt32(textBoxPP.Text)}, Login_User = '{textBoxLP.Text}', Password_User = '{textBoxPasP.Text}' where Kod_U = {Kod_U} ";
                    using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlText, con);
                        int kol = cmd.ExecuteNonQuery();

                        MessageBox.Show("Запись изменина ",
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxKodUser.Text != "")
            {
                DialogResult result = MessageBox.Show("Удалить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    string sqlText = $"Delete from Users where Kod_U = {Convert.ToInt32(textBoxKodUser.Text)}";
                    using (SqlConnection con = new SqlConnection(DataBase.StrBD))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlText, con);
                        int kol = cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Записей удалена: ",
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

        private void buttonSpravkaS_Click(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select * From Prava";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, Kartoteka.DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSpravka.DataSource = table;
                dataGridViewSpravka.Columns[0].HeaderText = "Код права";
                dataGridViewSpravka.Columns[1].HeaderText = "Название";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonSpravkaSot_Click(object sender, EventArgs e)
        {
            try
            {
                string sqltext = "Select Kod_Sot, Fam, Ima, Otc From Sotrudniki";
                SqlDataAdapter adapter = new SqlDataAdapter(sqltext, Kartoteka.DataBase.StrBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSpravka.DataSource = table;
                dataGridViewSpravka.Columns[0].HeaderText = "Код Сотрудника";
                dataGridViewSpravka.Columns[1].HeaderText = "Фамилия";
                dataGridViewSpravka.Columns[2].HeaderText = "Имя";
                dataGridViewSpravka.Columns[3].HeaderText = "Отчество";
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
