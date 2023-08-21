namespace AmritaDb.Tribe.Infrastructure;

using Duende.IdentityServer.EntityFramework.DbContexts;

using Microsoft.EntityFrameworkCore;

public class AmritaTribeOperationDbContext : PersistedGrantDbContext<AmritaTribeOperationDbContext>
{
    public AmritaTribeOperationDbContext(DbContextOptions<AmritaTribeConfigurationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}