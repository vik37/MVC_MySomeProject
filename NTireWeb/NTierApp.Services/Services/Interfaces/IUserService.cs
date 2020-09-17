using EntireApp.DataAcess.Core.Entities;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        UserVM GetUserWithMostOrder(List<User> users);
        UserVM GetUserById(int id);
        bool CreateUser(UserVM user);
        bool UpdateUser(UserVM user);
        bool DeleteUser(UserVM user);
    }
}
