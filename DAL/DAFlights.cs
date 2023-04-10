using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    public class DAFlights
    {
        public static SqlConnection GetSQLCnn()
        {
            return new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));

        }

        public static List<Department> ListaDepartament()
        {
            List<Department> lst = new List<Department>();

            SqlConnection cnn = GetSQLCnn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDepartmentList";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Department d = new Department();

                    d.DepID = dr["DepID"].ToString();
                    d.DepDesc = dr["DepDesc"].ToString();

                    lst.Add(d);

                }

            }
            catch (Exception e)
            {
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }

            return lst;

        }



        public static void DepartmentNew(Department d)
        {
            SqlConnection cnn = GetSQLCnn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDepartmentRi";
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cnn.Open();
                cmd.Connection = cnn;


                ///*SqlParameter prm =*/ cmd.Parameters.Add("@prmDepID", SqlDbType.Int);
                //prm.Direction = ParameterDirection.Input;
                //prm.Value = int.Parse(d.DepID);

                SqlParameter prm = cmd.Parameters.Add("@DepDesc", SqlDbType.VarChar);
                prm.Direction = ParameterDirection.Input;
                prm.Value = d.DepDesc;

                prm = cmd.Parameters.Add("@UserId", SqlDbType.Int);
                prm.Direction = ParameterDirection.Input;
                prm.Value = 1;

                prm = cmd.Parameters.Add("@prmError", SqlDbType.Int);
                prm.Direction = ParameterDirection.Output;
                prm.Value = 0;

                cmd.ExecuteNonQuery();


            }

            catch (SqlException sqlEx)
            {

            }
            catch (Exception ex)
            { }

            finally
            {
                cmd.Dispose();
                cnn.Dispose();
            }



        }



        public static void DepartmentEdit(Department d)
        {
            SqlConnection cnn = GetSQLCnn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDepartmentRi";
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cnn.Open();
                cmd.Connection = cnn;


                SqlParameter prm = cmd.Parameters.Add("@prmDepID", SqlDbType.Int);
                prm.Direction = ParameterDirection.Input;
                prm.Value = int.Parse(d.DepID);

                prm = cmd.Parameters.Add("@prmDepDesc", SqlDbType.VarChar);
                prm.Direction = ParameterDirection.Input;
                prm.Value = d.DepDesc;


                prm = cmd.Parameters.Add("@prmError", SqlDbType.Int);
                prm.Direction = ParameterDirection.Output;
                prm.Value = 0;

                cmd.ExecuteNonQuery();


            }

            catch (SqlException sqlEx)
            {

            }
            catch (Exception ex)
            { }

            finally
            {
                cmd.Dispose();
                cnn.Dispose();
            }



        }
    }
}
