using ConsoleApp_ADO.DAL;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CA_ADO_Disconnect
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintProduct();
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintProduct()
        {
            var empdal = new EmpDAL(_iconfiguration);
            var dt = empdal.GetList();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("----------------------------------");
            }
         
            
            //empdal.updatedata(1);
             empdal.addindataset();
            empdal.deletebyid(5);


            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}