using NtierAppPresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtierAppServices.Service.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetOrders();
        OrderVM GetOrderById(int id);
        bool CreateOrder(OrderVM order);
        bool UpdateOrder(OrderVM order);
        bool DeleteOrder(OrderVM order);
        List<OrderVM> GetOrdersByUserId(int userId);
        List<OrderVM> ShowAllVehicleIsRented(OrderVM order);
        List<OrderVM> ShowAllVehiclesNotRented(OrderVM order);
        List<OrderVM> GetRentedTime(OrderVM order);
    }
}
