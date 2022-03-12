using System.Collections.Generic;
using System.Linq;
using ShopApp.UI.Models;

namespace ShopApp.UI.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId = 1,Name = "Telefonlar", Description = "Telefonlar"},
                new Category {CategoryId = 2,Name = "Bilgisayar", Description = "Bilgisayar"},
                new Category {CategoryId = 3,Name = "Elektronik", Description = "Elektronik"},
            };
        }


        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategoryById(int Id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == Id);
        }
        
        
        
    }
}