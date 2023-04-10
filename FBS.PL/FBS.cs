using System;
using System.Windows.Forms;
using FBS.DAL;

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

            DLFlights bLL = new DLFlights();

            MessageBox.Show(bLL.GetFlights().ToString());
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            account_SignUp1.Hide();
            BackBtn.Visible = false;
        }
    }
}
