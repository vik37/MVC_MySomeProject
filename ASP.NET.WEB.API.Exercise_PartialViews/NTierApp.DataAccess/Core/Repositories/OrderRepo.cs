using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierApp.DataAccess.Core.Repositories
{
    public class OrderRepo : IRepository<Orders>
    {
        private ILocalDB _localDb;
        public OrderRepo(LocalDB localDb)
        {
            _localDb = localDb;
        }

        public bool Create(Orders entitie)
        {
            var order = _localDb.GetOrders().SingleOrDefault(o => o.Id == entitie.Id);
            if(order != null)
            {
                return false;
            }
            _localDb.GetOrders().ToList().Add(entitie);
            return true;
        }

        public bool Delete(Orders entitie)
        {
            var order = _localDb.GetOrders().SingleOrDefault(o => o.Id == entitie.Id);
            if(order == null)
            {
                return false;
            }
            _localDb.GetOrders().ToList().Remove(entitie);
            return true;
        }

        public List<Orders> GetAll()
        {
            return _localDb.GetOrders().ToList();
        }

        public Orders GetById(int id)
        {
            return _localDb.GetOrders().SingleOrDefault(o => o.Id == id);
        }

        public bool Update(Orders entitie)
        {
            var order = _localDb.GetOrders().SingleOrDefault(o => o.Id == entitie.Id);
            if(order == null)
            {
                return false;
            }
            _localDb.GetOrders().ToList().Remove(entitie);
            _localDb.GetOrders().ToList().Add(entitie);
            return true;
        }
    }
}
