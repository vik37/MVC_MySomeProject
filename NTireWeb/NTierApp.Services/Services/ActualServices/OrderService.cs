using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Interface;
using EntireApp.DataAcess.Core.Repositories;
using NTierApp.Services.Mapping;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierApp.Services.Services.ActualServices
{
    public class OrderService : IOrderService
    {
        private IREpository<Order> _orderReop;
        public OrderService(IREpository<Order> orderRepo)
        {
            _orderReop = orderRepo;
        }
        public bool CreateOrder(OrderVM order)
        {
            var orders = _orderReop.GetAll().ToList();
            
            Order newOrder = new Order()
            {
                Movie = new List<Movie>(),
                User = new User()
            };
            if (!orders.Equals(order))
            {
                return false;
            }
            _orderReop.Create(newOrder);
            Mappers.FromOrderToOrderVM(newOrder);
            return true;
        }

        public bool DeleteOrder(OrderVM order)
        {
            var orders = _orderReop.GetAll().ToList();
            Order newOrder = new Order()
            {
                Movie = new List<Movie>(),
                User = new User()
            };
            if (!orders.Equals(order))
            {
                return false;
            }
            _orderReop.Delete(newOrder);
            Mappers.FromOrderToOrderVM(newOrder);
            return true;
        }

        public OrderVM GetOrderById(int id)
        {
            var order = _orderReop.GetById(id);
            var mvs = Mappers.FromOrderToOrderVM(order);
            return mvs;
        }

        public List<OrderVM> GetOrderByUserId(int userId)
        {            
            var filterOrder = _orderReop.GetAll().Where(o => o.User.Id == userId).ToList();           
            var mvs = Mappers.MapOrdersToOrderVM(filterOrder);
            return mvs;
        }

        public List<OrderVM> GetOrders()
        {
            var orders = _orderReop.GetAll().ToList();
            var vms = Mappers.MapOrdersToOrderVM(orders);
            return vms;
        }

        public bool UpdateOrder(OrderVM order)
        {
            var orders = _orderReop.GetAll().ToList();
            Order newOrder = new Order()
            {
                Movie = new List<Movie>(),
                User = new User()
            };
            if (orders.Equals(order))
            {
                return false;
            }
            _orderReop.Update(newOrder);
            Mappers.FromOrderToOrderVM(newOrder);
            return true;
        }
    }
}
