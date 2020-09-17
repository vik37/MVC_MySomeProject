using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntireApp.DataAcess.Core.Repositories
{
    public class OrderRepo : IREpository<Order>
    {
        private ILocalDB _db;
        public OrderRepo(LocalDB localDb)
        {
            _db = localDb;
        }

        public bool Create(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(o => o.Id == entity.Id);
            if(order != null)
            {
                return false;
            }
            _db.GetOrders().ToList().Add(order);
            return true;
        }

        public bool Delete(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(o => o.Id == entity.Id);
            if(order == null)
            {
                return false;
            }
            _db.GetOrders().ToList().Remove(order);
            return true;
        }

        public List<Order> GetAll()
        {
            return _db.GetOrders().ToList();
        }

        public Order GetById(int id)
        {
            return _db.GetOrders().SingleOrDefault(o => o.Id == id);
        }

        public bool Update(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(o => o.Id == entity.Id);
            if(order == null)
            {
                return false;   
            }
            _db.GetOrders().ToList().Remove(order);
            _db.GetOrders().ToList().Add(order);
            return true;
        }
    }
}
