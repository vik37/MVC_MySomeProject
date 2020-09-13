using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using NtierAppPresentationLayer.ViewModels;
using NtierAppServices.Mapping;
using NtierAppServices.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NtierAppServices.Service.ActualServices
{
    public class UserService : IUserService
    {
        private IRepository<Users> _userRepo;
        public UserService(IRepository<Users> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(UserVM user)
        {
            var users = _userRepo.GetAll().ToList();
            Users neUsers = new Users()
            {
                
                Adress = user.Adress,
                Age = user.Age,
                BirthDay = user.BirthDay,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Entitie = user.Entitie,
                Gender = user.Gender,
                IDCardNumber = user.IDCardNumber,
                Password = user.Password,
                Phone = user.Phone,
                Orders = new List<Orders>()
            };
            if (!user.Equals(users))
            {
                return false;
            }
                _userRepo.Create(neUsers);
            Mapper.MapUserFromUserVM(neUsers);            
            return true;
        }

        public bool DeleteUser(UserVM user)
        {
            var users = _userRepo.GetAll().ToList();
            Users neUsers = new Users()
            {

                Adress = user.Adress,
                Age = user.Age,
                BirthDay = user.BirthDay,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Entitie = user.Entitie,
                Gender = user.Gender,
                IDCardNumber = user.IDCardNumber,
                Password = user.Password,
                Phone = user.Phone,
                Orders = new List<Orders>()
            };
            if (!user.Equals(users))
            {
                return false;
            }
            _userRepo.Delete(neUsers);
            Mapper.MapUserFromUserVM(neUsers);
            return true;
        }

        public List<UserVM> GetAllUsers()
        {
            var users = _userRepo.GetAll().ToList();
            var vms = Mapper.MapUserModelsToUserVM(users);
            return vms;
        }

        public UserVM GetUserByGender(UserVM entitie)
        {
            var user = _userRepo.GetAll().SingleOrDefault(u => u.Gender == entitie.Gender);
            var vm = Mapper.MapUserFromUserVM(user);
            return vm;
        }

        public UserVM GetUserById(int id)
        {
            var user = _userRepo.GetById(id);
            var vm = Mapper.MapUserFromUserVM(user);
            return vm;
        }

        public UserVM GetUserWithMostOrders(List<Users> users)
        {            
            var userWithMaxOrder = users.GroupBy(u => u.Id)
                                          .OrderByDescending(u => u.Count())
                                          .First()
                                          .Key;
            var user = _userRepo.GetById(userWithMaxOrder);
            var vm = Mapper.MapUserFromUserVM(user);
            return vm;
        }

        public bool UpdateUser(UserVM user)
        {
            var users = _userRepo.GetAll().ToList();
            Users neUsers = new Users()
            {

                Adress = user.Adress,
                Age = user.Age,
                BirthDay = user.BirthDay,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Entitie = user.Entitie,
                Gender = user.Gender,
                IDCardNumber = user.IDCardNumber,
                Password = user.Password,
                Phone = user.Phone,
                Orders = new List<Orders>()
            };
            if (!user.Equals(users))
            {
                return false;
            }
           
            _userRepo.Update(neUsers);
            Mapper.MapUserFromUserVM(neUsers);
            return true;
        }
    }
}
