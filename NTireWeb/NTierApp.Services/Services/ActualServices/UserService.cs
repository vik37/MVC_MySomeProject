using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Interface;
using NTierApp.Services.Mapping;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierApp.Services.Services.ActualServices
{
    public class UserService : IUserService
    {
        private IREpository<User> _userReop;
        public UserService(IREpository<User> userRepo)
        {
            _userReop = userRepo;
        }
        public bool CreateUser(UserVM user)
        {
            var users = _userReop.GetAll().ToList();
            User newUser = new User()
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Order = new List<Order>()
            };
            if (!users.Equals(user))
            {
                return false;
            }
            _userReop.Create(newUser);
            Mappers.MapUserToUserVM(newUser);
            return true;
        }

        public bool DeleteUser(UserVM user)
        {
            var users = _userReop.GetAll().ToList();
            User newUser = new User()
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Order = new List<Order>()
            };
            if (!users.Equals(user))
            {
                return false;
            }
            _userReop.Delete(newUser);
            Mappers.MapUserToUserVM(newUser);
            return true;
        }

        public List<UserVM> GetAllUsers()
        {
            var user = _userReop.GetAll().ToList();
            var vms = Mappers.MapUserModelsToViewModels(user);
            return vms;
        }

        public UserVM GetUserById(int id)
        {
            var user = _userReop.GetById(id);

            var vm = Mappers.MapUserToUserVM(user);
            return vm;
        }

        public UserVM GetUserWithMostOrder(List<User> users)
        {
            var userWithMaxOrder = users.GroupBy(u => u.Id)
                                         .OrderByDescending(u => u.Count())
                                         .First()
                                         .Key;
            var user = _userReop.GetById(userWithMaxOrder);
            var vm = Mappers.MapUserToUserVM(user);
            return vm;
        }

        public bool UpdateUser(UserVM user)
        {
            var users = _userReop.GetAll().ToList();
            User newUser = new User()
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Order = new List<Order>()
            };
            if (!users.Equals(user))
            {
                return false;
            }
            _userReop.Update(newUser);
            Mappers.MapUserToUserVM(newUser);
            return true;
        }
    }
}
