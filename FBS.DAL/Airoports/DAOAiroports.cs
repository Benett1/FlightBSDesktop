using FlightBookingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBS.DAL.Aeroports
{
    public class DAOAiroports
    {
        public static MySqlConnection GetSQLCnn()
        {
            return new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }
        public List<AirportModel> GetAeroports()
        {

            List<AirportModel> airports = new List<AirportModel>();
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Get_Airports", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AirportModel airportModel = new AirportModel();
                    airportModel.Id = Guid.Parse(dr["Id"].ToString());
                    airportModel.LocationID = Guid.Parse(dr["LocationID"].ToString());
                    airportModel.Name = dr["Name"].ToString();
                    airports.Add(airportModel);
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return airports;
        }
    }
}

