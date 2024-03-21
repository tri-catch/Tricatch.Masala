using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Tricatch.Masala.Infrastructure.Data;

internal class DbContextFactory : IDesignTimeDbContextFactory<MasalaDbContext>
{
    public MasalaDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<MasalaDbContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=Tricatch_Masala;Trusted_Connection=True;MultipleActiveResultSets=true;Connect Timeout=30",
                    optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(MasalaDbContext).GetTypeInfo().Assembly.GetName().Name));
        return new MasalaDbContext(builder.Options);
    }
}
