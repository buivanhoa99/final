using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISachService _ISachService;

        public HomeController(ILogger<HomeController> logger,ISachService service)
        {
            _logger = logger;
            _ISachService = service;
        }

        public IActionResult Index()
        {
            var sachs = _ISachService.GetAllBooks();
            Console.WriteLine(sachs.Count);
            return View(sachs);
        }

        public IActionResult Privacy()
        {

            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult English()
        {
            return View();
        }
        public IActionResult Vietnamese()
        {
            return View();
        }
        public IActionResult EngVie()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
