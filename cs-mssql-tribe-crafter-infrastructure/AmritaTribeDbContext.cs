namespace AmritaDb.Tribe.Infrastructure;

using Microsoft.EntityFrameworkCore;

public class AmritaTribeDbContext : DbContext
{
    public AmritaTribeDbContext(DbContextOptions<AmritaTribeDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AmritaTribeDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}