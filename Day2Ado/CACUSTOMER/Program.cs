using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CACUSTOMER
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
             Console.WriteLine(Directory.GetCurrentDirectory());
            //PrintProduct();
            CustomDisplay();
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void CustomDisplay()
        {
            Customer p1 = new Customer { Id = 1,Name = "Shriya", Address = "Biloli", Mobno = "9049641314" };
            Strongly_type indata = new Strongly_type(_iconfiguration);

            Console.WriteLine("{0} {1} {2} {3}", "storedata");

        }
    }
}