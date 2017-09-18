using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsCatalog.Models;
using StudentsCatalog.Models.Entities;


namespace StudentsCatalog.Controllers
{
    public class StudentController : Controller
    {
        // Model
        StudentDbContext db = new StudentDbContext();

        // List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            ViewBag.stud = db.Students.ToList();
            return View();
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            db.Students.Add(st);
            db.SaveChanges();
            return View();
        }
        
        //Delete
        public IActionResult Remove()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Remove(Student st)
        {
            db.Students.Remove(st);
            db.SaveChanges();
            return View();
        }
        
        //Update
        
        
        //Search
        public IActionResult Search()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(db.Students.Find(id));
        }
    }
    
    
}