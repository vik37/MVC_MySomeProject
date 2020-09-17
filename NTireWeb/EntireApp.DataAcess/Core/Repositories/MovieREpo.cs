using EntireApp.DataAcess.Core.Entities;
using EntireApp.DataAcess.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EntireApp.DataAcess.Core.Repositories
{
    public class MovieREpo : IREpository<Movie>
    {
        private ILocalDB _db;
        public MovieREpo(ILocalDB db)
        {
            _db = db;
        }
        public bool Create(Movie entity)
        {
            var movie = _db.GetMuvies().SingleOrDefault(x => x.Id == entity.Id);
            if(movie != null)
            {
                return false;
            }
            _db.GetMuvies().ToList().Add(entity);
            return true;
        }

        public bool Delete(Movie entity)
        {
            var movie = _db.GetMuvies().SingleOrDefault(m => m.Id == entity.Id);
            if (movie == null)
            {
                return false;
            }
            _db.GetMuvies().ToList().Remove(entity);
            return true;
        }

        public List<Movie> GetAll()
        {
            return _db.GetMuvies().ToList();
        }

        public Movie GetById(int id)
        {
            return _db.GetMuvies().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Movie entity)
        {
            var movie = _db.GetMuvies().SingleOrDefault(x => x.Id == entity.Id);
            if(movie == null)
            {
                return false;
            }
            _db.GetMuvies().ToList().Remove(entity);
            _db.GetMuvies().ToList().Add(entity);
            return true;
        }
    }
}
