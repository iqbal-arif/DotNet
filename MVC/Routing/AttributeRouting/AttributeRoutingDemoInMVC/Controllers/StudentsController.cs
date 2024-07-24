using AttributeRoutingDemoInMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeRoutingDemoInMVC.Controllers
{
    public class StudentsController : Controller
    {
¹<Student>()
        {
            new Student() { Id = 1, Name = "Pranaya" },
            new Student() { Id = 2, Name = "Priyanka" },
            new Student() { Id = 3, Name = "Anurag" },
            new Student() { Id = 4, Name = "Sambit" },
            new Student() { Id = 5, Name = "Arvin" },
           new Student() { Id = 4, Name = "Wasti" }
        };

        [HttpGet]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        [HttpGet]
        public ActionResult GetStudentByID(int studentID)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentDetails);
        }

        [HttpGet]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();

            if (studentID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };

            ViewBag.CourseList = CourseList;

            return View();
        }
    }
}
