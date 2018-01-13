using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { ID = 1, Name = "Nelson's Pizza Place" };
            //return new ObjectResult(model);
            return View(model);
        }
    }
}
