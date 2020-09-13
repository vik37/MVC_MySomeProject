using NTierApp.DataAccess.Core.Enums;
using NtierAppPresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtierAppServices.Service.Interfaces
{
    public interface IVehicleService
    {
        List<VehicleVM> GetAllVehicle();
        VehicleVM GetVehicleById(int id);
        List<VehicleVM> GetVehicleByKind(Kind vehicleKind);
        List<VehicleVM> GetVehicleByType(VehicleVM entitie);
        List<VehicleVM> GetVehicleByPrice(VehicleVM entitie);
    }
}
