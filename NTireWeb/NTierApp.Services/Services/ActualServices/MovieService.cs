using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Enums;
using EntireApp.DataAcess.Core.Interface;
using NTierApp.Services.Mapping;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NTierApp.Services.Services.ActualServices
{
    public class MovieService : IMovieService
    {
        private IREpository<Movie> _movieRepo;
        public MovieService(IREpository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public List<MoviesVM> GetMovieByGenre(Genre genre)
        {
            var filteredMovies = _movieRepo.GetAll().Where(x => x.MovieGenre == genre).ToList();
            var vms = Mappers.MapMoviesToMoviesVM(filteredMovies);
            return vms;
        }

        public MoviesVM GetMovieById(int id)
        {
            var movie = _movieRepo.GetById(id);
            var vm = Mappers.FromMovieToMovieVM(movie);
            return vm;
        }
        public void CreateNewMovie(MoviesVM movieVm)
        {
            var movie = Mappers.FromMovieVMToMovie(movieVm);
            _movieRepo.Create(movie);
        }
        public List<MoviesVM> GetMovieByRating(Rating rating)
        {
            var filteredMovies = _movieRepo.GetAll().Where(x => x.MovieRating == rating).ToList();
            var vms = Mappers.MapMoviesToMoviesVM(filteredMovies);
            return vms;
        }

        public List<MoviesVM> GetMoviesRepertuar()
        {
            var movies = _movieRepo.GetAll().ToList();
            var thisMovie = movies;
            var vms = Mappers.MapMoviesToMoviesVM(movies);
            return vms;
        }
    }
}
