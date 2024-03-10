using FoodySite.BLL.Concrete;
using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodySite.Dal.Concrete
{
    public class CategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
