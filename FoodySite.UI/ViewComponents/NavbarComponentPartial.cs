using FoodySite.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodySite.UI.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        private readonly FoodyContext _foodyContext;

        public NavbarComponentPartial(FoodyContext foodyContext)
        {
            _foodyContext = foodyContext;
        }

        public IViewComponentResult Invoke()
        {
            var bar = _foodyContext.Products.Include(x => x.Category).ToList();
            return View(bar);
        }
    }
}
