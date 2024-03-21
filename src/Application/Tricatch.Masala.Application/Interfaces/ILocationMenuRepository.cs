using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Application.Interfaces;

public interface ILocationMenuRepository : IRepository
{
    Task<IEnumerable<LocationMenu>> GetLocationMenusAsync();

    Task<LocationMenu?> GetLocationMenuByIdAsync(int id);
}
