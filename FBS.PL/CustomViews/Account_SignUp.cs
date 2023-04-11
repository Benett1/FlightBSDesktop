using System;
using System.Windows.Forms;
using FBS.DAL_2.Authentication;
using WindowsFormsApp1.CustomViews;

namespace PL_FlightBookingSystem
{
    public partial class Account_SignUp : UserControl
    {
        public Account_SignUp()
        {
            InitializeComponent();
        }


        private void Signup_Click(object sender, EventArgs e)
        {
            var res = new DLAuthentication().SignUpp(SinUsernameTxt.Text,SinSurnameTxt.Text, SinPasswdTxt.Text, int.Parse(AgeBox.Text));
            MessageBox.Show(res == 1 ? "Account Created" : "Problem while Signin in");
            SinUsernameTxt.Text = "";SinSurnameTxt.Text = "";SinPasswdTxt.Text = "";AgeBox.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var res = new DLAuthentication().Login(LogUsernameTxt.Text, LogPasswordTxt.Text);
            if (res == 1) {
                MessageBox.Show("Logged In");
                LogUsernameTxt.Text = ""; LogPasswordTxt.Text = "";
                GlobalState.Logged = true;
                GlobalState.GetInstance("accInfo1").Show();
            } else {
                MessageBox.Show("Problem while Loggin in");
        }


        }
    }
}
