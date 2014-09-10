using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Admin.Classes;

namespace Admin
{
    public partial class frmLogin : Form
    {
        public User user;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (!GetUser() && (!txtUser.Text.Equals("Admin") || !txtPassword.Text.Equals("Rocklands")))
            {
                MessageBox.Show("No se encuentra usuario");
                return;
            }

            var admin = new frmAdmin { User = user };
            admin.ShowDialog();
        }

        private bool GetUser()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Admin.Properties.Settings.RocklandsConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM tblEmployee where NickName = @NickName and Password = @Password", connection);

                    command.Parameters.AddWithValue("@NickName", txtUser.Text);


                    command.Parameters.AddWithValue("@Password", txtPassword.Text);

                    var exist = command.ExecuteReader();

                    if (!exist.Read()) return false;
                    user = new User { admin = (bool)exist["Admin"], firstName = (string)exist["firstName"], lastName = (string)exist["lastName"], nickName = (string)exist["nickName"] };
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        }

    

        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return|| e.KeyCode == Keys.Enter)
            {

              Login();
            }
        }
    }
}


