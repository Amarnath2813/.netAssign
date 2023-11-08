using CA_ADO_01;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoassign2
{
    public class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
              GetAppSettingsFile();
            //Console.WriteLine(Directory.GetCurrentDirectory());
            PrintProduct();
        }

        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintProduct()
        {
            Productlayer obj = new Productlayer(_iconfiguration);
            obj.Products();
            obj.product_insert();
            
           
            
     


        }
    }
}