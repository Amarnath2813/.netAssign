using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_Employe_task.Models
{
    internal class Companyc:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Customerdata;Integrated Security=True;");

        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}
