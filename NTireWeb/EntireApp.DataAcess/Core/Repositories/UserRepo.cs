using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntireApp.DataAcess.Core.Repositories
{
    public class UserRepo : IREpository<User>
    {
        private ILocalDB _db;
        public UserRepo(LocalDB localDb)
        {
            _db = localDb;
        }
        

        public bool Create(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(u => u.Id == entity.Id);
            if(user != null)
            {
                return false;
            }
            _db.GetUsers().ToList().Add(user);
            return true;

        }

        public bool Delete(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(u => u.Id == entity.Id);
            if(user == null)
            {
                return false;
            }
            _db.GetUsers().ToList().Remove(user);
            return true;
        }

        public List<User> GetAll()
        {
            return _db.GetUsers().ToList();            
        }

        public User GetById(int id)
        {
            return _db.GetUsers().SingleOrDefault(u => u.Id == id);
        }

        public bool Update(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(u => u.Id == entity.Id);
            if(user == null)
            {
                return false;
            }
            _db.GetUsers().ToList().Remove(entity);
            _db.GetUsers().ToList().Add(entity);
            return true;
        }
    }
}
