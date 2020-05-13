using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNetTest.Data;
using MVCNetTest.Models;
using System.Data.Entity;
using MVCNetTest.Data;
using MVCNetTest.Repository.Interface;

namespace MVCNetTest.Controllers
{
    public class HomeController : Controller
    {
        IFruitRepository repository;
        public HomeController(IFruitRepository repository)
        {
            this.repository = repository;
        }
        public ActionResult Index()
        {
            List<Fruit> lstFruit = repository.GetList();
            return View(lstFruit);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}