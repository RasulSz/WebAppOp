using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Entitities;

namespace WebApp.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task Add(Product product);
    }
}
