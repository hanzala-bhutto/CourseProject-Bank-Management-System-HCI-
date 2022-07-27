using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Bank_Management_System
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseString"].ConnectionString);


        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccSubmitBtn1_Click(object sender, EventArgs e)
        {
            if (AccNameTB1.Text == "" || AccPasswordTB1.Text == "" || AccConfirmPasswordTB1.Text == "" || AccPinTB1.Text == "" || AccConfirmPinTB1.Text == "" || AccBalanceTB1.Text == "" || AccTypeCB1.SelectedItem.ToString() == "" || AccGenderCB1.SelectedItem.ToString() == "" || AccCNICTB1.Text == "" || AccNationalityTB1.Text == "" || AccPhoneNumberTB1.Text == "" || AccCityTB1.Text == "" || AccAddressTB1.Text == "")
            {
                MessageBox.Show("Kindly fill All the Missing Information.");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO AccountTbl(AccName, AccPassword, AccPin,AccType,AccBalance,AccGender,AccCNIC,AccNationality,AccPhone,AccCity,AccEmail,AccAddress) " +
                        "VALUES(@ANm,@APass,@APin,@AT,@AB , @AG, @ACNIC, @ANt, @APh, @ACt,@AEm, @AA)", Con);
                    cmd.Parameters.AddWithValue("@ANm", AccNameTB1.Text);
                    cmd.Parameters.AddWithValue("@APass", AccPasswordTB1.Text);
                    cmd.Parameters.AddWithValue("@APin", AccPinTB1.Text);
                    cmd.Parameters.AddWithValue("@AT", AccTypeCB1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AB", AccBalanceTB1.Text);
                    cmd.Parameters.AddWithValue("@AG", AccGenderCB1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACNIC", AccCNICTB1.Text);
                    cmd.Parameters.AddWithValue("@ANt", AccNationalityTB1.Text);
                    cmd.Parameters.AddWithValue("@APh", AccPhoneNumberTB1.Text);
                    cmd.Parameters.AddWithValue("@ACt", AccCityTB1.Text);
                    cmd.Parameters.AddWithValue("@AEm", AccEmailTB1.Text);
                    cmd.Parameters.AddWithValue("@AA", AccAddressTB1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Created Account Successfully.");

                    Con.Close();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();

                }
            }
        }

        private void CreateAccCancelBtn1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void CreateAccExitBtn1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void AccConfirmPasswordTB1_TextChange(object sender, EventArgs e)
        {
            if(AccPasswordTB1.Text != AccConfirmPasswordTB1.Text)
            {
                ConfirmPassPB1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                ConfirmPassPB1.IconColor = Color.Red;
            }
            else
            {
                ConfirmPassPB1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                ConfirmPassPB1.IconColor = Color.Green;
            }
        }

        private void AccConfirmPinTB1_TextChange(object sender, EventArgs e)
        {
            if (AccPinTB1.Text != AccConfirmPinTB1.Text)
            {
                ConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                ConfirmPinPB1.IconColor = Color.Red;
            }
            else
            {
                ConfirmPinPB1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                ConfirmPinPB1.IconColor = Color.Green;
            }
        }

        private void AccBalanceTB1_TextChange(object sender, EventArgs e)
        {
            if (AccBalanceTB1.Text == "")
            {
                DepositWarning.Text = "";

            }
            else if (AccBalanceTB1.Text.All(Char.IsDigit))
            {
                DepositWarning.Text = "";                ;
            }
            else
            {
                DepositWarning.Text = "Only numbers are allowed";
            }
        }

        private void AccCNICTB1_TextChange(object sender, EventArgs e)
        {
            if (AccCNICTB1.Text == "")
            {
                CNICWarning.Text = "";

            }
            else if (AccCNICTB1.Text.All(Char.IsDigit))
            {
                CNICWarning.Text = "";
                if (AccCNICTB1.Text.Length != 13)
                {
                    CNICWarning.Text = "Should be 13 digits";
                }
                else
                {
                    CNICWarning.Text = "";
                }
            }
            else
            {
                CNICWarning.Text = "Only 13 digit numbers are allowed";
            }
        }

        private void AccPhoneNumberTB1_TextChange(object sender, EventArgs e)
        {
            if (AccPhoneNumberTB1.Text == "")
            {
                PhoneWarning.Text = "";

            }
            else if (AccPhoneNumberTB1.Text.All(Char.IsDigit))
            {
                PhoneWarning.Text = "";
                if (AccPhoneNumberTB1.Text.Length != 11)
                {
                    PhoneWarning.Text = "Should be 11 digits";
                }
                else
                {
                    PhoneWarning.Text = "";
                }
            }
            else
            {
                PhoneWarning.Text = "Only 11 digit numbers are allowed";
            }
        }

        private void AccEmailTB1_TextChange(object sender, EventArgs e)
        {
            if (AccEmailTB1.Text == "")
            {
                EmailVerifyWarning.Text = "";
            }
            else if (new EmailAddressAttribute().IsValid(AccEmailTB1.Text))
            {
                EmailVerifyWarning.Text = "";
            }
            else
            {
                EmailVerifyWarning.Text = "Please provide a valid email";
            }
        }

        private void AccCityTB1_TextChange(object sender, EventArgs e)
        {
            if (AccCityTB1.Text == "")
            {
                CityWarning.Text = "";
            }
            else if (!Regex.IsMatch(AccCityTB1.Text, @"^[a-zA-Z]+$"))
            {
                CityWarning.Text = "should be letters only";
            }
            else
            {
                CityWarning.Text = "";
            }
        }

        private void AccNationalityTB1_TextChange(object sender, EventArgs e)
        {
            if (AccNationalityTB1.Text == "")
            {
                NationalityWarning.Text = "";
            }
            else if (!Regex.IsMatch(AccNationalityTB1.Text, @"^[a-zA-Z]+$"))
            {
                NationalityWarning.Text = "should be letters only";
            }
            else
            {
                NationalityWarning.Text = "";
            }
        }

        private void AccNameTB1_TextChange(object sender, EventArgs e)
        {
            if (AccNameTB1.Text == "")
            {
                NameWarning.Text = "";
            }
            else if (!Regex.IsMatch(AccNameTB1.Text, @"^[a-zA-Z]+$"))
            {
                NameWarning.Text = "should be letters only";
            }
            else
            {
                NameWarning.Text = "";
            }
        }
    }
}
