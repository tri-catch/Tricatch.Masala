

using Microsoft.EntityFrameworkCore;
using Tricatch.Masala.Application.Interfaces;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Infrastructure.Data.Repositories;

public class MenuItemRepository(MasalaDbContext dbContext) : IMenuItemRepository
{
    public IUnitOfWork UnitOfWork => dbContext;

    public async Task<MenuItem?> GetMenuItemByIdAsync(int id)
    {
        return await dbContext.MenuItems.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<IEnumerable<MenuItem>> GetMenuItemsAsync()
    {
        return Task.FromResult(dbContext.MenuItems.AsEnumerable());
    }
}
