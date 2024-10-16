using DB_First_Demo.Models;

namespace DB_First_Demo.Services
{
    public class CatergoryService : ICategoryService
    {
        private readonly BikeStoresContext _context;
        public CatergoryService(BikeStoresContext context)
        {
            _context = context;
            
        }
        public Category AddNewCategory(Category category)
        {
            if (category != null)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category;
            }
            else
                return null;
        }

        public string DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if(category != null) { 
            _context.Categories.Remove(category);
                _context.SaveChanges();
                return "Category removed .";
            }
            return "Error while remove the category";
        }

        public List<Category> GetCategories()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return category;
        }

        public Category UpdateCategory(Category updatecategory)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == updatecategory.CategoryId);
            if(category != null)
            {
                category.CategoryName = updatecategory.CategoryName;
                _context.SaveChanges();
                return category;
            }
            return null;
            
        }
    }
}
