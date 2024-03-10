using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodySite.UI.ViewComponents
{
    public class ListByCategoryComponentPartial : ViewComponent
    {
        private readonly FoodyContext _foodyContext;

        public ListByCategoryComponentPartial(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public IViewComponentResult Invoke(int id)
        {
            var productList = _foodyContext.Products.Include(x => x.Category).Where(y => y.CategoryId == id).ToList();
            return View(productList);
        }
    }
}
