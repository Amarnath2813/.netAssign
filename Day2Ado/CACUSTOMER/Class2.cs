using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.AccessControl;

namespace CACUSTOMER
{
    internal class Strongly_type
    {
        private string _connectionstring;
        public Strongly_type(IConfiguration iconfiguration)
        {
            _connectionstring = iconfiguration.GetConnectionString("Default");
        }
        public SqlConnection getconnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = _connectionstring;
            return sqlconn;
        }
        public void AddData(Customer e)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("storedata", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@pname", SqlDbType.NVarChar);
                sqlcmd.Parameters.AddWithValue("@pid", SqlDbType.Int);
                sqlconn.Open();
               
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                sqlconn.Close();
            }
          
        }
    }
}
