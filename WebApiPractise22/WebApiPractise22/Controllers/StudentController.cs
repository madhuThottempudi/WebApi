namespace WebApiPractise22.Controllers
{
    public class StudentController
    {
        static void Main(string[] args)
        {
            using(var context = new StudentContextualClass())
            {
                var stud = new Student() { Name= "Angular" };
                context.Students.Add(stud);
                context.SaveChanges();
            }
        }
    }
}
