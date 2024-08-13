using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TestTask_MvcApp.Data;
using TestTask_MvcApp.Models;

namespace TestTask_MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private TestTaskDbContext ctx;

        public HomeController(TestTaskDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            ViewBag.Persons =
                ctx.Persons
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult CreateAspNet(Person model)
        {
            model.SentByJS = false;

            ctx.Persons.Add(model);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult QueryData()
        {
            string sqlQuery = "SELECT * FROM Persons WHERE Id % 3 = 0";
            ViewBag.ExecutionString = sqlQuery;

            var persons = ctx.Persons.FromSqlRaw(sqlQuery).ToList();

            return View(persons);
        }

        [HttpPost]
        public IActionResult CreateJavaScript(string name, string surname, int age, string profession)
        {
            var person = new Person
            {
                Name = name,
                Surname = surname,
                Age = age,
                Profession = profession,
                SentByJS = true
            };

            ctx.Persons.Add(person);
            ctx.SaveChanges();

            return Json(new { success = true });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
}
