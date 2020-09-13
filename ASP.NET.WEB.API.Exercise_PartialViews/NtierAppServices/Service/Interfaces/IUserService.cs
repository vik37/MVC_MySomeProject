using NTierApp.DataAccess.Core.Entities;
using NtierAppPresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtierAppServices.Service.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        UserVM GetUserWithMostOrders(List<Users> users);
        UserVM GetUserById(int id);
        UserVM GetUserByGender(UserVM entitie);
        bool CreateUser(UserVM user);
        bool UpdateUser(UserVM user);
        bool DeleteUser(UserVM user);
    }
}
