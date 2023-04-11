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
            List<FlightModel> fmodel = new DLFlights().GetFlights();


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
            var depAeroport = depatureBox.Text.Trim();
            var arrivalAirport = arrivalBox.Text.Trim();

            List<FlightModel> fmodel = new DLFlights().GetFlightsFiltered(depAeroport,arrivalAirport);

            flowLayoutPanel.Controls.Clear();
            foreach (FlightModel flight in fmodel)
            {
                flowLayoutPanel.Controls.Add(new FlightCard(flight));
            }
        }
    }
}
