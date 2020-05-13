using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreTest.Controllers
{
    public class BootstrapTestController : Controller
    {
        public IActionResult BootstrapTestIndex()
        {
            return View();
        }
    }
}