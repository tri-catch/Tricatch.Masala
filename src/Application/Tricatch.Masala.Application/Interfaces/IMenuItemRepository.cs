using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Application.Interfaces;

public interface IMenuItemRepository : IRepository
{
    Task<IEnumerable<MenuItem>> GetMenuItemsAsync();

    Task<MenuItem?> GetMenuItemByIdAsync(int id);
}
