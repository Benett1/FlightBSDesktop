using FBS.DAL_2.Authentication;
using FlightBookingSystem.Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomViews
{
    public partial class AccInfo : UserControl
    {
        private DAOAuthentication dLAuthentication { get; set; }
        public AccInfo()
        {
            InitializeComponent();
            dLAuthentication = new DAOAuthentication();
            try {
                UserModel model = GlobalState.user;
                nameTxt.Text = model.Name;
                surnameTxt.Text = model.Surname;
                ageTxt.Text = model.Age.ToString();
                passwordTxt.Text = model.Password;
                roleTxt.Text = model.RoleId == 1? "User" : "Admin";
            } catch { }
        }

        private void Log_outClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure", "confirm", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                GlobalState.Logged = false;
                GlobalState.user = null;
                GlobalState.Painted = false;
                GlobalState.GetInstance("accInfo1").Hide();
                GlobalState.GetInstance("account_SignUp1").Show();
                GlobalState.BookingLayout.Controls.Clear();
                GlobalState.bookingPainted = false;

                TabControl flightsTab = GlobalState.getTab("flightsTab");
                flightsTab.TabPages.Remove(GlobalState.getTabFlights());
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserModel user = new UserModel();
                user.Id = GlobalState.user.Id;
                user.Name = nameTxt.Text;
                user.Surname  = surnameTxt.Text;
                user.Age = int.Parse(ageTxt.Text);
                user.Password = passwordTxt.Text;
                user.RoleId = GlobalState.user.RoleId;
                var res = dLAuthentication.Update_User(user);
                GlobalState.user = user;
                GlobalState.Painted = false;
                MessageBox.Show(res==1 ? "User Details updated successfully" : "Problem occured whle updating the user information");
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            try
            {
                if (!GlobalState.Painted) {
                    GlobalState.Painted = true;
                    UserModel model = GlobalState.user;
                    nameTxt.Text = model.Name;
                    surnameTxt.Text = model.Surname;
                    ageTxt.Text = model.Age.ToString();
                    passwordTxt.Text = model.Password;
                    roleTxt.Text = model.RoleId == 1 ? "User" : "Admin";
                }
            }
            catch { }
        }
    }
}
