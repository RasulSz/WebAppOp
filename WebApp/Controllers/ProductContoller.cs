using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Sercives;

namespace WebApp.Controllers
{
    public class ProductContoller : Controller
    {
        private readonly IProductService _productService;

        public ProductContoller(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index2()
        {
            var result = await _productService.GetAllByKey();
            return Ok(result);
            
        }
    }
}
