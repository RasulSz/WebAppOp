using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Sercives;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllByKey();
            return Ok(result);
            
        }
    }
}
