using FBS.DAL;
using FlightBookingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FBS.DAL_2.Authentication
{
    public class DAOAuthentication
    {
        public UserModel Login(String name, String password) {
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
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
                    UserModel model = new UserModel();
                    model.Id = Guid.Parse(dr["Id"].ToString());
                    model.Name = dr["Name"].ToString();
                    model.Surname = dr["Surname"].ToString();
                    model.Password = dr["Password"].ToString();
                    model.Age = (int)dr["Age"];
                    model.RoleId = (int)dr["RoleId"];
                    return model;
                }
                return null;
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
            return null;
        }
        //signupp
        public  int SignUpp(String name, String surname, String password, int age) {
            if (name == null || surname == null || password == null) {
                MessageBox.Show("Fill the data correctly");
                return 0;
            }
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
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

        public int Update_User(UserModel user)
        {
            MySqlConnection cnn = SqlConnection.GetSQLCnn();
            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("Update_User", cnn);
                cmd.Parameters.AddWithValue("@id", user.Id.ToString());
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@age", user.Age);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();

                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!" + ex);
                
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
