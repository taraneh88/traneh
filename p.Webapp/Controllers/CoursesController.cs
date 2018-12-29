using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using p.Webapp.ViewModels;

namespace p.Webapp.Controllers
{
    public class CoursesController : Controller
    {

        [HttpGet("courses", Name = "Uniqname")]
        public IActionResult Index()
        {




            var model1 = new List<CoursesViewModel>();

            var c1 = new CoursesViewModel();
            c1.MainImage = "/images/0b9124a4-editor.jpeg";
            c1.Title = "Riazi";

            var c2= new CoursesViewModel();
            c2.Title = "Olom";


            var c3= new CoursesViewModel();
            c3.Title = "Arabi";

            model1.Add(c1);
            model1.Add(c2);
            model1.Add(c3);


            return View(model1);
        }
        
    }
}
