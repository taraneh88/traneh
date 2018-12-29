using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace p.Webapp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/", Name = "home")]
        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
