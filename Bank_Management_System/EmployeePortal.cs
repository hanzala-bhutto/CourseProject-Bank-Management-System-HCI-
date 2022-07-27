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
    public partial class EmployeePortal : Form
    {

        SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);

        public EmployeePortal()
        {
            InitializeComponent();
            ShowDepositRequests();
        }

        private void SuccessfulDeposit(string Account, string Amount)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TransactionTbl(AccNumber,TransactionDate,TransactionType,TransactionAmount) VALUES(@AN,@TD,@TT,@TA)", Con);
                cmd.Parameters.AddWithValue("@AN", Account);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now);
                cmd.Parameters.AddWithValue("@TT", "Deposit");
                cmd.Parameters.AddWithValue("@TA", Amount);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();

            }
        }

        private void ShowDepositRequests()
        {
            try
            {

                Con.Open();

                string Myquery = "SELECT * FROM ManageDepositTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataView dv = new DataView(dt);

                ManageDepositsDGV1.DataSource = dv;
                ManageDepositsDGV1.ReadOnly = true;

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
        }

        private void ManageDepositFormBtn1_Click(object sender, EventArgs e)
        {
            ManageDepositFormBtn1.Select();
            EmployeePagesLabel1.Text = "Manage Deposits";
            EmployeePages.SelectTab(0);
            ShowDepositRequests();
        }

        private void EmployeeCollapseMenuIcon1_Click(object sender, EventArgs e)
        {
            if (EmployeePortalPanel1.Width == 200)
            {
                EmployeePortalPanel1.Width = 60;
                Size = new Size(807, 561);
                CenterToScreen();
            }
            else
            {
                EmployeePortalPanel1.Width = 200;
                Size = new Size(943, 561);
                CenterToScreen();
            }
        }

        private void EmployeeLogOutBtn1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you Want to Log Out.", "Logout Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void UpdateBalance(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string AccountNumber = ManageDepositsDGV1.SelectedRows[0].Cells[0].Value.ToString();

                int AddDeposit = Convert.ToInt32(ManageDepositsDGV1.SelectedRows[0].Cells[2].Value.ToString());

                string sqlQ1 = "SELECT AccBalance FROM  AccountTbl WHERE AccNumber = @AN";
                SqlCommand cmd1 = new SqlCommand(sqlQ1, Con);
                cmd1.Parameters.AddWithValue("@AN", AccountNumber);

                int AccBalance = Convert.ToInt32(cmd1.ExecuteScalar());

                int newBalance = AccBalance + AddDeposit;

                string sqlQ2 = "UPDATE AccountTbl SET AccBalance = @AB WHERE AccNumber = @AN";
                SqlCommand cmd2 = new SqlCommand(sqlQ2, Con);
                cmd2.Parameters.AddWithValue("@AN", AccountNumber);
                cmd2.Parameters.AddWithValue("@AB", newBalance);
                cmd2.ExecuteNonQuery();

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }

        }

        private void RemoveDepositRequest(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string AccountNumber = ManageDepositsDGV1.SelectedRows[0].Cells[0].Value.ToString();

                SqlCommand cmd = new SqlCommand("DELETE FROM ManageDepositTbl where AccNumber = @AN", Con);
                cmd.Parameters.AddWithValue("@AN", AccountNumber);

                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
        }

        private void EmpDepApproveBtn1_Click(object sender, EventArgs e)
        {
            if (ManageDepositsDGV1.SelectedRows.Count > 0)
            {
                if (ManageDepositsDGV1.SelectedRows[0].Cells[0].Value != null)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you Want to Approve This Deposit Request.", "Approve Deposit Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK)
                    {
                        string account = ManageDepositsDGV1.SelectedRows[0].Cells[0].Value.ToString();
                        string amount = ManageDepositsDGV1.SelectedRows[0].Cells[2].Value.ToString();
                        UpdateBalance(sender, e);
                        RemoveDepositRequest(sender, e);
                        MessageBox.Show("Deposit Request has been approved. The Account will be updated and notified with the decision made", "Approved Deposit Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDepositRequests();
                        SuccessfulDeposit(account, amount);
                    }
                }
                else
                {
                    MessageBox.Show("Selected Row is Empty", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("No Row Selected", "Select a Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void EmpDepDisapproveBtn1_Click(object sender, EventArgs e)
        {
            if (ManageDepositsDGV1.SelectedRows.Count > 0)
            {
                if (ManageDepositsDGV1.SelectedRows[0].Cells[0].Value != null)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you Want to Disapprove This Deposit Request.", "Disapprove Deposit Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK)
                    {
                        RemoveDepositRequest(sender, e);
                        MessageBox.Show("Deposit Request has been disapproved. The Account will be updated and notified with the decision made", "Disapproved Deposit Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDepositRequests();
                    }
                }
                else
                {
                    MessageBox.Show("Selected Row is Empty", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("No Row Selected", "Select a Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
