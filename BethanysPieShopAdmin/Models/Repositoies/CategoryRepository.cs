using Microsoft.EntityFrameworkCore;

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
        return _context.Categories.OrderBy(c => c.Name);
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await _context.Categories.OrderBy(c => c.CategoryId).ToListAsync();
    }
}