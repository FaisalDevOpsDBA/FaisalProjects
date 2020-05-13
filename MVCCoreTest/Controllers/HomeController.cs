using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreTest.Models;
using CoreBusinessObjectsTest;

namespace MVCCoreTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //throw new DivideByZeroException();
            Fruit fruit = new Fruit()
            {
                Id = 1,
                Color = "Green",
                Size = "Small",
                Name = "Grapes"
            };
            return View(fruit);
        }

        [HttpPost]
        public IActionResult SaveFruit(Fruit fruit)
        {
            return View(fruit);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
