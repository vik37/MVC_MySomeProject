using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using NtierAppPresentationLayer.ViewModels;
using NtierAppServices.Mapping;
using NtierAppServices.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NtierAppServices.Service.ActualServices
{
    public class OrderService : IOrderService
    {
        private IRepository<Orders> _orderRepo;
        public OrderService(IRepository<Orders> orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public bool CreateOrder(OrderVM order)
        {
            var orders = _orderRepo.GetAll().ToList();
            Orders newOrder = new Orders()
            {
                
                Days = order.Days,
                isRented = order.isRented,
                RentDate = order.RentDate,
                Today = order.Today,
                User = new Users(),
                Vehicles = new List<Vehicles>()
            };
            if (!order.Equals(orders))
            {
                return false;
            }
            _orderRepo.Create(newOrder);
            Mapper.MapOrderFromOrderVM(newOrder);
            return true;
        }

        public bool DeleteOrder(OrderVM order)
        {
            var orders = _orderRepo.GetAll().ToList();
            Orders newOrder = new Orders()
            {

                Days = order.Days,
                isRented = order.isRented,
                RentDate = order.RentDate,
                Today = order.Today,
                User = new Users(),
                Vehicles = new List<Vehicles>()
            };
            if (!order.Equals(orders))
            {
                return false;
            }
            _orderRepo.Delete(newOrder);
            Mapper.MapOrderFromOrderVM(newOrder);
            return true;
        }
        public bool UpdateOrder(OrderVM order)
        {
            var orders = _orderRepo.GetAll().ToList();
            Orders newOrder = new Orders()
            {

                Days = order.Days,
                isRented = order.isRented,
                RentDate = order.RentDate,
                Today = order.Today,
                User = new Users(),
                Vehicles = new List<Vehicles>()
            };
            if (!order.Equals(orders))
            {
                return false;
            }

            _orderRepo.Update(newOrder);
            Mapper.MapOrderFromOrderVM(newOrder);
            return true;
        }


        public OrderVM GetOrderById(int id)
        {
            var orderById = _orderRepo.GetById(id);
            var vms = Mapper.MapOrderFromOrderVM(orderById);
            return vms;
        }

        public List<OrderVM> GetOrders()
        {
            var allOrders = _orderRepo.GetAll().ToList();
            var vms = Mapper.MapOrderModelsToOrderVM(allOrders);
            return vms;
        }

        public List<OrderVM> GetOrdersByUserId(int userId)
        {
            var filterOrder = _orderRepo.GetAll().Where(o => o.User.Id == userId)
                                                 .Select(o => new Orders { Id = o.Id, Days = o.Days, isRented = o.isRented, RentDate = o.RentDate,
                                                     Today = o.Today, User = new Users(), Vehicles = new List<Vehicles>() })
                                                 .ToList();
            var vms = Mapper.MapOrderModelsToOrderVM(filterOrder);
            return vms;
        }

        public List<OrderVM> GetRentedTime(OrderVM order)
        {
            var filterOrder = _orderRepo.GetAll().Where(o => o.RentDate == order.RentDate || o.RentDate != null)
                                                 .Select(o => o)
                                                 .ToList();
            var vms = Mapper.MapOrderModelsToOrderVM(filterOrder);
            return vms;
        }

        public List<OrderVM> ShowAllVehicleIsRented(OrderVM order)
        {
            var filterOrder = _orderRepo.GetAll().Where(o => o.isRented == order.isRented || o.isRented == true)
                                                 .OrderBy(o => o.Vehicles.Select(x => x.VehicleKind))
                                                 .ToList();
            var vms = Mapper.MapOrderModelsToOrderVM(filterOrder);
            return vms;
        }

        public List<OrderVM> ShowAllVehiclesNotRented(OrderVM order)
        {
            var filterOrder = _orderRepo.GetAll().Where(o => o.isRented == order.isRented || o.isRented == false)
                                                 .OrderBy(o => o.Vehicles.Select(x => x.VehicleKind))
                                                 .ToList();
            var vms = Mapper.MapOrderModelsToOrderVM(filterOrder);
            return vms;
        }

        
    }
}
