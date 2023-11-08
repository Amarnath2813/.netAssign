using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace CA_D3_1ex
{

    internal class EmployeeDetail
    {
        private string _connectionstring;
        SqlDataAdapter _adapter;
        DataSet d;
        SqlConnection _connection;
        public EmployeeDetail(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("Default");
            _connection = new SqlConnection(_connectionstring);
        }
        public DataTable Getlist()
        {
            _adapter = new SqlDataAdapter("select * from Employee", _connection);
            d = new DataSet();
            _adapter.FillSchema(d, SchemaType.Source);
            _adapter.Fill(d);
            d.Tables[0].TableName = "Employee";
            Console.WriteLine(d.GetXml());
           
            DataTable dt = d.Tables["Employee"];

            return dt;
        }
        public void addindataset()
        {
            DataRow drcurrent = d.Tables["Employee"].NewRow();
            //drcurrent["Id"] = 1;
            drcurrent["Name"] = "Asha";
            drcurrent["Salaray"] = 8396491;
            Console.WriteLine("Add was successful, Click any key to continue!!");


              SqlCommandBuilder co = new SqlCommandBuilder(_adapter);
              Console.WriteLine(co.GetInsertCommand().CommandText);
            _adapter.Update(d, "Employee");
        }

    }
}
