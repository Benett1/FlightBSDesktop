using FlightBookingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBS.DAL.Locations
{
    public class DAOLocatinos
    {
        public List<LocationModel> AllLocations() {

            List<LocationModel> locations = new List<LocationModel>();
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("All_Locations", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    LocationModel location = new LocationModel();
                    location.Id = Guid.Parse(dr["Id"].ToString());
                    location.Country = dr["Country"].ToString();
                    location.City = dr["City"].ToString();
                    locations.Add(location);
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
            return locations;
        }
    }
}
