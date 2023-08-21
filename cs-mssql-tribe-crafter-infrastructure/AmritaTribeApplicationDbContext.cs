namespace AmritaDb.Tribe.Infrastructure;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AmritaTribeApplicationDbContext : IdentityDbContext
{
    public AmritaTribeApplicationDbContext(DbContextOptions<AmritaTribeApplicationDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<IdentityRole>(b =>
        {
            b.ToTable("asp_net_role");
        });
    }
}