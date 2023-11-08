using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Examplehard.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        public string? Address {  get; set; }

        public DateTime? DateOfBirth { get; set; }
        public float? height { get; set; }
        public float? weight { get; set; }
        //Principle table ka nam aur id primary key heto dono ko join krke likhna pada
        public int? GradeId {  get; set; }
        public string? Email {  get; set; }

        
        public string? Photo {  get; set; }
        public Grade? Grade { get; set; }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", FirstName, LastName, DateOfBirth, height, weight,GradeId,Photo);
        }
       
    }
}
