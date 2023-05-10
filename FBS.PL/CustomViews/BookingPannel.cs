using FBS.DAL;
using FBS.DAL.Bookings;
using FBS.DAL_2;

using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomViews
{
    public partial class BookingPannel : UserControl
    {
        private FlightModel _flightModel;
        private DAOBookings _DAOBookings;
        public BookingPannel(FlightModel model)
        {
                InitializeComponent();
                _flightModel = model;
                flightIdBox.Text = "" + model.Id;
                flightIdBox.Enabled = false;
                _DAOBookings = new DAOBookings();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        BookingsModel model = new BookingsModel();
                        model.Id = Guid.NewGuid();
                        model.UserId = GlobalState.user.Id;
                        model.FlightId = _flightModel.Id;
                        model.Name = nameTxtBox.Text;
                        model.Surname = surnameTxtBox.Text;
                        model.Age = int.Parse(ageTxtBox.Text);
                        model.baggage = baggageCheckBox.Checked;
                        int seat = int.Parse(seatTxtBox.Text);

                        List <int> seats = _DAOBookings.GetBookingsByFlightId(_flightModel.Id);
                        
                        foreach(int el in seats) {
                            if (seat == el) {
                                MessageBox.Show("This seat is taken, chose another one");
                                return;
                            }
                        }
                        

                        model.Seat = seat;
                        _DAOBookings.AddBooking(model);
                        GlobalState.bookingPainted = false;
                        String email = emailTxt.Text;

                        if(email.Length > 10)
                    {
                        EmailProvider.Email(email, model, _flightModel);
                    }
                        

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
            
    }
}
