using FBS.DAL.Locations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL_2.Authentication;

namespace WindowsFormsApp1.CustomViews
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var res = new DAOAuthentication().SignUpp(SinUsernameTxt.Text, SinSurnameTxt.Text, SinPasswdTxt.Text, int.Parse(AgeBox.Text));
                    MessageBox.Show(res == 1 ? "Account Created" : "Problem while Signin up");
                    SinUsernameTxt.Text = ""; SinSurnameTxt.Text = ""; SinPasswdTxt.Text = ""; AgeBox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem while Signin up");
                }

            }
            else
            {
                // user clicked no
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GlobalState.GetInstance("account1").Show();
            GlobalState.GetInstance("signup1").Hide();  
        }
    }
}
