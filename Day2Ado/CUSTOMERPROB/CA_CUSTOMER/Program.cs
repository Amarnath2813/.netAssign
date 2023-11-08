
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CA_CUSTOMER
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingfile();
            CustomerDisplay();

            del_data();
          
            search_data();
            searchp_data();
            Update_data();
            show_table();
        }
        static void GetAppSettingfile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void CustomerDisplay()
        {

            Strongly_Type intdata = new Strongly_Type(_iconfiguration);
            intdata.Storedata(new Customer() { Id = 1863, Name = "Amar", Address = "Biloli", Mobno = "9049641314" });


        }
        static void show_table()
        {
            Strongly_Type showdata = new Strongly_Type(_iconfiguration);
            showdata.disp_data();
        }
        static void del_data()
        {
            Strongly_Type deldata = new Strongly_Type(_iconfiguration);
            deldata.deletedata(1328);
        }
        static void search_data()
        {


            Strongly_Type indata = new Strongly_Type(_iconfiguration);


            Console.WriteLine("----------------------------");
            Customer r = indata.search(4);
            Console.WriteLine("{0}{1}{2}{3}", r.Id, r.Name, r.Address, r.Mobno);



        }
        static void searchp_data()
        {


            Strongly_Type indata = new Strongly_Type(_iconfiguration);


            Console.WriteLine("----------------------------");
            List<Customer> ls = indata.searchp("Yash", "9823191893");
            foreach (var x in ls)
                Console.WriteLine("{0}  {1}  {2} {3}", x.Id, x.Name, x.Address,x.Mobno);

        }
        static void Update_data()
        {
            Strongly_Type indata = new Strongly_Type(_iconfiguration);
            Console.WriteLine("---------------------------");
            indata.Update_Record("Akshay", "200");
        }
    }
}