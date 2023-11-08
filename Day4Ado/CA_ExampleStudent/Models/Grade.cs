using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CA_Examplehard.Models
{
    internal class Grade
    {
        [Key]
        public int Id { get; set; }
        public string? GradeName { get; set; }
        public string? Section { get; set; }
        //ye niche vala must he one to many relationship ke liye
        public IList<Student?> Students { get; set; }
        //upar vale ko navigation property hota he

    }
}
