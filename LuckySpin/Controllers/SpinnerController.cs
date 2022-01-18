using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        /***
         * Index Page Actions - GET and POST
         *   GET - diplays the Player form
         *   POST - gathers the Player info collected by the form and Redirect to Spin
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        //TODO: replace the int with a Player parameter and pass it onto the Spin Action
        [HttpPost]
        public IActionResult Index(Player player)
        {
            return RedirectToAction("Spin", player);
        }

        
        //TODO: display the Spin View passing a new Spin that includes the Player object
        [HttpGet]
        public IActionResult Spin(Player player)
        {
            
            return View(new Spin { Player=player });
        }
    }
}

