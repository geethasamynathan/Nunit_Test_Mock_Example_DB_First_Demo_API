using DB_First_Demo.Models;

namespace DB_First_Demo.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        Category AddNewCategory(Category category);
        Category UpdateCategory(Category category); 
        string DeleteCategory(int id);
    }
}
