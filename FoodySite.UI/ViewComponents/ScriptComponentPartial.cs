using Microsoft.AspNetCore.Mvc;

namespace FoodySite.UI.ViewComponents
{
    public class ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
