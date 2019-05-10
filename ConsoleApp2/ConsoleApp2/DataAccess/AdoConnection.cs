using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class AdoConnection
    {
        private SqlConnection sqlConn;

        public AdoConnection()
        {
            sqlConn = new SqlConnection("Data Source = SQL_core02_des; Initial Catalog = NET_PRU; Persist Security Info = True; User ID = usr_core; Password = AO.2016");
        }

        public async Task<int> QueryAdoNetHardCode()
        {
            List<string> result = new List<string>();
            try
            {
                sqlConn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from RUT_cliente", sqlConn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(reader["rut_dv"].ToString());
                    }
                    sqlConn.Close();
                }
            }
            catch
            {
                throw;
            }

            return result.Count;
        }

        public async Task<int> QueryAdoNetProcedure()
        {
            List<string> result = new List<string>();
            try
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = sqlConn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "PGET_ALL_CLIENTS"
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add( reader["rut_dv"].ToString());
                }
                sqlConn.Close();
                
            }
            catch
            {
                throw;
            }

            return result.Count;
        }
    }
}

