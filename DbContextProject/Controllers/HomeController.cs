using DbContextProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DbContextProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Register _db;
        public HomeController(ILogger<HomeController> logger, Register db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var data = (from s in _db.People select s).ToList();
            ViewBag.users = data;
            ViewBag.title = "MVC5 - Hello World";
            return View();
        }

        public IActionResult Privacy()
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
