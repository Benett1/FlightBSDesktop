using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL_2.Authentication;
using FlightBookingSystem.Models;
using WindowsFormsApp1.CustomViews;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<String> loc = new List<String>();
            loc.Add("");

            foreach (LocationModel el in GlobalState.Locations)
            {
                loc.Add(el.City);
            }

            depatureBox.Items.AddRange(loc.ToArray());
            arrivalBox.Items.AddRange(loc.ToArray());
            List<FlightModel> fmodel = new DAOFlights().GetFlights();


            foreach (FlightModel flight in fmodel)
            {

                flowLayoutPanel.Controls.Add(new FlightCard(flight));
            }

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void searchFlightBtn_Click(object sender, EventArgs e)
        {
            var depAiroport = depatureBox.Text.Trim();
            var arrivalAirport = arrivalBox.Text.Trim();
            List<FlightModel> fmodel;

            if (depAiroport.Equals("") || arrivalAirport.Equals("")){
               fmodel = new DAOFlights().GetFlights();
            }
            else {
               fmodel = new DAOFlights().GetFlightsFiltered(depAiroport, arrivalAirport);
            }
            

            flowLayoutPanel.Controls.Clear();
            foreach (FlightModel flight in fmodel)
            {
                flowLayoutPanel.Controls.Add(new FlightCard(flight));
            }
        }

        private void accInfo1_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {

        }

        private void account1_Load(object sender, EventArgs e)
        {

        }
    }
}
