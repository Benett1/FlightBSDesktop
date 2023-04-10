using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PL_FlightBookingSystem;


namespace PL_FlightBookingSystem
{
    public partial class Account_Login : UserControl
    {
        public Account_Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String name = NameLoginTxtBox.Text;
            String password = PasswordLoginTxtBox.Text;

            Console.WriteLine(name + " " + password);


        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            dynamic target = ((dynamic)sender).Name;
            GlobalState.GetInstance(target!).BringToFront();

        }
    }
}
