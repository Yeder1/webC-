using Buoi6EF.Models;
using Buoi6EF.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi6EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IproductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, IproductRepository productRepository)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}