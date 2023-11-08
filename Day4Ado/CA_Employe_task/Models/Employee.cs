using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Employe_task.Models
{
    internal class Employee
    {
        [Key]
        public int? EmloyeeId { get; set; }
        public string? Name { get; set; }
        public float? Salary {  get; set; }
        [ForeignKey("DepId")]

        public int? DepId {  get; set; }
        public Department? Department { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}",Name,Salary,DepId);
        }


    }
}
