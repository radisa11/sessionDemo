using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sessionDemo.Models;
using Microsoft.AspNetCore.Http;

namespace sessionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static Player user;
        static Player Oponent = new Player();
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("process")]
        public IActionResult Process(Player newPlayer)
        {
            if(ModelState.IsValid)
            {
            user = newPlayer;
            Oponent.name = "Aleksandar";
            HttpContext.Session.SetInt32("PlayerOneWins",0);
            HttpContext.Session.SetInt32("PlayerTwoWins",0);
            HttpContext.Session.SetInt32("Ties",0);
            HttpContext.Session.SetInt32("TotalPlays",0);
            return RedirectToAction("Game");
            }
            else{
                return View("Index");
            }
            
        }
        [HttpGet("game")]
        public IActionResult Game()
        {
            ViewBag.User = user;
            ViewBag.Oponent = Oponent;
            ViewBag.PlayerOneWins = HttpContext.Session.GetInt32("PlayerOneWins");
            ViewBag.PlayerTwoWins = HttpContext.Session.GetInt32("PlayerTwoWins");
            ViewBag.Ties = HttpContext.Session.GetInt32("Ties");
            ViewBag.TotalPlays = HttpContext.Session.GetInt32("TotalPlays");

            return View();
        }
        [HttpGet("playRound")]
        public IActionResult playRound()
        {
            user.PlayHand();
            Oponent.PlayHand();
            if(user.hand == "Paper" && Oponent.hand == "Sissors")
            {
                int? amout = HttpContext.Session.GetInt32("PlayerTwoWins");
                amout = amout + 1;
                HttpContext.Session.SetInt32("PlayerTwoWins",(int)amout);
            }else if(user.hand == "Papeer" && Oponent.hand == "Rock")
        {
            int? amout = HttpContext.Session.GetInt32("PlayerOneWins");
            amout = amout + 1;
            HttpContext.Session.SetInt32("PlayerOneWins",(int)amout);
        }else if(user.hand == "Papeer" && Oponent.hand == "Paper")
        {
            int? amout = HttpContext.Session.GetInt32("Ties");
            amout = amout + 1;
            HttpContext.Session.SetInt32("Ties",(int)amout);
        }else if(user.hand == "Rock" && Oponent.hand == "Sissors")
        {
            int? amout = HttpContext.Session.GetInt32("PlayerOneWins");
            amout = amout + 1;
            HttpContext.Session.SetInt32("PlayerOneWins",(int)amout);
        }else if(user.hand == "Rock" && Oponent.hand == "Rock")
        {
            int? amout = HttpContext.Session.GetInt32("Ties");
            amout = amout + 1;
            HttpContext.Session.SetInt32("Ties",(int)amout);
        }else if(user.hand == "Rock" && Oponent.hand == "Paper")
        {
            int? amout = HttpContext.Session.GetInt32("PlayerTwoWins");
            amout = amout + 1;
            HttpContext.Session.SetInt32("PlayerTwoWins",(int)amout);
        }else if(user.hand == "Sissors" && Oponent.hand == "Sissors")
        {
            int? amout = HttpContext.Session.GetInt32("Ties");
            amout = amout + 1;
            HttpContext.Session.SetInt32("Ties",(int)amout);
        }else if(user.hand == "Sissors" && Oponent.hand == "Rock")
        {
            int? amout = HttpContext.Session.GetInt32("PlayerTwoWins");
            amout = amout + 1;
            HttpContext.Session.SetInt32("PlayerTwoWins",(int)amout);
        }else if(user.hand == "Sissors" && Oponent.hand == "Paper")
        {
            int? amout = HttpContext.Session.GetInt32("PlayerOneWins");
            amout = amout + 1;
            HttpContext.Session.SetInt32("PlayerOneWins",(int)amout);
        }
        int? total = HttpContext.Session.GetInt32("TotalPlays");
        total = total +1;
        HttpContext.Session.SetInt32("TotalPlays",(int)total);
            return RedirectToAction("Game");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
