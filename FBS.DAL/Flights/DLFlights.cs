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
               
                MySqlCommand cmd = new MySqlCommand("Get_Flights",cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        FlightModel flight = new FlightModel();
                        flight.Id = Guid.Parse(dr["Id"].ToString());
                        flight.PlaneId = Guid.Parse(dr["PlaneId"].ToString());
                        flight.DepartureAirport = (dr["DepartureAirport"].ToString());
                        flight.ArrivalAirport = (dr["ArrivalAirport"].ToString());
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

        public List<FlightModel> GetFlightsFiltered(String DepartureAirport,String ArrivalAirport)
        {
            List<FlightModel> listFlights = new List<FlightModel>();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Flights_Filtered", cnn);
                cmd.Parameters.AddWithValue("@DepartureAirportIN",DepartureAirport);
                cmd.Parameters.AddWithValue("ArrivalAriportIN", ArrivalAirport);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FlightModel flight = new FlightModel();
                    flight.Id = Guid.Parse(dr["Id"].ToString());
                    flight.PlaneId = Guid.Parse(dr["PlaneId"].ToString());
                    flight.DepartureAirport = (dr["DepartureAirport"].ToString());
                    flight.ArrivalAirport = (dr["ArrivalAirport"].ToString());
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
                    Flight.DepartureAirport =dr["DepartureAirport"].ToString();
                    Flight.ArrivalAirport = dr["ArrivalAirport"].ToString();
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
