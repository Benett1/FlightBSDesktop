using FlightBookingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FBS.DAL.Bookings
{
    public class DAOBookings
    {
        public List<BookingsModel> GetBookings()
        {
            List<BookingsModel> listFlights = new List<BookingsModel>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Bookings", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BookingsModel model = new BookingsModel();
                    model.Id = Guid.Parse(dr["Id"].ToString());
                    model.FlightId = Guid.Parse(dr["FlightId"].ToString());
                    model.UserId = Guid.Parse(dr["UserId"].ToString());
                    model.Name = dr["Name"].ToString();
                    model.Surname = dr["Surname"].ToString();
                    model.Age = int.Parse(dr["Age"].ToString());
                    model.Seat = int.Parse(dr["Seat"].ToString());
                    //model.baggage = dr["Baggage"];
                    listFlights.Add(model);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return listFlights;
        }
        //Get_Bookings_By_Flight

        public List<int> GetBookingsByFlightId(Guid Id)
        {
            List<int> seats = new List<int>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Bookings_By_Flight", cnn);
                cmd.Parameters.AddWithValue("flightId", Id.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    seats.Add(int.Parse(dr["Seat"].ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return seats;
        }

        public List<BookingsModel> GetBookingsByUserId(Guid UserId)
        {
            List<BookingsModel> listFlights = new List<BookingsModel>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Bookings_By_UserId", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("userId", UserId.ToString());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BookingsModel model = new BookingsModel();
                    model.Id = Guid.Parse( dr["Id"].ToString());
                    model.FlightId = Guid.Parse(dr["FlightId"].ToString());
                    model.UserId = Guid.Parse(dr["UserId"].ToString());
                    model.Name = dr["Name"].ToString();
                    model.Surname = dr["Surname"].ToString();
                    model.Age = int.Parse(dr["Age"].ToString());
                    model.Seat = int.Parse(dr["Seat"].ToString());
                    model.baggage = bool.Parse( dr["Baggage"].ToString());
                    listFlights.Add(model);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return listFlights;
        }

       

        public void AddBooking(BookingsModel bookingsModel)
        {
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Register_Booking", cnn);
                cmd.Parameters.AddWithValue("Id", bookingsModel.Id.ToString());
                cmd.Parameters.AddWithValue("FlightId", bookingsModel.FlightId.ToString());
                cmd.Parameters.AddWithValue("UserId", bookingsModel.UserId.ToString());
                cmd.Parameters.AddWithValue("Name", bookingsModel.Name);
                cmd.Parameters.AddWithValue("Surname", bookingsModel.Surname);
                cmd.Parameters.AddWithValue("Age", bookingsModel.Age);
                cmd.Parameters.AddWithValue("Seat", bookingsModel.Seat);
                cmd.Parameters.AddWithValue("Baggages", bookingsModel.baggage);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking has been added");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public void DeleteBooking(Guid Id)
        {
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Delete_Booking", cnn);
                cmd.Parameters.AddWithValue("id", Id.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Deleted Successfully :)");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }
    }
}
