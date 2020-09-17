using EntireApp.DataAcess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntireApp.DataAcess
{
    public interface ILocalDB
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Movie> GetMuvies();
        IEnumerable<Order> GetOrders();
    }
}
