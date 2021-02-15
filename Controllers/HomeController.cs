using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dotNetLab3.Models;


namespace IntroductionToASP.NETMVCCore.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Razor()
        {

            return View();
        }



        public IActionResult Count()
        {
            ViewData["Bottles"] = Request.Form["Bottles"];
            return View();
        }



        [HttpGet]
        public IActionResult CreatePerson()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DisplayPerson(Person model)
        {

            return View(model);
        }



    }
}
