using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy_Management.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            Category category = new Category() { CategoryId = 1, CategoryName = "Alphapitc" };
            categories.Add(category);

            category = new Category() { CategoryId = 2, CategoryName = "Parstmoal" };
            categories.Add(category);

            category = new Category() { CategoryId = 3, CategoryName = "Antibayotic" };
            categories.Add(category);

            return categories;
        }
    }
}
