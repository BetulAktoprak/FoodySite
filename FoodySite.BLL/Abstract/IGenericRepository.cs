using FoodySite.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodySite.BLL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> GetAllList(Func<T, bool> filter = null);
        T GetById(int id);

    }
}
