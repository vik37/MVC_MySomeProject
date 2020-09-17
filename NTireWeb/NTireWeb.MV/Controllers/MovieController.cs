
using EntireApp.DataAcess;
using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Enums;
using Microsoft.AspNetCore.Mvc;
using NTierApp.Services.Services.Interfaces;

namespace NTireWeb.MV.Controllers
{
    public class MovieController : Controller
    {
        
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetMoviesRepertuar();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Film(int id)
        {            
            var movies = _movieService.GetMovieById(id);
            return View(movies);
        }

        
        
    }
}
