using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class CourseController1 : Controller
    {
        public IActionResult Index()
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository StudentRepository = new StudentRepository(universityContext);
            foreach (String s in StudentRepository.GetCourses())
                Debug.WriteLine(s);

            return View(StudentRepository.GetCourses());
        }
        public IActionResult GetCourse(string id)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository StudentRepository = new StudentRepository(universityContext);
            IEnumerable<Student> res = (IEnumerable<Student>)StudentRepository.Find(v => v.course.ToLower() == id.ToLower());
            //foreach (Student s in res)
            //{
            //    Debug.WriteLine(s.id);
            //} 

            if (res.Count() != 0) ViewBag.Id = res.First().course;
            return View(res);
        
        }
    }
}
