using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Context;
using FoodySite.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodySite.UI.ViewComponents
{
    public class ProductListComponentPartial : ViewComponent
    {
        private readonly FoodyContext _foodyContext;

        public ProductListComponentPartial(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public IViewComponentResult Invoke(string filter)
        {
            var products = _foodyContext.Products.Include(x => x.Category).ToList();

            if (!string.IsNullOrEmpty(filter))
            {
                products = products.Where(x => x.ProductName.Contains(filter)).ToList();
            }
            
            return View(products);
        }
    }
}
