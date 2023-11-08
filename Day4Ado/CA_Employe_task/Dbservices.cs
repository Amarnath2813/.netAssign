using CA_Employe_task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Employe_task
{
    internal class Dbservices
    {
        private readonly Companyc cd = new Companyc();
        public void Display()
        {
            foreach(var r in cd.Employees.ToList<Employee>())
            {
                Console.WriteLine(r);
            }
         
        }
        public List<Employee>  Customquery(int dep)
        {
            FormattableString sql = $"SELECT * FROM Employees WHERE DepId=1";
            var emplist = cd.Employees.FromSql(sql).ToList() ;
            return emplist ;
        }
        public void AddEmployee(Employee emp)
        {
            cd.Add<Employee>(emp);
            cd.SaveChanges();
        }
        public void Delete(int id) { 
        
            Employee emp = cd.Employees.SingleOrDefault<Employee>((emp)=>emp.EmloyeeId == id);
            if(emp!= null)
            {
                cd.Remove<Employee>(emp);
                cd.SaveChanges();
            }

            
        }
        public void liq()
        {
            var r = cd.Employees.Join(cd.Department, (s) => s.DepId, (m) => m.Id, (r, t) => new { r.Name, t.DepName });
            foreach(var result in r)
            {
                Console.WriteLine(result.Name+" "+result.DepName);
               
            }


        }
        public List<Employee> Customquery1()
        {
            FormattableString sql = $"SELECT * FROM Employees WHERE Salary>80000";
            var emplist = cd.Employees.FromSql(sql).ToList();
            return emplist;
        }
        public List<Employee> Customquery2()
        {
            FormattableString sql = $"SELECT * FROM Employees WHERE Name LIKE 'S%'";
            var emplist = cd.Employees.FromSql(sql).ToList();
            return emplist;
        }
    }
}
