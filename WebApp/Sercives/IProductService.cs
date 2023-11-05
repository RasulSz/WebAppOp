using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Entitities;

namespace WebApp.Sercives
{
    public interface IProductService
    {
        Task<List<Product>> GetAllByKey(string key = "");
    }
}
