using CA_Examplehard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Examplehard
{
    internal class DbServices
    {
        private static readonly SchoolContext db = new SchoolContext();
        public void Display()
        {
            foreach (var r in db.Students.ToList<Student>())
            {
                Console.WriteLine(r);
            }
        }
        public void Adddata(Student student)
        {
            db.Add<Student>(student);
            //db.SaveChanges();
        }
        public void Delete(int id)
        {
            Student student = db.Students.SingleOrDefault<Student>((stu) => stu.StudentId == id);
            if (student != null)
            {
                db.Remove<Student>(student);
                db.SaveChanges();
            }
        }
        public List<Student> Customquery(string name)
        {
            FormattableString sql = $"SELECT * FROM Students WHERE FirstName ={name}";
            var studentlist = db.Students.FromSql(sql).ToList();
            return studentlist;


        }

        public void Liqdemo()
        {
            var r = db.Students.Join(db.Grades, (sg) => sg.GradeId, (gi) => gi.Id, 
                (r, g) => new { Name = r.FirstName, Gradename = g.GradeName });
            foreach (var result in r)
            {
                Console.Write(result.Gradename + " ");
                Console.WriteLine(result.Name);

            }
        }
    }
}
