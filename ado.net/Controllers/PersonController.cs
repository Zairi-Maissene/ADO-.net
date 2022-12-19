using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ado.net.Models;

namespace ado.net.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult All()
        {
            List<Person> result = Personal_info.getAllPerson();
            ViewBag.Result = result;
            return View();
        }
        public ActionResult getById(int id)
        {
            Person person = Personal_info.getPerson(id);
            ViewBag.person = person;

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult getByFirstNameAndCountry(string firstName, string country)
        {
            int id = Personal_info.getByFirstNameAndCountry(firstName, country);
            return Redirect($"/Person/{id}");
        }
    }
}