using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople() 
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Melissa", LastName = "de Reus", Age = 28 });
            people.Add(new PersonModel { FirstName = "Daniel", LastName = "Meier", Age = 33 });
            people.Add(new PersonModel { FirstName = "Jantine", LastName = "van Twist", Age = 29 });

            return View(people);

        }
    }
}