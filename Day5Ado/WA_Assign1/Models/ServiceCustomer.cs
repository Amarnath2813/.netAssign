using System.Security.Cryptography.X509Certificates;

namespace WA_Assign1.Models
{
    public class ServiceCustomer : ICustomer
    {
        private static List<Customer> _customerlist;
        public ServiceCustomer()
        {
            _customerlist = new List<Customer>()
           {
               new Customer() {Id=1,Name="Shrunkhala",Mobno="9387428291",BillAmount=82746},
               new Customer() {Id=2,Name="Yash",Mobno="9823191813",BillAmount=930846},
               new Customer() {Id=3,Name="Shubham",Mobno="8349863913",BillAmount=294867},
               new Customer() {Id=4,Name="Shriya",Mobno="9361635363",BillAmount=29746821}
           };
               
        }
        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerlist;
            
        }
    }
}
