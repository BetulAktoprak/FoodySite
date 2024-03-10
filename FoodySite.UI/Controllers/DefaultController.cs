using FoodySite.BLL.Abstract;
using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodySite.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Ürünler";
            ViewBag.title2 = "AnaSayfa";
            ViewBag.title3 = "Sayfalar";
            ViewBag.title4 = "Ürün Listesi";

            return View();
        }

        public IActionResult CategoryDetails(int id)
        {
            ViewBag.x = id;
            return View();
        }

        public IActionResult ProductDetails(int id)
        {
            ViewBag.y = id;
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialPageHeader()
        {
            return PartialView();
        }
    }
}
