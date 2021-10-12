using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
   
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
            
        }

        public IActionResult Razor() => View("~/Views/Home/Razor.cshtml");


        [HttpPost]
        public IActionResult Count()
        {
           
             ViewData["number"] = int.Parse(Request.Form["number"]);
            return View("~/Views/Home/Count.cshtml","~/Views/Shared/Layout.cshtml");

            
        }



        public IActionResult CreatePerson() => View("~/Views/Home/CreatePerson.cshtml","~/Views/shared/Layout.cshtml");

        [HttpPost]
        public IActionResult DisplayPerson(Models.Person person)
        {
            person.Age = Request.Form["age"];
            person.First_name = Request.Form["fname"];
            person.description = Request.Form["description"];
            person.Last_name = Request.Form["lname"];
            person.password = Request.Form["lname"];
            person.Date_of_birth = Request.Form["dob"];
            person.EmailAddress = Request.Form["email"];

            return View(person);

        }

        public IActionResult Error()
        {
            return View();
        }

       
    }
}
