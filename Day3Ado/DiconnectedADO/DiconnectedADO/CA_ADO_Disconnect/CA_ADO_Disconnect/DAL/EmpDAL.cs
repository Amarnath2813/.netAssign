using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp_ADO.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp_ADO.DAL
{   
        public class EmpDAL
        {
            private string _connectionString;
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        SqlConnection connection; 
        public EmpDAL(IConfiguration iconfiguration)
            {
                _connectionString = iconfiguration.GetConnectionString("Default");
            connection= new SqlConnection(_connectionString);
        }
       
            public DataTable GetList()
            {
                // Create an instance of SqlDataAdapter. Spcify the command and the connection

                  dataAdapter = new SqlDataAdapter("select * from Employee", connection);
                // Create an instance of DataSet, which is an in-memory datastore for storing tables
                 dataset = new DataSet();
            // Call the Fill() methods, which automatically opens the connection, executes the command 
            // and fills the dataset with data, and finally closes the connection.   //no open method
              dataAdapter.FillSchema(dataset, SchemaType.Source, "Employee");
            dataAdapter.Fill(dataset, "Employee");
                Console.WriteLine(dataset.GetXml());
            dataset.Tables[0].TableName = "Employee";
            DataTable dt = dataset.Tables["Employee"];
          
            return dt;
            }
        public void addindataset()
        {

            DataRow drCurrent = dataset.Tables["Employee"].NewRow();
            //drCurrent["id"] = 7;
            drCurrent["name"] = "viiiidyaaa";
            drCurrent["salary"] = 90000;
            

            dataset.Tables["Employee"].Rows.Add(drCurrent);
            Console.WriteLine("Add was successful, Click any key to continue!!");


          //  SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
          //  Console.WriteLine(co.GetInsertCommand().CommandText);
            dataAdapter.Update(dataset, "Employee");
           }
        public void deletebyid(int id)
        {
            DataRow dd = dataset.Tables[0].Rows.Find(id);
            
            dd.Delete();

            //SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataset, "Employee");
            //Console.WriteLine(co.GetDeleteCommand().CommandText);


        }
        public void updatedata(int id)
        {
            DataRow dd = dataset.Tables[0].Rows.Find(id);

            dd["name"] = "Rajjjaaaa";

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Employee");
          //  Console.WriteLine(co.GetUpdateCommand().CommandText);


        }



    }

}
