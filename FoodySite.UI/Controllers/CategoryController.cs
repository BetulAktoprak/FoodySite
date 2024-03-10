using FoodySite.Dal.Abstract;
using FoodySite.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodySite.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IActionResult Index()
        {
            var values = _categoryDal.GetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if(category.CategoryName != "" && category.CategoryName.Length >= 2)
            {
                _categoryDal.TAdd(category);
            }
            else
            {
                Console.WriteLine("İşlem başarısız!");
            }
            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryDal.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryDal.TUpdate(category);
            return RedirectToAction("Index", "Category");
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryDal.TDelete(id);
            return RedirectToAction("Index", "Category");
        }
    }
}
