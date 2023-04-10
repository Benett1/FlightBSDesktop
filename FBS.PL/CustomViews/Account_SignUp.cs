using System;
using System.Windows.Forms;

namespace PL_FlightBookingSystem
{
    public partial class Account_SignUp : UserControl
    {
        public Account_SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = NameSingUpTxtBox.Text;
            String surname = SurnameSingUpTxtBox.Text;
            int age = int.Parse(AgeSingUpTxtBox.Text);

            MessageBox.Show(name + " " + surname + " " + age);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedIndex = 1;
        }
    }
}
