using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_Examplehard.Models
{
    internal class SchoolContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Customerdata;Integrated Security=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
