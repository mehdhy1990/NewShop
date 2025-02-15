namespace BethanysPieShopAdmin.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly PieShopDbContext _context;

    public CategoryRepository(PieShopDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Category> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        throw new NotImplementedException();
    }
}