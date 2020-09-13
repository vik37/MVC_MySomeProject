using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierApp.DataAccess.Core.Repositories
{
    public class UserRepo : IRepository<Users>
    {
        private ILocalDB _localDb;
        public UserRepo(LocalDB localDB)
        {
            _localDb = localDB;
        }

        public bool Create(Users entitie)
        {
            var user = _localDb.GetUser().SingleOrDefault(u => u.Id == entitie.Id);
            if(user != null)
            {
                return false;
            }
            _localDb.GetUser().ToList().Add(entitie);
            return true;
        }

        public bool Delete(Users entitie)
        {
            var user = _localDb.GetUser().SingleOrDefault(u => u.Id == entitie.Id);
            if(user == null)
            {
                return false;
            }
            _localDb.GetUser().ToList().Remove(entitie);
            return true;
        }

        public List<Users> GetAll()
        {
            return _localDb.GetUser().ToList();
        }

        public Users GetById(int id)
        {
            return _localDb.GetUser().SingleOrDefault(u => u.Id == id);
        }

        public bool Update(Users entitie)
        {
            var user = _localDb.GetUser().SingleOrDefault(u => u.Id == entitie.Id);
            if(user == null)
            {
                return false;
            }
            _localDb.GetUser().ToList().Remove(entitie);
            _localDb.GetUser().ToList().Add(entitie);
            return true;
        }
    }
}
