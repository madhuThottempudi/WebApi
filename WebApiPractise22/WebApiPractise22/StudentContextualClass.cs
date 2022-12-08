using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace WebApiPractise22
{
    public class StudentContextualClass : DbContext
    {
        public StudentContextualClass()  :base() 
        { 
           
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
    internal class Program
    {
        public static void Main()
        {
            using (var ctx = new StudentContextualClass())
            {
                var stud = new Student() { Name = "Madhu"};
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
