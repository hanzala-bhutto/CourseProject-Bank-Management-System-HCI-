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

namespace Bank_Management_System
{
    public partial class Login : Form
    {

        SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect Username or Password.");
        }

        private void LoginFormExitPB1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm crf = new CreateAccountForm();
            this.Hide();
            crf.Show();
        }


        private void verifyUser()
        {

        }
        private void verifyAdmin()
        {

        }
        private void verifyEmployee()
        {

        }


        private void LogInBtn1_Click(object sender, EventArgs e)
        {

            if (UserFieldTB1.Text == "")
            {
                MessageBox.Show("User Field is missing.", "User Field Empty" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserFieldTB1.Focus();
            }
            else if (PasswordTB1.Text == "")
            {
                MessageBox.Show("Password Field is missing.", "Password Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTB1.Focus();
            }
            else
            {
                try
                {

                    if (LoginSwapRolesCB1.SelectedItem.ToString() == "User")
                    {

                        Con.Open();

                        SqlCommand command = new SqlCommand();
                        string UserField;

                        command.CommandText = "SELECT AccNumber From AccountTbl WHERE AccName =@username AND AccPassword=@password";
                        command.Parameters.AddWithValue("@username", UserFieldTB1.Text);
                        command.Parameters.AddWithValue("@password", PasswordTB1.Text);

                        command.Connection = Con;

                        object obj = command.ExecuteScalar();
                        if (obj != null)
                        {
                            UserField = obj.ToString();
                                
                            Con.Close();

                            MessageBox.Show("Login Successful. Welcome User", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UserPortal up = new UserPortal(UserField);
                            
                            up.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Either Username or Password is incorrect.","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Con.Close();
                        }
                    }
                    else if (LoginSwapRolesCB1.SelectedItem.ToString() == "Admin")
                    {

                        if (UserFieldTB1.Text.Equals("admin") && UserFieldTB1.Text.Equals("admin"))
                        {
                            MessageBox.Show("Login Successful. Welcome Admin", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminPortal admin = new AdminPortal();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Either Admin name or Password is incorrect.", "Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        Con.Open();

                        string currentUserID = string.Empty;

                        SqlCommand command = new SqlCommand();

                        command.CommandText = "SELECT EmpEmail From EmployeeTbl WHERE EmpName =@username AND EmpID=@password";
                        command.Parameters.AddWithValue("@username", UserFieldTB1.Text);
                        command.Parameters.AddWithValue("@password", PasswordTB1.Text);

                        command.Connection = Con;

                        object obj = command.ExecuteScalar();
                        if (obj != null)
                        {
                            currentUserID = obj.ToString();
                            Con.Close();

                            MessageBox.Show("Login Successful. Welcome Employee", "Employee Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            EmployeePortal ep = new EmployeePortal();
                            ep.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Either Employee name or Password is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Con.Close();
                        }
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();

                }
            }
        }

        private void LoginSwapRolesCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LoginSwapRolesCB1.SelectedItem.ToString() == "User")
            {
                NotRegisteredLbl1.Text = "Not Registered";
                CreateAccLinkLbl1.Text = "Create Account";

                UserFieldTB1.PlaceholderText = "Account Name";
                PasswordTB1.PlaceholderText = "Password";


                bunifuToolTip1.SetToolTipTitle(UserFieldTB1, "Account Name Text Box");
                bunifuToolTip1.SetToolTip(UserFieldTB1, "Insert Account Name in this field");


                bunifuToolTip1.SetToolTipTitle(PasswordTB1, "Account Password Text Box");
                bunifuToolTip1.SetToolTip(PasswordTB1, "Insert Account Password in this field");

            }
            else if (LoginSwapRolesCB1.SelectedItem.ToString() == "Admin")
            {
                NotRegisteredLbl1.Text = "";
                CreateAccLinkLbl1.Text = "";

                UserFieldTB1.PlaceholderText = "Admin Name";
                PasswordTB1.PlaceholderText = "Password";


                bunifuToolTip1.SetToolTipTitle(UserFieldTB1, "Admin Name Text Box");
                bunifuToolTip1.SetToolTip(UserFieldTB1, "Insert Admin Name in this field");


                bunifuToolTip1.SetToolTipTitle(PasswordTB1, "Admin Password Text Box");
                bunifuToolTip1.SetToolTip(PasswordTB1, "Insert Admin Password in this field");
            }
            else
            {
                NotRegisteredLbl1.Text = "";
                CreateAccLinkLbl1.Text = "";

                UserFieldTB1.PlaceholderText = "Employee Name";
                PasswordTB1.PlaceholderText = "Employee ID";

                bunifuToolTip1.SetToolTipTitle(UserFieldTB1, "Employee Name Text Box");
                bunifuToolTip1.SetToolTip(UserFieldTB1, "Insert Employee Name in this field");


                bunifuToolTip1.SetToolTipTitle(PasswordTB1, "Employee ID Text Box");
                bunifuToolTip1.SetToolTip(PasswordTB1, "Insert Employee ID in this field");
            }
        }

        private void LoginPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
