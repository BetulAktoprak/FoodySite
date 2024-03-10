using FoodySite.BLL.Abstract;
using FoodySite.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodySite.Dal.Abstract
{
    public interface IProductDal : IGenericRepository<Product>
    {
    }
}
