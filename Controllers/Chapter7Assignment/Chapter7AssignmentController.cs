using dnd.Models.Chapter7Assignment;
using dnd.Models.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dnd.Controllers
{
    public class Chapter7AssignmentController : Controller
    {
        //import context from the database which stores user information
        private UserContext Context { get; set; }

        //pass that context object to the controller
        public Chapter7AssignmentController(UserContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("[controller]/[action]/{id?}")]
        public IActionResult List(int acc)
        {
            Student currentstudent = new();
            currentstudent.Id = 10;
            currentstudent.FirstName = "user";
            currentstudent.LastName = "user";
            currentstudent.Grade = "A";
            currentstudent.AccessLevel = acc;
            List<Student> students = Context.Students.ToList();
            if (currentstudent.AccessLevel <= 2)
            {
                return RedirectToAction("Index");
            }
            else if (currentstudent.AccessLevel > 2 && currentstudent.AccessLevel < 8)
            {
                ViewBag.Admin = false;
                ViewBag.HasAccess = true;
                return View(students);
            }
            else if (currentstudent.AccessLevel >= 8)
            {
                ViewBag.Admin = true;
                ViewBag.HasAccess = true;
                return View(students);
            }
            else
            {
                return View(students);
            }
        }
    }
}
