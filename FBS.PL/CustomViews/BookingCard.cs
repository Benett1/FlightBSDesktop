using FBS.DAL;
using FBS.DAL.Bookings;
using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomViews
{
    public partial class BookingCard : UserControl
    {
        private DAOBookings _DAOBookings;
        private DAOFlights _DAOOFlights;
        private BookingsModel _BookingsModel;
        public BookingCard(BookingsModel bookingsModel)
        {
            InitializeComponent();
            _DAOOFlights = new DAOFlights();
            _DAOBookings = new DAOBookings();

            _BookingsModel = bookingsModel;
            FlightModel model = _DAOOFlights.GetFlightById(bookingsModel.FlightId);

            depAirportTxt.Text = model.DepartureAirport.ToString();
            arrivalAirportTxt.Text = model.ArrivalAirport.ToString();
            dateTxt.Text = model.DateTime.ToString();
            nameTxt.Text = bookingsModel.Name;
            surnameTxt.Text = bookingsModel.Surname;
            ageTxt.Text = bookingsModel.Age.ToString();
            bagTxt.Text = bookingsModel.baggage?"Included":"No Baggages";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _DAOBookings.DeleteBooking(_BookingsModel.Id);
                GlobalState.bookingPainted = false;

            }
        }
    }
}
