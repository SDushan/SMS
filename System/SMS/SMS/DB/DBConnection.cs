using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace SMS.DB
{
    public class DBConnection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString);
            return conn;
        }

        public string insert(string query)
        {
            string queryExecuteSuccess = "failed";
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);               
                cmd.ExecuteNonQuery();
                conn.Close();
                return queryExecuteSuccess = "success";
            }
            catch(Exception ex)
            {
                throw ex;
                return queryExecuteSuccess;
            }

        }
        
    }


}