using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.DataAccess.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        bool Create(T entitie);
        bool Update(T entitie);
        bool Delete(T entitie);
    }
}
