using KodlamaNTierProject.Business.Abstract.UnitOfWorks;
using KodlamaNTierProject.Business.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaNTierProject.UI.Controllers
{
    public class ProductsController:Controller
    {
        private readonly IServiceManager _manager;

        public ProductsController(IServiceManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var values=await _manager.ProductService.GetAllAsync();
            if(values is null)
            {
                return NotFound();
            }
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ProductCreateDto dto)
        {
            
        }
    }
}