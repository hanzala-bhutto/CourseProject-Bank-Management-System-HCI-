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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
            DisplayEmployees();
            DisplayAccounts();
            ClearFieldsEmployees();
            ClearFieldsAccounts();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hanzala\Desktop\HCIProject\Bank_Management_System\Bank_Management_System\DataBase\BankingDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void AdminPortalPanel1_Click(object sender, EventArgs e)
        {
        }


        private void ManageAccountFormBtn1_Click(object sender, EventArgs e)
        {
            ManageAccountFormBtn1.Focus();
            AdminPagesLabel1.Text = "Manage Accounts";
            AdminPages1.SelectTab(0);
            DisplayAccounts();
        }

        private void ManageEmployeesFormBtn1_Click(object sender, EventArgs e)
        {
            ManageEmployeesFormBtn1.Focus();
            AdminPagesLabel1.Text = "Manage Employees";
            AdminPages1.SelectTab(1);
            DisplayEmployees();
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminCollapseMenuIcon1_Click(object sender, EventArgs e)
        {
            if (AdminPortalPanel1.Width == 200)
            {
                AdminPortalPanel1.Width = 60;
                Size = new Size(807, 561);
                CenterToScreen();
            }
            else
            {
                AdminPortalPanel1.Width = 200;
                Size = new Size(943, 561);
                CenterToScreen();
            }
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void ClearFieldsAccounts()
        {
            AdminAccNumberTB1.Text = "";
            AdminBankIDTB1.Text = "";
            AdminAccNameTB1.Text = "";
            AdminAccTypeCB1.Text = "Choose Type";
            AdminAccBalanceTB1.Text = "";
        }


        public void ClearFieldsEmployees()
        {
            AdminEmpNameTB2.Text = "";
            AdminEmpIDTB2.Text = "";
            AdminEmpSalaryTB1.Text = "";
            AdminEmpEmailTB1.Text = "";

        }

        private void DisplayAccounts()
        {
            try
            {
                Con.Open();

                string Myquery = "SELECT AccNumber, BankID, AccName, AccType, AccBalance FROM AccountTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                AdminAccDGV1.DataSource = ds.Tables[0];
                AdminAccDGV1.ReadOnly = true;

                Con.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void AdminAccRemoveBtn1_Click(object sender, EventArgs e)
        {
            if (AdminAccNumberTB1.Text == "")
            {
                MessageBox.Show("Select an Account To Remove From DataBase.");
            }
            else
            {
                try
                {

                    DialogResult dr = MessageBox.Show("Are you sure you Want to Remove this Account.", "Remove Account Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK)
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM AccountTbl where AccNumber = @AN", Con);
                        cmd.Parameters.AddWithValue("@AN", AdminAccNumberTB1.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account Removed Successfully.");


                        Con.Close();

                        DisplayAccounts();
                        ClearFieldsAccounts();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Con.Close();
                    ClearFieldsAccounts();
                }
            }
        }


        private void DisplayEmployees()
        {
            try
            {
                Con.Open();

                string Myquery = "SELECT * FROM EmployeeTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                AdminEmpDGV1.DataSource = ds.Tables[0];
                AdminEmpDGV1.ReadOnly = true;

                Con.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void AdminEmpAddBtn2_Click(object sender, EventArgs e)
        {

            if (AdminEmpNameTB2.Text == "" || AdminEmpIDTB2.Text == "" || AdminEmpSalaryTB1.Text == "" || AdminEmpEmailTB1.Text == "")
            {
                MessageBox.Show("Kindly fill All the Missing Information.");
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you Want to Add this Employee.", "Employee Add Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK)
                    {

                        Con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeTbl(EmpID, EmpName, EmpSalary, EmpEmail) VALUES(@EID,@ENm,@ESl,@EEm)", Con);
                        cmd.Parameters.AddWithValue("@EID", AdminEmpIDTB2.Text);
                        cmd.Parameters.AddWithValue("@ENm", AdminEmpNameTB2.Text);
                        cmd.Parameters.AddWithValue("@ESl", AdminEmpSalaryTB1.Text);
                        cmd.Parameters.AddWithValue("@EEm", AdminEmpEmailTB1.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Added Successfully.");

                        Con.Close();

                        DisplayEmployees();
                        ClearFieldsEmployees();
                    }


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                    ClearFieldsEmployees();

                }
            }


        }

        private void AdminEmpRemoveBtn2_Click(object sender, EventArgs e)
        {

            if (AdminEmpIDTB2.Text == "")
            {
                MessageBox.Show("Select an Employee To Remove From DataBase.");
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you Want to Remove this Employee.", "Remove Employee Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK)
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeTbl where EmpID = @EID", Con);
                        cmd.Parameters.AddWithValue("@EID", AdminEmpIDTB2.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Removed Successfully.");


                        Con.Close();

                        DisplayEmployees();
                        ClearFieldsEmployees();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                    ClearFieldsEmployees();
                }
            }
        }

        private void AdminEmpDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminEmpIDTB2.Text = AdminEmpDGV1.SelectedRows[0].Cells[0].Value.ToString();
            AdminEmpNameTB2.Text = AdminEmpDGV1.SelectedRows[0].Cells[1].Value.ToString();
            AdminEmpSalaryTB1.Text = AdminEmpDGV1.SelectedRows[0].Cells[2].Value.ToString();
            AdminEmpEmailTB1.Text = AdminEmpDGV1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void AdminAccDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminAccNumberTB1.Text = AdminAccDGV1.SelectedRows[0].Cells[0].Value.ToString();
            AdminBankIDTB1.Text = AdminAccDGV1.SelectedRows[0].Cells[1].Value.ToString();
            AdminAccNameTB1.Text = AdminAccDGV1.SelectedRows[0].Cells[2].Value.ToString();
            AdminAccTypeCB1.Text = AdminAccDGV1.SelectedRows[0].Cells[3].Value.ToString();
            AdminAccBalanceTB1.Text = AdminAccDGV1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AdminAccSearchBtn1_Click(object sender, EventArgs e)
        {
            if (AdminAccSearchTB1.Text == "")
            {
                MessageBox.Show("Cannot Search an empty field.");
            }
            else
            {

                try
                {
                    if (SearchAccountCB1.SelectedItem.ToString() == "Account Name")
                    {
                        Con.Open();

                        string Myquery = "SELECT AccNumber, BankID, AccName, AccType, AccBalance FROM AccountTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("Convert([AccNumber], System.String) LIKE '%{0}%' ", AdminAccSearchTB1.Text);
                        AdminAccDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminAccDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with AccNumber = " + AdminAccSearchTB1.Text);
                            ClearFieldsAccounts();
                            AdminAccSearchTB1.Text = "";
                        }

                    }
                    else if (SearchAccountCB1.SelectedItem.ToString() == "Bank ID")
                    {
                        Con.Open();

                        string Myquery = "SELECT AccNumber, BankID, AccName, AccType, AccBalance FROM AccountTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("BankID = '{0}' ", AdminAccSearchTB1.Text);
                        AdminAccDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminAccDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with AccNumber = " + AdminAccSearchTB1.Text);
                            ClearFieldsAccounts();
                            AdminAccSearchTB1.Text = "";
                        }

                    }
                    else
                    {
                        Con.Open();

                        string Myquery = "SELECT AccNumber, BankID, AccName, AccType, AccBalance FROM AccountTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("Convert([AccNumber], System.String) LIKE '%{0}%' ", AdminAccSearchTB1.Text);
                        AdminAccDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminAccDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with AccNumber = " + AdminAccSearchTB1.Text);
                            ClearFieldsAccounts();
                            AdminAccSearchTB1.Text = "";
                        }

                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }

            }
        }

        private void AdminEmpSearchBtn1_Click(object sender, EventArgs e)
        {
            if (AdminEmpSearchTB1.Text == "")
            {
                MessageBox.Show("Cannot Search an empty field.");
            }
            else
            {

                try
                {

                    if (SearchEmpCB1.SelectedItem.ToString() == "Employee ID")
                    {
                        Con.Open();

                        string Myquery = "SELECT * FROM EmployeeTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("EmpID = '{0}'", AdminEmpSearchTB1.Text);
                        AdminEmpDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminEmpDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with Employee ID = " + AdminEmpSearchTB1.Text);
                            ClearFieldsEmployees();
                            AdminEmpSearchTB1.Text = "";
                        }
                    }
                    else if (SearchEmpCB1.SelectedItem.ToString() == "Employee Name")
                    {
                        Con.Open();

                        string Myquery = "SELECT * FROM EmployeeTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("EmpName = '{0}'", AdminEmpSearchTB1.Text);
                        AdminEmpDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminEmpDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with Employee Name = " + AdminEmpSearchTB1.Text);
                            ClearFieldsEmployees();
                            AdminEmpSearchTB1.Text = "";
                        }
                    }
                    else
                    {
                        Con.Open();

                        string Myquery = "SELECT * FROM EmployeeTbl";
                        SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DataView dv = new DataView(dt);

                        dv.RowFilter = string.Format("EmpID = '{0}'", AdminEmpSearchTB1.Text);
                        AdminEmpDGV1.DataSource = dv;

                        Con.Close();

                        if (AdminEmpDGV1.Rows.Count <= 1)
                        {
                            MessageBox.Show("No Record exists with Employee ID = " + AdminEmpSearchTB1.Text);
                            ClearFieldsEmployees();
                            AdminEmpSearchTB1.Text = "";
                        }
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }

            }
        }

        private void AdminLogOutBtn1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you Want to Log Out.", "Logout Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                Login log = new Login();
                this.Hide();
                log.Show();
            }

        }

        private void SearchEmpCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmployees();
        }

        private void AdminAccSearchTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchAccountCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAccounts();
        }
    }
}
