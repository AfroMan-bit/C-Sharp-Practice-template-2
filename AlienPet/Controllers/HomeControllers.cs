using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AlienPet.Controllers
{
    public class HomeController : Controller
    {
        
        public static List<string> alienpetNames = new List<string>()
        {
            "Mr Nibbles",
            "Jackie",
            "Benny Bob",
            "Rick",
            "Jose"
        };

        [HttpGet("")]  
        public IActionResult Index()
        {
            ViewBag.alienpetNames = alienpetNames;
            return View();
        }


        [HttpGet("pageone")]
        public IActionResult Pageone()
        {
            return View("Somepage");
        }

        [HttpPost("process")]
        public IActionResult Process(string name)
        {
            // Console.WriteLine(name);
            alienpetNames.Add(name);
            return Redirect("/");
        }
    }

}