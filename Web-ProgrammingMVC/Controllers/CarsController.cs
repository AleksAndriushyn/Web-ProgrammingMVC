using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult List(string name)
        {
            ViewBag.Message = "Ваше ім'я " + name;
            return View();
        }
    }
}