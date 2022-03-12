using System.Collections.Generic;
using ShoppAp.Entity;

namespace ShoppApp.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}