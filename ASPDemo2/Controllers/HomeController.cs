using Microsoft.AspNetCore.Mvc;
using ASPDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDemo2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Name = "Mary";
            //ViewBag.FV = 99999.99;
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Class model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
