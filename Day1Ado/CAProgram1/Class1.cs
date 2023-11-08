using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CAProgram1
{
    internal class Employee
    {
        private string _connectionstring;
        public Employee(IConfiguration iconfiguration)
        {
            _connectionstring = iconfiguration.GetConnectionString("deafault");

        }
        public void Emp_method()
        {
            using(SqlConnection conn = new SqlConnection(_connectionstring))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", conn);
                conn.Open();
                Console.WriteLine("Connected");
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", dr["Id"], dr["Name"], dr["Salaray"]);
                    }
                }

            }

        }
    }
}
