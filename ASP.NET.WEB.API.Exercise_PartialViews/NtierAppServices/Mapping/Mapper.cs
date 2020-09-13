using NTierApp.DataAccess.Core.Entities;
using NtierAppPresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NtierAppServices.Mapping
{
    public class Mapper
    {
        public static List<VehicleVM> MapVehicleModelsToVehicleVM(List<Vehicles> vehicle)
        {
            return vehicle.Select(v => new VehicleVM()
            {
                Color = v.Color,
                Currency = v.Currency,
                ImgUrl = v.ImgUrl,
                VehicleKind = v.VehicleKind,
                Mark = v.Mark,
                Price = v.Price,
                Type = v.Type,
            }).ToList();
        }
        public static List<UserVM> MapUserModelsToUserVM(List<Users> user)
        {
            return user.Select(u => new UserVM()
            {
                Adress = u.Adress,
                Age = u.Age,
                BirthDay = u.BirthDay,
                Email = u.Email,
                Entitie = u.Entitie,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Gender = u.Gender,
                IDCardNumber = u.IDCardNumber,
                Password = u.Password,
                Phone = u.Phone,
                Orders = MapOrderModelsToOrderVM(u.Orders)               
            }).ToList();
        }
        public static List<OrderVM> MapOrderModelsToOrderVM(List<Orders> order)
        {
            return order.Select(o => new OrderVM()
            {
                Days = o.Days,
                isRented = o.isRented,
                RentDate = o.RentDate,
                Today = o.Today,
                User = MapUserFromUserVM(o.User),
                Vehicles = MapVehicleModelsToVehicleVM(o.Vehicles)
            }).ToList();
        }

        

        public static VehicleVM MapVehicleFromVehicleVM(Vehicles vehicle)
        {
            return new VehicleVM()
            {
                Color = vehicle.Color,
                Currency = vehicle.Currency,
                VehicleKind = vehicle.VehicleKind,
                ImgUrl = vehicle.ImgUrl,
                Mark = vehicle.Mark,
                Price = vehicle.Price,
                Type = vehicle.Type
            };
        }
        public static UserVM MapUserFromUserVM(Users user)
        {
            return new UserVM()
            {
                Adress = user.Adress,
                Age = user.Age,
                BirthDay = user.BirthDay,
                IDCardNumber = user.IDCardNumber,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Entitie = user.Entitie,
                Gender = user.Gender,
                Password = user.Password,
                Phone = user.Phone,
                Orders = MapOrderModelsToOrderVM(user.Orders)
            };
        }    
        public static OrderVM MapOrderFromOrderVM(Orders order)
        {
            return new OrderVM()
            {
                Days = order.Days,
                RentDate = order.RentDate,
                isRented = order.isRented,
                Today = order.Today,
                User = MapUserFromUserVM(order.User),
                Vehicles = MapVehicleModelsToVehicleVM(order.Vehicles)
            };
        }
    }
}
