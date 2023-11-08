using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CA_D3_1ex
{
    internal class Program
    {
        private static IConfiguration configuration;
        static void Main(string[] args)
        {
            GetAppSettingFile();
            printproduct();
        }
        static void GetAppSettingFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();
        }
        static void printproduct()
        {
            var emp = new EmployeeDetail(configuration);
            var d = emp.Getlist();
            foreach (DataRow row in d.Rows)
            {
                foreach (DataColumn col in d.Columns)

                    Console.WriteLine(row[col] + " ");
                Console.WriteLine("---------------------------");


            }
            emp.addindataset();


        }
    }
}