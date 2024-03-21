using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Tricatch.Masala.Application.Interfaces;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Infrastructure.Data.Repositories;

public class LocationMenuRepository(MasalaDbContext dbContext) : ILocationMenuRepository
{
    public IUnitOfWork UnitOfWork => dbContext;

    public async Task<LocationMenu?> GetLocationMenuByIdAsync(int id)
    {
        return await dbContext.LocationMenus.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<IEnumerable<LocationMenu>> GetLocationMenusAsync()
    {
        return Task.FromResult(dbContext.LocationMenus.AsEnumerable());
    }
}
