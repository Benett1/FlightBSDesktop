using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace FBS.DAL
{
    public class DAOFlights : I_Flights
    {

        public List<FlightModel> GetFlights()
        {
            List<FlightModel> listFlights = new List<FlightModel>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
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

        public List<String> GetFlightsId(int AirlinesId)
        {
            List<String> listFlights = new List<String>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Planes", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("roleId", AirlinesId);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listFlights.Add(dr["Id"].ToString());

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

        public List<String> GetFlightsByRole (int roleId)
        {
            List<String> listFlights = new List<String>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Flights_By_Role", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("roleId", roleId);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listFlights.Add(dr["Id"].ToString());

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
        //
        public List<FlightModel> GetFlightsFiltered(String DepartureAirport,String ArrivalAirport)
        {
            List<FlightModel> listFlights = new List<FlightModel>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Flights_Filtered", cnn);
                cmd.Parameters.AddWithValue("DepartureAirportIN",DepartureAirport);
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
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Flight", cnn);
                cmd.Parameters.AddWithValue("FlightId", Id.ToString());
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

        public void AddFlight(FlightModel flightModel, Guid dep, Guid arr)
        {
            FlightModel Flight = new FlightModel();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Register_Flight", cnn);
                cmd.Parameters.AddWithValue("Id", flightModel.Id.ToString());
                cmd.Parameters.AddWithValue("PlaneId", flightModel.PlaneId.ToString());
                cmd.Parameters.AddWithValue("DepartureAirport", dep.ToString());
                cmd.Parameters.AddWithValue("ArrivalAirport", arr.ToString());
                cmd.Parameters.AddWithValue("DateTime", flightModel.DateTime);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight has been added");
                
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

        public void UpdateFlight(FlightModel flightModel, Guid dep, Guid arr)
        {
            MySqlConnection cnn = SqlConnection.GetSQLCnn();

            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Update_Flight", cnn);
                cmd.Parameters.AddWithValue("FlightId", flightModel.Id.ToString());
                cmd.Parameters.AddWithValue("PlaneId", flightModel.PlaneId.ToString());
                cmd.Parameters.AddWithValue("DepartureAirport", dep.ToString());
                cmd.Parameters.AddWithValue("ArrivalAirport", arr.ToString());
                cmd.Parameters.AddWithValue("DateTime", flightModel.DateTime);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight has been edited");
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
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("Delete_Flight", cnn);
                cmd.Parameters.AddWithValue("Id", Id.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight Deleted Successfully :)");
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
