using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Enums;
using NTierApp.DataAccess.Core.Interfaces;
using NtierAppPresentationLayer.ViewModels;
using NtierAppServices.Mapping;
using NtierAppServices.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NtierAppServices.Service.ActualServices
{
    public class VehicleService : IVehicleService
    {
        private IRepository<Vehicles> _vehicleRepo;
        public VehicleService(IRepository<Vehicles> vehicleRepo)
        {
            _vehicleRepo = vehicleRepo;
        }
        public List<VehicleVM> GetAllVehicle()
        {
            var vehicles = _vehicleRepo.GetAll().ToList();
            var thisVehicle = vehicles;
            var vms = Mapper.MapVehicleModelsToVehicleVM(vehicles);
            return vms;
        }

        public VehicleVM GetVehicleById(int id)
        {
            var vehicle = _vehicleRepo.GetById(id);
            var vm = Mapper.MapVehicleFromVehicleVM(vehicle);
            return vm;
        }

        public List<VehicleVM> GetVehicleByKind(Kind vehicleKind)
        {
            var filterVehicle = _vehicleRepo.GetAll().Where(v => v.VehicleKind == vehicleKind).ToList();
            var vms = Mapper.MapVehicleModelsToVehicleVM(filterVehicle);
            return vms;
        }
      
        public List<VehicleVM> GetVehicleByPrice(VehicleVM entitie)
        {
            var filterVehicle = _vehicleRepo.GetAll().Where(v => v.Price == entitie.Price).ToList();
            var vms = Mapper.MapVehicleModelsToVehicleVM(filterVehicle);
            return vms;
        }

        public List<VehicleVM> GetVehicleByType(VehicleVM entitie)
        {
            var filterVehicle = _vehicleRepo.GetAll().Where(v => v.Type == entitie.Type).ToList();
            var vms = Mapper.MapVehicleModelsToVehicleVM(filterVehicle);
            return vms;
        }
    }
}
