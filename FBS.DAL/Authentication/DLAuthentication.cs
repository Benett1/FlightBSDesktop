using FlightBookingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBS.DAL_2.Authentication
{
    public class DLAuthentication
    {
        public  MySqlConnection GetSQLCnn()
        {
            return new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }
        //login
        public int Login(String name, String password) {
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Login", cnn);
                cmd.Parameters.AddWithValue("@Username", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    return 1;
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
            return 0;
        }
        //signupp
        public  int SignUpp(String name, String surname, String password, int age) {
            MySqlConnection cnn = GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Register_User", cnn);
                cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString("N"));
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@RoleId", 1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();

                return 1;
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
            return 0;
        }
    }
}
