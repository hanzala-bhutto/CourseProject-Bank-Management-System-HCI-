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
    public partial class UserPortal : Form
    {

        SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);
        
        public static string AccountNumber;
        public static string AccountPin;

        bool DepositOk;
        bool WithDrawOk;
        bool TransferOk;
        bool ValidToAccount;

        public UserPortal(string UserField = null)
        {
            InitializeComponent();
            AccountNumber = UserField;
            SearchPin();
            LoadAccountDetails();
            ShowTransactions();
            this.KeyPreview = true;
            UserPortalPages.SelectTab(0);
            WelcomeLbl1.Text = "Welcome Back " + UserAccNameTB6.Text;
            countNotificationPanels();

        }

        private void countNotificationPanels()
        {
            int count=0;
            foreach (Control control in NotificationPage1.Controls)
            {
                if (control is Panel)
                    ++count;
            }

            NuOfNotificationsLbl.Text = count.ToString();

        }
        private void SuccessfulWithDraw()
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TransactionTbl(AccNumber,TransactionDate,TransactionType,TransactionAmount) VALUES(@AN,@TD,@TT,@TA)", Con);
                cmd.Parameters.AddWithValue("@AN", AccountNumber);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now);
                cmd.Parameters.AddWithValue("@TT", "WithDraw");
                cmd.Parameters.AddWithValue("@TA", WithdrawAmountTB2.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();

            }
        }

        private void SuccessfulTransfer()
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TransactionTbl(AccNumber,TransactionDate,TransactionType,TransactionAmount) VALUES(@AN,@TD,@TT,@TA)", Con);
                cmd.Parameters.AddWithValue("@AN", AccountNumber);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now);
                cmd.Parameters.AddWithValue("@TT", "Transfer");
                cmd.Parameters.AddWithValue("@TA", TransferAmountTB3.Text);
                cmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();

            }
        }

        private void SearchPin()
        {
            try
            {
                Con.Open();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT AccPin From AccountTbl WHERE AccNumber =@AN";
                command.Parameters.AddWithValue("@AN", AccountNumber);

                command.Connection = Con;

                SqlDataReader sdr;

                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    AccountPin = sdr["AccPin"].ToString();
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
        }

        private void LoadDepositData()
        {
            try
            {
                Con.Open();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * From AccountTbl WHERE AccNumber =@AN";
                command.Parameters.AddWithValue("@AN", AccountNumber);

                command.Connection = Con;

                SqlDataReader sdr;

                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    DepositAccNumberTB1.Text = sdr["AccNumber"].ToString();
                    DepositAccNameTB1.Text = sdr["AccName"].ToString();
                    DepositAccBalanceTB1.Text = sdr["AccBalance"].ToString();
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }

        }

        private void LoadWithDrawData()
        {
            try
            {
                Con.Open();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * From AccountTbl WHERE AccNumber =@AN";
                command.Parameters.AddWithValue("@AN", AccountNumber);

                command.Connection = Con;

                SqlDataReader sdr;

                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    WithdrawAccNumberTB2.Text = sdr["AccNumber"].ToString();
                    WithdrawAccNameTB2.Text = sdr["AccName"].ToString();
                    WithdrawAccBalanceTB2.Text = sdr["AccBalance"].ToString();

                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void LoadTransferData()
        {
            try
            {
                Con.Open();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * From AccountTbl WHERE AccNumber =@AN";
                command.Parameters.AddWithValue("@AN", AccountNumber);

                command.Connection = Con;

                SqlDataReader sdr;

                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    TransferFromAccTB3.Text = sdr["AccNumber"].ToString();
                    TransferFromAccBalanceTB3.Text = sdr["AccBalance"].ToString();
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void LoadAccountDetails()
        {
            try
            {
                Con.Open();

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * From AccountTbl WHERE AccNumber =@AN";
                command.Parameters.AddWithValue("@AN", AccountNumber);

                command.Connection = Con;

                SqlDataReader sdr;

                sdr = command.ExecuteReader();

                if (sdr.Read())
                {
                    UserAccNumberTB6.Text = sdr["AccNumber"].ToString();
                    UserAccTypeTB6.Text = sdr["AccType"].ToString();
                    UserAccBalanceTB6.Text = sdr["AccBalance"].ToString();
                    UserAccNameTB6.Text = sdr["AccName"].ToString();
                    UserAccCNICTB6.Text = sdr["AccCNIC"].ToString();
                    UserAccNationalityTB6.Text = sdr["AccNationality"].ToString();
                    UserAccGenderTB6.Text = sdr["AccGender"].ToString();
                    UserAccPhoneTB6.Text = sdr["AccPhone"].ToString();
                    UserAccCityTB6.Text = sdr["AccCity"].ToString();
                    UserAccEmailTB6.Text = sdr["AccEmail"].ToString();
                    UserAccAddressTB6.Text = sdr["AccAddress"].ToString();

                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }

        }

        private void HomeFormbtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Home";
            UserPortalPages.SelectTab(0);
            WelcomeLbl1.Text = "Welcome Back " + UserAccNameTB6.Text;
        }

        private void DepositFormBtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Deposit Amount";
            UserPortalPages.SelectTab(1);

            LoadDepositData();
        }

        private void WithDrawFormBtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "WithDraw Amount";
            UserPortalPages.SelectTab(2);
            LoadWithDrawData();
        }

        private void TransferFormBtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Transfer Amount";
            UserPortalPages.SelectTab(3);
            LoadTransferData();
        }

        private void TransactionFormBtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Transactions";
            UserPortalPages.SelectTab(4);
            ShowTransactions();
        }

        private void AccountDetailsFormBtn1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Account Details";
            UserPortalPages.SelectTab(5);

            LoadAccountDetails();
        }

        private void NotificationIcon1_Click(object sender, EventArgs e)
        {
            MainPagesLabel1.Text = "Notification Box";
            UserPortalPages.SelectTab(6);
        }

        private void AccountNumberTB3_TextChanged(object sender, EventArgs e) { }



        private void bunifuTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserPortalPanel1_Click(object sender, EventArgs e)
        {

        }

        private void CollapseMenuIcon1_Click(object sender, EventArgs e)
        {
            if (UserPortalPanel1.Width == 200)
            {
                UserPortalPanel1.Width = 60;
                Size = new Size(807,561);
                CenterToScreen();
            }
            else
            {
                UserPortalPanel1.Width = 200;
                Size = new Size(943, 561);
                CenterToScreen();
            }
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLogOutBtn1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you Want to Log Out." , "Logout Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                this.Hide();
                Login log = new Login();
                log.Show();
            }

        }

        private void AccountPinTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositAccBalanceTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToAccountTB1_TextChanged(object sender, EventArgs e)
        {

        }

        //      FOR DEPOSIT FORM

        private void AccDepositBtn1_Click(object sender, EventArgs e)
        {
            if (DepositAmountTB1.Text == "" || DepositAccPinTB1.Text == "")
            {
                MessageBox.Show("Kindly fill the missing Fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DepositOk)
                {
                    if (AccountPin == DepositAccPinTB1.Text)
                    {
                        try
                        {
                            DialogResult dr = MessageBox.Show("Are you sure you Make A Deposit Request.", "Deposit Request Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (dr == DialogResult.OK)
                            {
                                Con.Open();

                                SqlCommand cmd = new SqlCommand("INSERT INTO ManageDepositTbl(AccNumber,AccType,DepositAmount,CurrentBalance) VALUES(@AN,@AT,@DA,@CB)", Con);
                                cmd.Parameters.AddWithValue("@AN", AccountNumber);
                                cmd.Parameters.AddWithValue("@AT", UserAccTypeTB6.Text);
                                cmd.Parameters.AddWithValue("@DA", DepositAmountTB1.Text);
                                cmd.Parameters.AddWithValue("@CB", DepositAccBalanceTB1.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Deposit Request of " + DepositAmountTB1.Text + " has been sent. Patiently wait for the request to be approved", "Successfull Desposit Request", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Con.Close();

                                DepositAccPinTB1.Text = "";
                                DepositAmountTB1.Text = "";
                            }

                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Con.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Pin Inserted!", "Pin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Deposit Amount Field is ambiguous", "Deposit Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //      FOR WITHDRAW FORM

        private void DepositAccPinTB1_TextChange(object sender, EventArgs e)
        {
            if (DepositAccPinTB1.Text == "")
            {
                DepositConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.None;
                DepositConfirmPinPB1.IconColor = Color.Transparent;
            }
            else if (AccountPin != DepositAccPinTB1.Text)
            {
                DepositConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                DepositConfirmPinPB1.IconColor = Color.Red;
            }
            else
            {
                DepositConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                DepositConfirmPinPB1.IconColor = Color.Green;
            }
        }

        private void DepositAmountTB1_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (DepositAmountTB1.Text == "")
                {
                    DepositWarning.Text = "";
                    DepositOk = false;
                }
                else if (Convert.ToInt64(DepositAmountTB1.Text) < 0)
                {
                    DepositWarning.Text = "Deposit Amount cannot be negative.";
                    DepositOk = false;
                }
                else
                {
                    DepositWarning.Text = "";
                    DepositOk = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccWithdrawBtn1_Click(object sender, EventArgs e)
        {
            if (WithdrawAccBalanceTB2.Text == "" || WithdrawAccPinTB2.Text == "")
            {
                MessageBox.Show("Kindly fill the missing Fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (WithDrawOk)
                {
                    if (AccountPin == WithdrawAccPinTB2.Text)
                    {
                        try
                        {

                            DialogResult dr = MessageBox.Show("Are you sure you Want to Make a WithDraw.", "Withdraw Amount Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (dr == DialogResult.OK)
                            {
                                Con.Open();

                                string sqlQ1 = "SELECT AccBalance FROM  AccountTbl WHERE AccNumber = @AN";
                                SqlCommand cmd1 = new SqlCommand(sqlQ1, Con);
                                cmd1.Parameters.AddWithValue("@AN", AccountNumber);

                                int AccBalance = Convert.ToInt32(cmd1.ExecuteScalar());

                                int newBalance = AccBalance - Convert.ToInt32(WithdrawAmountTB2.Text);

                                string sqlQ2 = "UPDATE AccountTbl SET AccBalance = @AB WHERE AccNumber = @AN";
                                SqlCommand cmd2 = new SqlCommand(sqlQ2, Con);
                                cmd2.Parameters.AddWithValue("@AN", AccountNumber);
                                cmd2.Parameters.AddWithValue("@AB", newBalance);
                                cmd2.ExecuteNonQuery();

                                Con.Close();

                                MessageBox.Show("WithDraw of " + WithdrawAmountTB2.Text + " has been successfull", "WithDraw Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadWithDrawData();
                                SuccessfulWithDraw();
                                WithdrawAccPinTB2.Text = "";
                                WithdrawAmountTB2.Text = "";

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Pin Inserted!", "Pin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Withdraw Field is ambiguous", "WithDraw Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void WithdrawAccPinTB2_TextChange(object sender, EventArgs e)
        {
            if (WithdrawAccPinTB2.Text == "")
            {
                WithDrawConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.None;
                WithDrawConfirmPinPB1.IconColor = Color.Transparent;
            }
            else if (AccountPin != WithdrawAccPinTB2.Text)
            {
                WithDrawConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                WithDrawConfirmPinPB1.IconColor = Color.Red;
            }
            else
            {
                WithDrawConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                WithDrawConfirmPinPB1.IconColor = Color.Green;
            }
        }

        private void WithdrawAmountTB2_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (WithdrawAmountTB2.Text == "")
                {
                    WithdrawWarning.Text = "";
                    WithDrawOk = false;
                }
                else if (Convert.ToInt64(WithdrawAmountTB2.Text) < 0)
                {
                    WithdrawWarning.Text = "WithDraw Amount cannot be negative.";
                    WithDrawOk = false;

                }
                else if (Convert.ToInt64(WithdrawAmountTB2.Text) > Convert.ToInt64(WithdrawAccBalanceTB2.Text))
                {
                    WithdrawWarning.Text = "WithDraw Amount exceeds current balance.";
                    WithDrawOk = false;
                }
                else
                {
                    WithdrawWarning.Text = "";
                    WithDrawOk = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

//      FOR TRANSFER FORM

        private void ClearToTransferFields()
        {
            TransferToAccNumberTB3.Text = "";
            TransferToAccNameTB3.Text = "";
            TransferAccWarning.Text = "";
            TransferToAccBalanceTB3.Text = "";

        }

        private void TransferToAccSearchBtn1_Click(object sender, EventArgs e)
        {
            if (TransferToAccNumberTB3.Text == "")
            {
                TransferAccWarning.Text = "Please provide a valid Account Number.";
                TransferToAccNameTB3.Text = "";
                TransferToAccBalanceTB3.Text = "";
                TransferAccWarning.ForeColor = Color.Red;
            }
            else
            {
                try
                {

                    Con.Open();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = "SELECT AccNumber,AccName, AccBalance From AccountTbl WHERE AccNumber =@AN";
                    command.Parameters.AddWithValue("@AN", TransferToAccNumberTB3.Text);

                    command.Connection = Con;

                    SqlDataReader sdr;

                    sdr = command.ExecuteReader();

                    if (sdr.Read())
                    {
                        TransferToAccNameTB3.Text = sdr["AccName"].ToString();
                        TransferToAccBalanceTB3.Text = sdr["AccBalance"].ToString();
                        TransferAccWarning.Text = "Valid Account";
                        TransferAccWarning.ForeColor = Color.Green;
                        ValidToAccount = true;

                        Con.Close();
                    }
                    else
                    {
                        TransferAccWarning.Text = "No such Account Exists";
                        TransferAccWarning.ForeColor = Color.Red;
                        TransferToAccNameTB3.Text = "";
                        TransferToAccBalanceTB3.Text = "";
                        ValidToAccount = false;
                        Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();
                }
            }

        }

        private void TransferAmountTB1_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (TransferAmountTB3.Text == "")
                {
                    TransferWarning.Text = "";
                    TransferOk = false;
                }
                else if (Convert.ToInt64(TransferAmountTB3.Text) < 0)
                {
                    TransferWarning.Text = "Transfer Amount cannot be negative.";
                    TransferOk = false;

                }
                else if (Convert.ToInt64(TransferAmountTB3.Text) > Convert.ToInt64(TransferFromAccBalanceTB3.Text))
                {
                    TransferWarning.Text = "Transfer Amount exceeds current balance.";
                    TransferOk = false;
                }
                else
                {
                    TransferWarning.Text = "";
                    TransferOk = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccTransferBtn1_Click(object sender, EventArgs e)
        {
            TransferToAccSearchBtn1_Click(sender, e);

            if (ValidToAccount)
            {
                if (TransferAmountTB3.Text == "" || TransferAccPinTB3.Text == "" || TransferToAccNumberTB3.Text == "")
                {
                    MessageBox.Show("Kindly fill the missing Fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (TransferOk)
                    {

                        if (AccountPin == TransferAccPinTB3.Text)
                        {
                            try
                            {

                                DialogResult dr = MessageBox.Show("Are you sure you Want to Make a Transfer to this Account.", "Transfer Amount Decision", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                if (dr == DialogResult.OK)
                                {
                                    Con.Open();

                                    // for From Account
                                    string sqlQ1 = "SELECT AccBalance FROM  AccountTbl WHERE AccNumber = @AN";
                                    SqlCommand cmd1 = new SqlCommand(sqlQ1, Con);
                                    cmd1.Parameters.AddWithValue("@AN", AccountNumber);

                                    int FromAccBalance = Convert.ToInt32(cmd1.ExecuteScalar());

                                    int FromnewBalance = FromAccBalance - Convert.ToInt32(TransferAmountTB3.Text);

                                    string sqlQ2 = "UPDATE AccountTbl SET AccBalance = @AB WHERE AccNumber = @AN";
                                    SqlCommand cmd2 = new SqlCommand(sqlQ2, Con);
                                    cmd2.Parameters.AddWithValue("@AN", AccountNumber);
                                    cmd2.Parameters.AddWithValue("@AB", FromnewBalance);
                                    cmd2.ExecuteNonQuery();

                                    Con.Close();

                                    Con.Open();

                                    // for To Account
                                    string sqlQ3 = "SELECT AccBalance FROM  AccountTbl WHERE AccNumber = @AN";
                                    SqlCommand cmd3 = new SqlCommand(sqlQ3, Con);
                                    cmd3.Parameters.AddWithValue("@AN", TransferToAccNumberTB3.Text);

                                    int ToAccBalance = Convert.ToInt32(cmd3.ExecuteScalar());

                                    int TonewBalance = ToAccBalance + Convert.ToInt32(TransferAmountTB3.Text);

                                    string sqlQ4 = "UPDATE AccountTbl SET AccBalance = @AB WHERE AccNumber = @AN";
                                    SqlCommand cmd4 = new SqlCommand(sqlQ4, Con);
                                    cmd4.Parameters.AddWithValue("@AN", TransferToAccNumberTB3.Text);
                                    cmd4.Parameters.AddWithValue("@AB", TonewBalance);
                                    cmd4.ExecuteNonQuery();

                                    Con.Close();

                                    MessageBox.Show("Transfer of " + TransferAmountTB3.Text + " from Account Number " + TransferFromAccTB3.Text + " to Account Number " + TransferToAccNumberTB3.Text + " has been successful", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadTransferData();
                                    ClearToTransferFields();
                                    SuccessfulTransfer();
                                    TransferAccPinTB3.Text = "";

                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Pin Inserted!", "Pin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Transfer Amount Field is ambiguous", "TransferAmount Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Accout to which funds should be transferred is invalid", "TransferAccount Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TransferAccPinTB3_TextChange(object sender, EventArgs e)
        {
            if (TransferAccPinTB3.Text == "")
            {
                TransferConfirmPinPB3.IconChar = FontAwesome.Sharp.IconChar.None;
                TransferConfirmPinPB3.IconColor = Color.Transparent;
            }
            else if (AccountPin != TransferAccPinTB3.Text)
            {
                TransferConfirmPinPB3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                TransferConfirmPinPB3.IconColor = Color.Red;
            }
            else
            {
                TransferConfirmPinPB3.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                TransferConfirmPinPB3.IconColor = Color.Green;
            }
        }

        private void TransferToAccBalanceTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowTransactions()
        {
            try
            {

                Con.Open();

                string Myquery = "SELECT * FROM TransactionTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([AccNumber], System.String) = '{0}'", AccountNumber);
                dt.Columns.RemoveAt(0);
                TransactionDGV1.DataSource = dv;
                TransactionDGV1.ReadOnly = true;

                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
        }

        private void GenerateReport()
        {
            TransactionsReports1.Clear();

            TransactionsReports1.AddString("<h1><b><center>Bank Management System</center></b></h1>");
            TransactionsReports1.AddLineBreak();
            TransactionsReports1.AddString("<h2><b><center>Transactions</center></b></h2>");
            TransactionsReports1.AddHorizontalRule();



            TransactionsReports1.AddLineBreak();
            TransactionsReports1.AddLineBreak();

            TransactionsReports1.AddDatagridView(TransactionDGV1);
            TransactionsReports1.AddLineBreak();
//            TransactionsReports1.AddString();
        }

        private void PrintTransactionPB1_Click(object sender, EventArgs e)
        {
            GenerateReport();
            TransactionsReports1.ShowPrintPreviewDialog();
        }

        private void SaveIconPB1_Click(object sender, EventArgs e)
        {
//            GenerateReport();
            SaveToFileDialogue.ShowDialog();
        }

        private void SaveToFileDialogue_FileOk(object sender, CancelEventArgs e)
        {
            GenerateReport();
            TransactionsReports1.SavePDF(SaveToFileDialogue.FileName);
            MessageBox.Show("Transactions Successfully saved into File.", "TransactionToFile ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserPortalPages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                //TransactionFormBtn1_Click(sender,e);
                PrintTransactionPB1.Focus();
                PrintTransactionPB1_Click(sender, e);
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                //TransactionFormBtn1_Click(sender,e);
                SaveIconPB1.Focus();
                SaveIconPB1_Click(sender, e);
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click_2(object sender, EventArgs e)
        {

        }

    }
}
