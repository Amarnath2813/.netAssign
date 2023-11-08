using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CUSTOMER
{
    internal class Strongly_Type
    {
        private string _connectionstring;
        public Strongly_Type(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("Default");

        }
        public SqlConnection getConnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = _connectionstring;
            return sqlconn;
        }
        public int Storedata(Customer c)
        {
            SqlConnection S = null;
            SqlCommand sqlCommand;
            int record = 0;
            try
            {
                S = getConnection();
                sqlCommand = new SqlCommand("Storedata", S);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value=c.Id;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = c.Name;
                sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = c.Address;
                sqlCommand.Parameters.Add("@mobno", SqlDbType.NVarChar).Value = c.Mobno;
                S.Open();
                record = sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Rows affected"+record);
            }
            catch (SqlException ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                S.Close();
            }
            return record;

        }
        public void disp_data()
        {
            try
            {
                SqlConnection S = getConnection();
                SqlCommand sqlCommand = new SqlCommand("Showdata", S);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value=;
                S.Open();
                Console.WriteLine("Connected");
                SqlDataReader sq = sqlCommand.ExecuteReader();
                if (sq.HasRows)
                {
                    while (sq.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", sq["Id"], sq["Name"], sq["Address"], sq["Mobno"]);
                    }
                }
                Console.WriteLine("----------------------------");
                
                Console.WriteLine("Display all data");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int deletedata(int id)
        {
            SqlConnection s = null;
            SqlCommand sqlCommand;
            int record = 0;
            try
            {
                s = getConnection();
                sqlCommand = new SqlCommand("DELDATA", s);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value = id;
                s.Open();
                record = sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Rows Deleted from db" + record);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Close();
            }
            return record;

        }
        public Customer search(int id)
        {
            SqlConnection s = null;
            SqlCommand sqlCommand;
            Customer c = null;
           
            try
            {
                s = getConnection();
                sqlCommand = new SqlCommand("Search", s);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                s.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        c=new Customer();
                        c.Id=Convert.ToInt32(reader["Id"]);
                        c.Name = Convert.ToString(reader["Name"]);
                        c.Address = Convert.ToString(reader["Address"]);
                        c.Mobno = Convert.ToString(reader["Mobno"]);

                        break;
                    }
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("Search Completed for ID");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                s.Close();
            }
            return c;
        }
        public List<Customer> searchp(string name,string mobno)
        {
            SqlConnection s = null;
            SqlCommand sqlCommand;

            List<Customer> l1 = new List<Customer>();

            try
            {
                

                s = getConnection();
               // sqlCommand = new SqlCommand("SELECT * FROM Customer WHERE Name=@name and Mobno=@mobno",s);
                sqlCommand = new SqlCommand("SEARCHP", s);

                 sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@mobno", SqlDbType.NVarChar).Value = mobno;

                s.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {

                        Customer c1 = new Customer();
                        c1.Id = Convert.ToInt32(reader["Id"]);
                        c1.Name = Convert.ToString(reader["Name"]);
                        c1.Address = Convert.ToString(reader["Address"]);
                        c1.Mobno = Convert.ToString(reader["Mobno"]);
                        l1.Add(c1);

                        break;
                    }
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("Search Completed for name and mobile no");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return l1;

        }
        public void Update_Record(string name,string mobno)
        {
            SqlConnection conn = null;
            SqlCommand sqlCommand;
            int id = 122;
           
            try
            {
                conn = getConnection();
                sqlCommand = new SqlCommand("UPDATEREC", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@mobno", SqlDbType.NVarChar).Value = mobno;
                sqlCommand.Parameters.Add("@tid", SqlDbType.NVarChar).Value = id;
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("UPDATED NAME AND MOBNO IN DB");
                Console.WriteLine("----------------------------");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
