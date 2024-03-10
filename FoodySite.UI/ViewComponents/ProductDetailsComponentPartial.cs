using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FoodySite.UI.ViewComponents
{
    public class ProductDetailsComponentPartial : ViewComponent
    {
        private readonly IProductDal _productDal;

        public ProductDetailsComponentPartial(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IViewComponentResult Invoke(int id)
        {
            var product = _productDal.GetById(id);
            return View(product);
        }
    }
}
