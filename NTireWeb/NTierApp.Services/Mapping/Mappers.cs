using EntireApp.DataAcess.Core.Entities;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierApp.Services.Mapping
{
    public static class Mappers
    {
        public static List<UserVM> MapUserModelsToViewModels(List<User> users)
        {
            return users.Select(x => new UserVM() { Email = x.Email, LastName = x.LastName, Name = x.Name, Password = x.Password, PhoneNumber = x.PhoneNumber, 
                UserName = x.UserName, Order = MapOrdersToOrderVM(x.Order) }).ToList();
        }
        public static List<MoviesVM> MapMoviesToMoviesVM(List<Movie> movies)
        {
            return movies.Select(m => new MoviesVM() { Duration = m.Duration, MovieGenre = m.MovieGenre, MovieRating = m.MovieRating, Title = m.Title }).ToList();
        }
        public static List<OrderVM> MapOrdersToOrderVM(List<Order> orders)
        {
            return orders.Select(x => new OrderVM() { Movies = MapMoviesToMoviesVM(x.Movie), User = MapUserToUserVM(x.User) }).ToList();
        }

        public static UserVM MapUserToUserVM(User user)
        {
            return new UserVM()
            {
                Email = user.Email,
                LastName = user.LastName,
                Name = user.Name,
                Password = user.Password,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Order = MapOrdersToOrderVM(user.Order)
            };
        }
        public static MoviesVM FromMovieToMovieVM(Movie movie)
        {
            return new MoviesVM()
            {                    
                Duration = movie.Duration,
                MovieGenre = movie.MovieGenre,
                MovieRating = movie.MovieRating,
                Title = movie.Title
            };
        }
        public static OrderVM FromOrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                Movies = MapMoviesToMoviesVM(order.Movie),
                User = MapUserToUserVM(order.User)
            };
        }
       
        public static Movie FromMovieVMToMovie(MoviesVM movie)
        {
            return new Movie()
            {
                Duration = movie.Duration,
                MovieGenre = movie.MovieGenre,
                MovieRating = movie.MovieRating,
                Title = movie.Title
            };
        }
    }
}
