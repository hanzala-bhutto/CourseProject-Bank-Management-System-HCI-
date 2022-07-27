using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Bank_Management_System
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Increment(1);
            bunifuCircleProgress1.Value++;
            if (bunifuCircleProgress1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                MessageBox.Show("Your software has been loaded. Press Okay to Continue...", "Banking System Loaded", MessageBoxButtons.OK,MessageBoxIcon.Information);
                login.Show();
                this.Hide();
            }
        }
    }
}
