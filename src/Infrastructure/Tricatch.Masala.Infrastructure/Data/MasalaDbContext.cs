using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Tricatch.Masala.Application.Interfaces;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Infrastructure.Data;

public class MasalaDbContext : DbContext, IUnitOfWork
{
    internal DbSet<LocationMenu> LocationMenus { get; set; }

    internal DbSet<MenuItem> MenuItems { get; set; }  

    public MasalaDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new LocationMenuConfiguration());
    }

    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e is { Entity: IEntity, State: EntityState.Modified }).ToList();

        foreach (var entityEntry in entries)
        {
            ((IEntity)entityEntry.Entity).LastModifiedDateUTC = DateTime.UtcNow;
        }

        var result = await base.SaveChangesAsync(cancellationToken);

        return true;
    }
}
