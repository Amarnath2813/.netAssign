using _01entity.Controllers;
using _01entity.Models;
using _01entity.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace _01entity
{
    internal class Program
    {
        private static BookControllerdemo Controllerobj;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var services = new ServiceCollection();
 
              services.AddTransient<ISqlrepository, SqlService>();
              services.AddTransient<BookControllerdemo>();
              services.AddTransient<SampleContext>();
              
            var serviceProvider = services.BuildServiceProvider();
            
          
            Controllerobj = serviceProvider.GetService<BookControllerdemo>();

          

            Book obj1 = new Book() { Title = "New Thinking in Java", AuthorId = 2 };
            Controllerobj.Add(obj1);
            Book obj2 = new Book() { Title = "Now in Java", BookId = 4 };
            Controllerobj.Put(obj2);
            Controllerobj.Delete(3);

            List<Book> booklist = Controllerobj.GetBooks();
            foreach (Book book in booklist)
                Console.WriteLine(book.Title);

        }
    }
}