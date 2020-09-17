using EntireApp.DataAcess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntireApp.DataAcess
{
    public class LocalDB : ILocalDB
    {
        public static int IdCount { get; set; } = 3;
        public LocalDB()
        {
            IdCount++;
        }
        public IEnumerable<Movie> GetMuvies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Good Will Hunting",
                    Duration = "2:10:00",
                    MovieRating = Core.Enums.Rating.Three,
                    MovieGenre = Core.Enums.Genre.Drama
                },
                 new Movie()
                {
                    Id = 2,
                    Title = "Good Will Hunting",
                    Duration = "1:10:00",
                    MovieRating = Core.Enums.Rating.One,
                    MovieGenre = Core.Enums.Genre.Comedy
                },
                 new Movie()
                {
                    Id = 3,
                    Title = "Exorcism of Emilly Rose",
                    Duration = "1:40:00",
                    MovieRating = Core.Enums.Rating.Two,
                    MovieGenre = Core.Enums.Genre.Horror
                }
            };

        }



        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    Movie = new List<Movie>(),
                    User = new User()
                },
                new Order()
                {
                    Id = 2,
                    Movie = new List<Movie>(),
                    User = new User()
                }

            };
        }

        public IEnumerable<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "damjanstojanovski454@gmail.com",
                    LastName = "Stojanovski",
                    Name = "Damjan",
                    Password = "pass123",
                    PhoneNumber = "075222222",
                    UserName = "damjan",
                    Order = new List<Order>()
                },
                new User()
                {
                    Id = 2,
                    Email = "vik.zafir@gmail.com",
                    LastName ="Zafirovski",
                    Name = "Viktor",
                    Password = "pass123",
                    PhoneNumber = "075222222",
                    UserName = "vik37",
                    Order = new List<Order>()
                }
            };
        }
    }
}