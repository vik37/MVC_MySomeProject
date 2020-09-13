using NTierApp.DataAccess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.DataAccess.Core.Interfaces
{
    public interface ILocalDB
    {
        IEnumerable<Vehicles> GetVehicle();
        IEnumerable<Users> GetUser();
        IEnumerable<Orders> GetOrders();

    }
}
