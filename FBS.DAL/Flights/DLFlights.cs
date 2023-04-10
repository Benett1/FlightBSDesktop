using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FBS.DAL
{
    public class DLFlights : I_Flights
    {
        public static MySqlConnection GetSQLCnn()
        {
            return new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }

        public List<FlightModel> GetFlights()
        {
            List<FlightModel> listFlights = new List<FlightModel>();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();
               
                MySqlCommand cmd = new MySqlCommand("List_Flights",cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        FlightModel flight = new FlightModel();
                        flight.Id = (Guid)dr["Id"];
                        flight.PlaneId = (Guid)dr["PlaneId"];
                        flight.DepartureAirport = (Guid)dr["DepartureAirport"];
                        flight.ArrivalAirport = (Guid)dr["ArrivalAirport"];
                        flight.DateTime = (DateTime)dr["DateTime"];
                        listFlights.Add(flight);

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

        public FlightModel GetFlightById(Guid Id)
        {
            FlightModel Flight = new FlightModel();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Flight("+Id+")", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Flight.Id = (Guid)dr["Id"];
                    Flight.PlaneId = (Guid)dr["PlaneId"];
                    Flight.DepartureAirport = (Guid)dr["DepartureAirport"];
                    Flight.ArrivalAirport = (Guid)dr["ArrivalAirport"];
                    Flight.DateTime = (DateTime)dr["DateTime"];
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
            return Flight;
        }

        public void AddFlight(FlightModel flightModel)
        {
            FlightModel Flight = new FlightModel();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Register_Flight(@Id, @PlaneId, @DepartureAirport, @ArrivalAirport, @DateTime)", cnn);
                cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@PlaneId", flightModel.PlaneId);
                cmd.Parameters.AddWithValue("@DepartureAirport", flightModel.DepartureAirport);
                cmd.Parameters.AddWithValue("@ArrivalAirport", flightModel.ArrivalAirport);
                cmd.Parameters.AddWithValue("@DateTime", flightModel.DateTime);
                cmd.ExecuteNonQuery();
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

        public void UpdateFlight(FlightModel flightModel)
        {
            FlightModel Flight = new FlightModel();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Update_Flight(@Id, @PlaneId, @DepartureAirport, @ArrivalAirport, @DateTime)", cnn);
                cmd.Parameters.AddWithValue("@Id", flightModel.Id);
                cmd.Parameters.AddWithValue("@PlaneId", flightModel.PlaneId);
                cmd.Parameters.AddWithValue("@DepartureAirport", flightModel.DepartureAirport);
                cmd.Parameters.AddWithValue("@ArrivalAirport", flightModel.ArrivalAirport);
                cmd.Parameters.AddWithValue("@DateTime", flightModel.DateTime);
                cmd.ExecuteNonQuery();
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

        public void DeleteFlight(Guid Id)
        {
            FlightModel Flight = new FlightModel();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Delete_Flight(@Id)", cnn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
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
