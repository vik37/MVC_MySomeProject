using EntireApp.DataAcess.Core.Enums;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IMovieService
    {
        List<MoviesVM> GetMoviesRepertuar();
        MoviesVM GetMovieById(int id);
        List<MoviesVM> GetMovieByGenre(Genre genre);
        List<MoviesVM> GetMovieByRating(Rating rating);
    }
}
