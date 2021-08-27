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
        //Use tag helpers to declare a specific GET call for this function to respond to
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Name = "Mary";
            //ViewBag.FV = 99999.99;
            ViewBag.FV = 0;
            return View();
        }

        //Use tag helpers to declare a specific POST call for this function to repond to
        [HttpPost]
        public IActionResult Index(Class model)
        {
            //If statement to check if the model is found
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue(); //Set the FV value to the model's calculate funtion
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
