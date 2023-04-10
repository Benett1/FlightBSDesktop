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
        public static SqlConnection GetSQLCnn()
        {
            return new SqlConnection("data source=34.159.210.136;user id=root;password=x1carbon;database=FBS;Trusted_Connection=yes;");
        }

        public List<FlightModel> GetFlights()
        {
            List<FlightModel> listFlights = new List<FlightModel>();
            MySqlConnection cnn = new MySqlConnection("data source=34.159.210.136;user id=root;password=x1carbon;database=FBS;");
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

                cnn.Close();
            }
           

           // SqlConnection cnn = GetSQLCnn();

         
            //cmd.Connection = cnn;
             cnn.Dispose();
            
            return listFlights;
        }

        public FlightModel GetFlightById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void AddFlight(FlightModel flightModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateFlight(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteFlight(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
