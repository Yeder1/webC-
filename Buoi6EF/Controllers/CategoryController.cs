using Buoi6EF.Repositories;
using Microsoft.AspNetCore.Mvc;
using Buoi6EF.Models;

namespace Buoi6EF.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IcategoryRepository _categoryRepository;
        private readonly IproductRepository _productRepository;

        public CategoryController(IcategoryRepository categoryRepository, IproductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return View(categories);
        }

        public async Task<IActionResult> Display(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            var products = await _productRepository.GetByCategoryIdAsync(id);
            ViewBag.Category = category;
            return View(products);
        }
    }
}
