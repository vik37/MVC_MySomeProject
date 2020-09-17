using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTierApp.Services.Services.ActualServices;
using NTierApp.Services.Services.Interfaces;

namespace NTireWeb.MV.Controllers
{
    
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

         [Route("{id}")]          
        public IActionResult Index(int id)
        {
            var user = _userService.GetUserById(id);
            
            return View(user);
        }
    }
}
