using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShoppAp.Entity;
using ShoppApp.DataAccess.Abstract;

namespace ShoppApp.DataAccess.Concrete.EfCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        private ShopContext db = new ShopContext();
        public void Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

      

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}