using System;
using System.Collections.Generic;
using System.Text;

namespace EntireApp.DataAcess.Core.Interface
{
    public interface IREpository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
