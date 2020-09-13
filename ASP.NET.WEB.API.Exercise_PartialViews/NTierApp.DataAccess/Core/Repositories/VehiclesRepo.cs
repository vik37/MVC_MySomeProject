using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NTierApp.DataAccess.Core.Repositories
{
    public class VehiclesRepo : IRepository<Vehicles>
    {
        private ILocalDB _localDb;
        public VehiclesRepo(ILocalDB localDb)
        {
            _localDb = localDb;
        }
        public List<Vehicles> GetAll()
        {
            return _localDb.GetVehicle().ToList();
        }

        public Vehicles GetById(int id)
        {
            return _localDb.GetVehicle().SingleOrDefault(x => x.Id == id);
        }
        public bool Create(Vehicles entitie)
        {
            var vehicle = _localDb.GetVehicle().SingleOrDefault(x => x.Id == entitie.Id);
            if(vehicle != null)
            {
                return false;
            }
            _localDb.GetVehicle().ToList().Add(entitie);
            return true;
        }
        public bool Update(Vehicles entitie)
        {
            var vehicle = _localDb.GetVehicle().SingleOrDefault(x => x.Id == entitie.Id);
            if (vehicle == null)
            {
                return false;
            }
            _localDb.GetVehicle().ToList().Remove(entitie);
            _localDb.GetVehicle().ToList().Add(entitie);
            return true;
        }
        public bool Delete(Vehicles entitie)
        {
            var vehicle = _localDb.GetVehicle().SingleOrDefault(x => x.Id == entitie.Id);
            if (vehicle == null)
            {
                return false;
            }
            _localDb.GetVehicle().ToList().Remove(entitie);
            return true;
        }       
    }
}
