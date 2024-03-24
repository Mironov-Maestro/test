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
using System.Net;
using System.Runtime.Remoting.Contexts;

namespace Kartoteka
{
    public partial class MainForm : Form
    {
        protected Dictionary<string, UserControl> userControl;
        protected Autorizacia autorizacia;
        public string u_pravo;
        public MainForm(Autorizacia autorizacia)
        {
            InitializeComponent();
            loadData();
            setupControlsInPanel(userControl["Sotrudniki"]);
            this.autorizacia = autorizacia;
        }
        private void SeeAdmin()
        {
            u_pravo = User.Prava;
            using (SqlConnection connection = new SqlConnection(DataBase.StrBD))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"Select FK_Kod_P From Users where Login_user = '{u_pravo}' ", connection);
                command.Connection = connection;
                int _priority = Convert.ToInt32(command.ExecuteScalar());
                if (_priority != 1)
                {
                    buttonUsers.Visible = false;
                }
            }
        }
        private void loadData()
        {
            userControl = new Dictionary<string, UserControl>()
            {
                {"Sotrudniki", new Controls.Sotrudniki()},
                {"Soiskateli", new Controls.Soiskateli()},
                {"Otcheti", new Controls.Otcheti()},
                {"Users", new Controls.Users()},
            };
        }
        private void setupControlsInPanel(UserControl userControl)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void buttonSpisok_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(userControl["Sotrudniki"]);
        }

        private void buttonSoiskatel_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(userControl["Soiskateli"]);
        }
        private void buttonOtchet_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(userControl["Otcheti"]);
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(userControl["Users"]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var reply = MessageBox.Show("Вернуться на форму авторизации?", "Окно закрытия", MessageBoxButtons.YesNoCancel);
            if (reply == DialogResult.Yes)
            {
                this.Hide();
                autorizacia.Show();
            }
            else if (reply == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                autorizacia.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SeeAdmin();
        }
    }
}
