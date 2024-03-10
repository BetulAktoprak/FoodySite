using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Context;
using FoodySite.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FoodySite.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductDal _productDal;
        private readonly FoodyContext _foodyContext;

        public ProductController(IProductDal productDal, FoodyContext foodyContext)
        {
            _productDal = productDal;
            _foodyContext = foodyContext;
        }

        public IActionResult Index()
        {
            var values = _foodyContext.Products.Include(x => x.Category).ToList();
            return View(values);
        }



        [HttpGet]
        public IActionResult CreateProduct()
        {

            List<SelectListItem> categories = (from x in _foodyContext.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName != null ? x.CategoryName : "",
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            product.Status = true;
            if (product.ProductName != "" && product.ProductName.Length >= 2 && product.NewPrice > 0)
            {
                _productDal.TAdd(product);
            }
            else
            {
                Console.WriteLine("İşlem Başarısız");
            }

            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _productDal.GetById(id);

            List<SelectListItem> categories = (from x in _foodyContext.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName != null ? x.CategoryName : "",
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.Categories = categories;

            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            product.Status = true;
            _productDal.TUpdate(product);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult DeleteProduct(int id)
        {
            _productDal.TDelete(id);
            return RedirectToAction("Index", "Product");
        }
    }
}
