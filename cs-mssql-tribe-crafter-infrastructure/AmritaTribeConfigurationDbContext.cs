namespace AmritaDb.Tribe.Infrastructure;

using Duende.IdentityServer.EntityFramework.DbContexts;

using Microsoft.EntityFrameworkCore;

public class AmritaTribeConfigurationDbContext : ConfigurationDbContext<AmritaTribeConfigurationDbContext>
{
    public AmritaTribeConfigurationDbContext(DbContextOptions<AmritaTribeConfigurationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AmritaTribeConfigurationDbContext).Assembly);
    }
}