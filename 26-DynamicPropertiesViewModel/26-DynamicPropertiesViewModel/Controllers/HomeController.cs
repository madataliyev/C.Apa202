using _26_DynamicPropertiesViewModel.Models;
using _26_DynamicPropertiesViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _26_DynamicPropertiesViewModel.Controllers
{
    public class HomeController : Controller
    {
        List<Student> _student = new List<Student>
        {
            new Student{ Id = 1,Name="Nihad",Surname="Aslanov"},
            new Student{ Id = 2,Name="Fuad",Surname="Movsumov"},
            new Student{ Id = 3,Name="REvan",Surname="Qaragozlu"},
        };

        List<Teacher> _teachers = new List<Teacher>
        {
            new Teacher{ Id = 1,Name="Ali",Salary=2400 },
            new Teacher{ Id = 2,Name="Ehmed",Salary=300 },
        };





        public IActionResult Index()
        {
            //var a = 20;
            //dynamic b = "Salam";
            //var c = a + b;
            //Console.WriteLine(c);

            //ViewBag.Students = _student;
            //ViewData["Students"] = _student;

            //TempData["Name="] = "Emir";


            HomeVm homevm = new()
            {
                Teachers = _teachers,
                Students = _student
            };



            return View(/*_student*/ homevm  );
        }

        public IActionResult Details()
        {
            return View();
        }





        [Route("korporativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
