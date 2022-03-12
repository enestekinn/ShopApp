using System.Collections.Generic;
using ShoppAp.Entity;

namespace ShoppApp.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}
