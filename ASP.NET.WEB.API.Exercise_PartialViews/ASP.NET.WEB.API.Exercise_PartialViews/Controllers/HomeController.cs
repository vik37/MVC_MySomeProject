using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET.WEB.API.Exercise_PartialViews.Models;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Heading"] = "RENT A CAR";
            ViewBag.Title = "Rent for trip (Streets, Mauntains, Lake, Short or Long trip)";
            var allVehicles = StaticDB.vehicles;
            return View(allVehicles);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
