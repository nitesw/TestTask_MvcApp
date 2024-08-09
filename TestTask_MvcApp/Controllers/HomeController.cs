using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
