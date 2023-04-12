using System;
using System.Windows.Forms;
using FBS.DAL_2.Authentication;
using FlightBookingSystem.Models;
using WindowsFormsApp1.CustomViews;

namespace PL_FlightBookingSystem
{
    public partial class Account : UserControl
    {
        private DLAuthentication dLAuthentication { get; set; }
        public Account()
        {
            InitializeComponent();
            dLAuthentication = new DLAuthentication();
        }


        private void Signup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                    var res = new DLAuthentication().SignUpp(SinUsernameTxt.Text, SinSurnameTxt.Text, SinPasswdTxt.Text, int.Parse(AgeBox.Text));
                    MessageBox.Show(res == 1 ? "Account Created" : "Problem while Signin up");
                    SinUsernameTxt.Text = ""; SinSurnameTxt.Text = ""; SinPasswdTxt.Text = ""; AgeBox.Text = "";
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Problem while Signin up");
                }
                
            }
            else
            {
                // user clicked no
            }
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var res = dLAuthentication.Login(LogUsernameTxt.Text, LogPasswordTxt.Text);
            if (res != null) {
                MessageBox.Show("Logged In");
                LogUsernameTxt.Text = ""; LogPasswordTxt.Text = "";
                GlobalState.Logged = true;
                GlobalState.user = res;
                GlobalState.GetInstance("accInfo1").Show();
                GlobalState.GetInstance("account_SignUp1").Hide();
                GlobalState.GetInstance("accInfo1").Refresh();
            } else {
                MessageBox.Show("Problem while Loggin in");
        }


        }
    }
}
