using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entitities;
using WebApp.Repositories;

namespace WebApp.Sercives
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllByKey(string key = "")
        {
            var data = await _productRepository.GetAllAsync();
            return key != "" ? data.Where(s => s.Brand.ToLower().Contains(key.ToLower())).ToList() 
                : data;
        }
    }
}
