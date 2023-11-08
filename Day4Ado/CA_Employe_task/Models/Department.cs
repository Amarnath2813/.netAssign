using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA_Employe_task.Models
{
    internal class Department
    {
        [Key]
        public int? Id { get; set; }
        public string? DepName {  get; set; }
        [ForeignKey("DepId")]
        public List<Employee?> Employee { get; set; }
    }
}
