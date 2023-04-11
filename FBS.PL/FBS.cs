using System;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL_2.Authentication;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // account_SignUp1.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            account_SignUp1.Hide();
            BackBtn.Visible = false;
        }
    }
}
