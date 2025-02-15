namespace BethanysPieShopAdmin.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategories();
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
}