namespace AmritaDb.Tribe.Infrastructure;

using Autofac;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class InfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.Register(context =>
        {
            var config = context.Resolve<IConfiguration>();
            var optionsBuilder = new DbContextOptionsBuilder<AmritaTribeDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("AmritaTribeDb"));
            return new AmritaTribeDbContext(optionsBuilder.Options);
        }).InstancePerLifetimeScope();
    }
}