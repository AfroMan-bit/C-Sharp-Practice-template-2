using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ActivityGame.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivityGame.Controllers {
    public class HomeController : Controller {
        public static ActivityGame activityGame = new ActivityGame ();
        [HttpGet ("")]
        public IActionResult Index () {

            return View ("Index", activityGame);
        }

        [HttpGet ("test")]
        public JsonResult Test () {
            return Json (activityGame.serialize ());
        }

        [HttpGet ("feed")]
        public IActionResult Feed () {
            if (activityGame.Meal > 0) {
                activityGame.EatMeal ();
                if (activityGame.HasDied () == true) {
                    return View ("Died", activityGame);
                }
                if (activityGame.HasWon () == true) {
                    return View ("Win", activityGame);
                }
                return View ("Index", activityGame);
            } else {
                activityGame.Log = "You Must work to earn your meals";
                activityGame.Img = "https://pics.me.me/thumb_angry-cat-noises-overview-dotabuff-dota-2-52285737.png";
                return View ("Index", activityGame);
            }
        }

        [HttpGet ("play")]
        public IActionResult Play () {
            activityGame.Playing ();
            if (activityGame.HasDied () == true) {
                return View ("Died", activityGame);
            }
            if (activityGame.HasWon () == true) {
                return View ("Win", activityGame);
            }
            return View ("Index", activityGame);
        }

        [HttpGet ("work")]
        public IActionResult Work () {
            activityGame.Working ();
            if (activityGame.HasDied () == true) {
                return View ("Died", activityGame);
            }
            if (activityGame.HasWon () == true) {
                return View ("Win", activityGame);
            }
            return View ("Index", activityGame);
        }

        [HttpGet ("sleep")]
        public IActionResult Sleep () {
            activityGame.Sleeping ();
            if (activityGame.HasDied () == true) {
                return View ("Died", activityGame);
            }
            if (activityGame.HasWon () == true) {
                return View ("Win", activityGame);
            }
            return View ("Index", activityGame);
        }

        [HttpGet ("restart")]
        public IActionResult Restart () {
            activityGame.Restart ();
            return View ("Index", activityGame);
        }
    }

}