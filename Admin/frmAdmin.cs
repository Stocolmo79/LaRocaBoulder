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
using Admin.Classes;

namespace Admin
{
    public partial class frmAdmin : Form
    {
        public User User;
        public User ToUpdateUser = new User();
        public Client Client = new Client();
        private bool exists;

        private readonly string _connectionString = "";
        public frmAdmin()
        {
            InitializeComponent();
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Admin.Properties.Settings.RocklandsConnectionString"].ConnectionString;
        }


        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadcmbInstructors();
            LoadExistingEmployees();
            LoggedIn();
            SetMonthlyDate();

        }

        private void SetMonthlyDate()
        {
            txtMonthlyStart.Text = DateTime.Today.ToShortDateString();
            txtMonthlyEnd.Text = DateTime.Today.AddMonths(1).ToShortDateString();
        }

        private void LoggedIn()
        {
            Text = Text + " " + "Usuario: " + User.nickName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void SaveUser()
        {
            if (ToUpdateUser.employeenumber == null) return;
         
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command;
                if (!exists)
                {
                    command = new SqlCommand("INSERT INTO tblEmployee VALUES (@FirstName,@LastName,@NickName,@Employeenumber,@Password,@Phone,@Admin,@InstructorID,@RUT)", connection);
                }
                else
                {
                    command = new SqlCommand("UPDATE tblEmployee SET FirstName = @FirstName, LastName =@LastName,NickName = @NickName, Password = @Password, Phone = @Phone, Admin = @Admin, InstructorID = @InstructorID, RUT = @RUT WHERE ID =@ID ", connection);
                    command.Parameters.AddWithValue("@ID", ToUpdateUser.ID);
                }

                command.Parameters.AddWithValue("@FirstName", ToUpdateUser.firstName);
                command.Parameters.AddWithValue("@LastName", ToUpdateUser.lastName);
                command.Parameters.AddWithValue("@NickName", ToUpdateUser.nickName);
                command.Parameters.AddWithValue("@Employeenumber", ToUpdateUser.employeenumber);
                command.Parameters.AddWithValue("@Password", ToUpdateUser.password);
                command.Parameters.AddWithValue("@Phone", ToUpdateUser.phone);
                command.Parameters.AddWithValue("@Admin", ToUpdateUser.admin);
                command.Parameters.AddWithValue("@InstructorID",  ToUpdateUser.InstructorID);
                command.Parameters.AddWithValue("@RUT", ToUpdateUser.RUT);
                command.ExecuteNonQuery();

                ResetForm();
                connection.Close();
                connection.Dispose();
            }
        }

        private void ResetForm()
        {
            ToUpdateUser.admin = false;
            ToUpdateUser.firstName = "";
            ToUpdateUser.lastName = "";
            ToUpdateUser.employeenumber = "";
            ToUpdateUser.password = "";
            ToUpdateUser.phone = "";
            txtNames.Text = "";
            txtLastNames.Text = "";
            txtNick.Text = "";
            txtEmpNumber.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            chkAdmin.Checked = false;

        }

