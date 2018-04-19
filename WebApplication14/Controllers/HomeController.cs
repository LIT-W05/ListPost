using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPeople(IEnumerable<Person> people)
        {
            foreach (Person person in people)
            {
                PersonDb.Add(person);
            }

            return Redirect("/home/viewall");
        }

        public ActionResult ViewAll()
        {
            ViewAllViewModel vm = new  ViewAllViewModel();
            vm.People = PersonDb.GetAll();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Update(Person person)
        {
            PersonDb.Update(person);
            return Redirect("/home/viewall");
        }
    }
}