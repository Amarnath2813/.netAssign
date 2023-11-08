using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Entitynextlevel.Models
{
    public class Bookcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Customerdata;Integrated Security=True;");

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
