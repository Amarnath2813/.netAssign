using CA_Examplehard.Models;

namespace CA_Examplehard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices services = new DbServices();
           
            Student student = new Student()
            {
                FirstName = "Ajinkya",
                LastName = "Anavade",
                DateOfBirth = new DateTime(2001, 02, 23, 0, 0, 0),
                height = 52,
                weight = 44,
                GradeId = 4
            
            };
         //   services.Adddata(student);
           services.Liqdemo();

          /* List<Student> li= services.Customquery("Ajinkya");
            foreach(Student s in li)
            {
                Console.WriteLine(s);
            }*/
          //  services.Display();
            
          //  services.Delete(5);
            

        }
    }

}