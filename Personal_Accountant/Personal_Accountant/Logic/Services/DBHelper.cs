using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Personal_Accountant.Logic.Services
{
    static public class DBHelper
    {
        public static SqlCommand command;

        private static SqlConnection GetSqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;


            return new SqlConnection(builder.ConnectionString);
        }
        //add ,update,delete ,reset

        public static bool excuteData(string spName, Action Method)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                try
                {
                    command = new SqlCommand(spName, con);
                    command.CommandType = CommandType.StoredProcedure;
                    Method.Invoke();
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            return false;

        }
        //Select
        public static DataTable getData(string spName, Action method)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection connection = GetSqlConnection())
            {
                try
                {
                    command = new SqlCommand(spName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //to excute methoud that contain parmaters
                    method.Invoke();
                    connection.Open();

                    da = new SqlDataAdapter(command);
                    da.Fill(tbl);
                    da.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return tbl;
        }
    }
}
