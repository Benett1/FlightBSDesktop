using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL.Bookings;
using FBS.DAL_2.Authentication;
using FlightBookingSystem.Models;
using WindowsFormsApp1.CustomViews;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DAOBookings _DAOBookings;
        public Form1()
        {

            InitializeComponent();
            _DAOBookings = new DAOBookings();

            List<String> loc = new List<String>();
            loc.Add("");

            foreach (LocationModel el in GlobalState.Locations)
            {
                loc.Add(el.City);
            }

            depatureBox.Items.AddRange(loc.ToArray());
            arrivalBox.Items.AddRange(loc.ToArray());
            
            List<FlightModel> fmodel = new DAOFlights().GetFlights();
            GlobalState.BookingLayout = flowLayoutBookingsPanel1;
            GlobalState.HomeLayout = flowLayoutPanel;

            
            foreach (FlightModel flight in fmodel)
            {
                flowLayoutPanel.Controls.Add(new FlightCard(flight));
            }

            if (GlobalState.user != null)
            {
                List<BookingsModel> bookings = _DAOBookings.GetBookingsByUserId(GlobalState.user.Id);

                foreach (BookingsModel book in bookings)
                {
                    flowLayoutBookingsPanel1.Controls.Add(new BookingCard(book));
                }
            }
            else
            {
                GlobalState.getTab("flightsTab").SelectedIndex = 2;
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

        private void bookingPage_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutBookingsPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (GlobalState.user != null && !GlobalState.bookingPainted)
            {
                GlobalState.BookingLayout.Controls.Clear();
                GlobalState.bookingPainted = true;
                List<BookingsModel> bookings = (GlobalState.user.RoleId == 1) ? _DAOBookings.GetBookingsByUserId(GlobalState.user.Id) : _DAOBookings.GetBookings();

                foreach (BookingsModel book in bookings)
                {
                    flowLayoutBookingsPanel1.Controls.Add(new BookingCard(book));
                }
            }
            else if(GlobalState.user == null)
            {
                MessageBox.Show("You need to be logged in to have access to bookings");
                GlobalState.getTab("flightsTab").SelectedIndex = 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo cInfo = new CultureInfo("sq-XK");
            System.Globalization.DateTimeFormatInfo dateTimeInfo = new System.Globalization.DateTimeFormatInfo();
            Thread.CurrentThread.CurrentCulture = cInfo;
            Thread.CurrentThread.CurrentCulture = cInfo;

        }
    }
}
