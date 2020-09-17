using NTIerApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetOrders();
        OrderVM GetOrderById(int id);
        bool CreateOrder(OrderVM order);
        bool UpdateOrder(OrderVM order);
        bool DeleteOrder(OrderVM order);
        List<OrderVM> GetOrderByUserId(int userId);
    }
}
