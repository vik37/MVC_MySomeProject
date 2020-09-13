using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain;
using ASP.NET.WEB.API.Exercise_PartialViews.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Controllers
{
    public class RentACarController : Controller
    {
      
        public IActionResult Index()
        {
            ViewData["Heading"] = "RENT A CAR 'TOUR DE MACEDONIA'  ";
            ViewBag.Title = " - Rent for trip (Streets, Mauntains, Lake, Short or Long trip) - ";
            
            var vehicle = StaticDB.vehicles;
            
            var vehicleVM = vehicle.Select(v => new VehiclesVM()
            {
                Id = v.Id,
                Color = v.Color,
                VehicleKind = v.VehicleKind,
                Type = v.Type,
                Mark = v.Mark,
                Price = v.Price,
                Currency = v.Currency,
                ImgUrl = v.ImgUrl
            }).ToList();            
            return View(vehicleVM);
        }
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(User userModel)
        {
            User user = new User()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Age = userModel.Age,
                Adress = userModel.Adress,
                Phone = userModel.Phone,
                IDCardNumber = userModel.IDCardNumber,
                Email = userModel.Email,
                Password = userModel.Password,
                Id = StaticDB.users.Count + 1
            };
            StaticDB.users.Add(user);
            return RedirectToAction("Index");
        }
    }
}
