namespace AmritaDb.Tribe.Infrastructure;

using Duende.IdentityServer.EntityFramework.DbContexts;
using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;

using Specifications.Grant;

public class AmritaTribeOperationDbContext : PersistedGrantDbContext<AmritaTribeOperationDbContext>
{
    public AmritaTribeOperationDbContext(DbContextOptions<AmritaTribeOperationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new PersistedGrantSpecifications()
            .Configure(modelBuilder.Entity<PersistedGrant>());
    }
}