        private void tpNewEmp_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcAdmin.SelectedIndex ==1)
            {
                btnSave.Enabled = User.admin;
        
                txtEmpNumber.Enabled = !exists;
                txtPassword.UseSystemPasswordChar = !User.admin;

            }
            else
            {
                Client = new Client();
            }
        }

   
        private void SearchUser(ComboBoX combo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM tblEmployee WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", combo.Value);
                var rd = command.ExecuteReader();

                if (rd.Read())
                {
                    FillForm(rd);
                    exists = true;
                }
                else
                {
                    exists = false;
                }
                connection.Close();
                connection.Dispose();
            }
        }

        private void FillForm(SqlDataReader rd)
        {
            ToUpdateUser = new User { ID = (int)rd["ID"], admin = (bool)rd["Admin"], firstName = (string)rd["FirstName"],
                                      lastName = (string)rd["LastName"], nickName = rd["NickName"].ToString(),
                                      phone = (string)rd["Phone"],
                                      employeenumber = rd["EmployeeNumber"].ToString(),
                                      password = (string)rd["Password"]
            };
            txtNick.Text = ToUpdateUser.nickName;
            txtNames.Text = ToUpdateUser.firstName;
            txtLastNames.Text = ToUpdateUser.lastName;
            txtEmpNumber.Text = ToUpdateUser.employeenumber;
            txtPassword.Text = ToUpdateUser.password;
            txtPhone.Text = ToUpdateUser.phone;
            chkAdmin.Checked = ToUpdateUser.admin;

        }

        private void txtNick_Leave(object sender, EventArgs e)
        {
            if (txtNick.Text.Length> 0)
            {              
                ToUpdateUser.nickName = txtNick.Text;
                ResetForm();
                txtNick.Text = ToUpdateUser.nickName;

            }
        }

        private void txtNames_Leave(object sender, EventArgs e)
        {
            if (txtNames.Text.Length > 0)
            {
                ToUpdateUser.firstName = txtNames.Text;
            }
        }

        private void txtLastNames_Leave(object sender, EventArgs e)
        {
            if (txtLastNames.Text.Length > 0)
            {
                ToUpdateUser.lastName= txtLastNames.Text;
            }
            else
            {
                txtLastNames.Text = ToUpdateUser.lastName;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Tiene que tener alguna contraseña!");
                txtPassword.Text = ToUpdateUser.password;
            }
            ToUpdateUser.password = txtPassword.Text;
           
          
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            ToUpdateUser.phone = txtPhone.Text;
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            ToUpdateUser.admin = chkAdmin.Checked;
        }

        
        private void LoadExistingEmployees()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM tblEmployee", connection);

                var rd = command.ExecuteReader();
                var datasource = new List<ComboBoX> {new ComboBoX("Nuevo Usuario", 0)};
                while (rd.Read())
                {
                    datasource.Add(new ComboBoX(rd["NickName"].ToString(), (int) rd["ID"]));
                }

                cmbUser.DataSource = datasource;
                cmbUser.DisplayMember = "Text";
                cmbUser.ValueMember = "Value";
                cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
                rd.Close();
                connection.Close();
                connection.Dispose();

            }
        }

        private void LoadcmbInstructors()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM tblInstructorType", connection);

                var rd = command.ExecuteReader();
                var datasource = new List<ComboBoX>();
                while (rd.Read())
                {
                    datasource.Add(new ComboBoX(rd["InstructorType"].ToString(), (int) rd["ID"]));
                }

                cmbInstructor.DataSource = datasource;
                cmbInstructor.DisplayMember = "Text";
                cmbInstructor.ValueMember = "Value";
                cmbInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
                rd.Close();
                connection.Close();
                connection.Dispose();
             
            }
        }


        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchUser((ComboBoX) cmbUser.SelectedItem);
        }

        private void cmbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToUpdateUser.InstructorID = ((ComboBoX) cmbInstructor.SelectedItem).Value;
        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            SearchClient();
            cmbClientsFound.Visible =  cmbClientsFound.Items.Count > 1;
            lblNotFound.Visible = cmbClientsFound.Items.Count == 0;

        }

        private void SearchClient()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM tblClient WHERE FirstName = @param  OR LastName =@param OR Phone = @param OR email = @param", connection);
                command.Parameters.AddWithValue("@param", txtSearchBox.Text);
                var rd = command.ExecuteReader();

                var datasource = new List<ComboBoX>() ;
                while (rd.Read())
                {
                    datasource.Add(new ComboBoX(rd["FirstName"] + " " + rd["LastName"] +" "+ rd["Email"], (int)rd["ID"]));
                }
                cmbClientsFound.DataSource = datasource;
                cmbClientsFound.DisplayMember = "Text";
                cmbClientsFound.ValueMember = "Value";
                cmbClientsFound.DropDownStyle = ComboBoxStyle.DropDownList;


                rd.Close();
                connection.Close();
                connection.Dispose();

            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command;
                if (!exists)
                {
                    command = new SqlCommand("INSERT INTO tblClient VALUES (@FirstName,@LastName,@Phone,@email) DECLARE @ID INT; SET @ID=SCOPE_IDENTITY() ", connection);
                }
                else
                {
                    command = new SqlCommand("UPDATE tblEmployee SET FirstName = @FirstName, LastName =@LastName,Phone = @Phone, Email = @email WHERE ID =@ID  ", connection);
                    command.Parameters.AddWithValue("@ID", ToUpdateUser.ID);
                }

                command.Parameters.AddWithValue("@FirstName", Client.firstName);
                command.Parameters.AddWithValue("@LastName", Client.lastName);
                command.Parameters.AddWithValue("@Phone", Client.phone);
                command.Parameters.AddWithValue("@email", Client.email);
     
              int i = (int) command.ExecuteScalar();

                ResetForm();
                connection.Close();
                connection.Dispose();
            }
        }

        private void txtFirstNameClient_Leave(object sender, EventArgs e)
        {
            if (txtFirstNameClient.Text.Length<1)
            {
                txtFirstNameClient.Text = Client.firstName;
            }
            else
            {
                  Client.firstName = txtFirstNameClient.Text;
            }
          
        }

        private void txtLastNameClient_Leave(object sender, EventArgs e)
        {
            if (txtLastNameClient.Text.Length < 1)
            {
                txtLastNameClient.Text = Client.lastName;
            }
            else
            {
                Client.lastName = txtLastNameClient.Text;
                
            }
           
        }

        private void txtPhoneClient_Leave(object sender, EventArgs e)
        {
            Client.phone = txtPhoneClient.Text;
        }

        private void txtEmailClient_Leave(object sender, EventArgs e)
        {
            if (txtEmailClient.Text.Length < 1)
            {
                txtEmailClient.Text = Client.email;
            }
            else
            {

                Client.email = txtEmailClient.Text;
            }

        }
    }
}
