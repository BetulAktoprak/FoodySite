using Microsoft.AspNetCore.Mvc;

namespace FoodySite.UI.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
