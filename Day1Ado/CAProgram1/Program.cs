using Microsoft.Extensions.Configuration;

namespace CAProgram1
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;



        static void Main(string[] args)
        {
            GetAppSettingfile();
            PrintEmployee();


        }
        static void GetAppSettingfile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintEmployee()
        {
            Employee e = new Employee(_iconfiguration);
            e.Emp_method();
        }
    }
}