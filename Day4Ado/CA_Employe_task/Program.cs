using CA_Employe_task.Models;

namespace CA_Employe_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dbservices dbservices = new Dbservices();
             
            List<Employee> li = dbservices.Customquery(1);
            foreach (Employee emp in li)
            {
                Console.WriteLine(emp);
            }
            Employee e= new Employee() { 
                Name = "Shriya", Salary = 90000,
                DepId=1
                
            };
             dbservices.AddEmployee(e);
              dbservices.Delete(3);
              dbservices.Display();
            dbservices.liq();
            List<Employee> li1 = dbservices.Customquery1();
            foreach (Employee emp in li1)
            {
                Console.WriteLine(emp);
            }
            List<Employee> li2 = dbservices.Customquery2();
            foreach (Employee emp in li2)
            {
                Console.WriteLine(emp);
            }
        }

    }
}