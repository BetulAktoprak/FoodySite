using FoodySite.BLL.Abstract;
using FoodySite.DataAccess.Context;
using FoodySite.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodySite.BLL.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public List<T> GetAllList(Func<T, bool> filter = null)
        {
            using (var db = new FoodyContext())
            {
                if(filter != null)
                {
                    return db.Set<T>().Where(filter).ToList();
                }
                return db.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var db = new FoodyContext())
            {
                return db.Set<T>().Find(id);
            }
        }

        public void TAdd(T entity)
        {
            using (var db = new FoodyContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        public void TDelete(int id)
        {
            using(var db = new FoodyContext())
            {
                var entity = db.Set<T>().Find(id);
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public void TUpdate(T entity)
        {
            using(var db = new FoodyContext())
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
            }
        }
    }
}
