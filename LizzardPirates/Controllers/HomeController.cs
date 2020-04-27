using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LizzardPirates.Models;

namespace LizzardPirates.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get;set; }

        public HomeController(MyContext context)
        {
            _context = context;
        }



        [HttpGet("")]
        public IActionResult Index()
        {
            // USING LINQ TO SORT IFORMATION IN THE DATABASE LIKE BELOW
            List<LizzardPirate> Lps = _context.LizzardCrew.OrderByDescending(l => l.PirateRole).ToList();
            List<LizzardPirate> Crew =_context.LizzardCrew.Where( l => l.LizzardPirateId >= 2)
                                                          .OrderBy( l => l.LizzardType)
                                                          .ThenBy( l => l.Name)
                                                          .ToList();
            return View(Lps);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(LizzardPirate newLP)
        {
            if(ModelState.IsValid)
            {
                _context.LizzardCrew.Add(newLP);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Add");
            }
        }

        [HttpGet("{LPId}")]
        public IActionResult Show(int LPId)
        {
            LizzardPirate show = _context.LizzardCrew.FirstOrDefault( l => l.LizzardPirateId == LPId);
            return View(show);
        }

        [HttpGet("edit/{LPId}")]
        public IActionResult Edit(int LPId)
        {
            LizzardPirate edit = _context.LizzardCrew.FirstOrDefault( l => l.LizzardPirateId == LPId);
            return View(edit);
        }

        [HttpPost("update/{LPId}")]
        public IActionResult Update(int LPId,LizzardPirate update)
        {
            LizzardPirate retrieved = _context.LizzardCrew.FirstOrDefault( l => l.LizzardPirateId == LPId );

            if(ModelState.IsValid)
            {
                retrieved.Name = update.Name;
                retrieved.LizzardType = update.LizzardType;
                retrieved.PirateRole = update.PirateRole;
                retrieved.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return Redirect($"/{LPId}");
            }
            else
            {
                update.LizzardPirateId = LPId;
                return View("Edit",update);
            }
        }

        [HttpGet("delete/{LPId}")]
        public IActionResult Destroy(int LPId)
        {
            LizzardPirate walkThePlank = _context.LizzardCrew.FirstOrDefault( l => l.LizzardPirateId == LPId);
            _context.LizzardCrew.Remove(walkThePlank);
            _context.SaveChanges();
            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}