using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace Kartoteka
{
    public partial class Autorizacia : Form
    {
        public Autorizacia()
        {
            InitializeComponent();
        }

        private void buttonAutorizacia_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this);
            DataTable Log = new DataTable();
            DataTable Pas = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(DataBase.StrBD);
                SqlCommand command = new SqlCommand($@"Select Kod_U from Users where Login_User = '{textBoxLogin.Text}' and Password_User = '{textBoxPassword.Text}' ", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cheked();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Неверный логин или пароль");
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
        public void Cheked()
        {
            User.Prava = textBoxLogin.Text;
        }
    }
}
