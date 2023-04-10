using PL_FlightBookingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            account_SignUp1.Hide();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            account_SignUp1.Show();
            BackBtn.Visible = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            account_SignUp1.Hide();
            BackBtn.Visible = false;
        }
    }
}
