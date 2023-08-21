namespace AmritaDb.Tribe.Infrastructure;

using Autofac;

using Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class InfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // ConfigurationStore
        builder.Register(context =>
        {
            var config = context.Resolve<IConfiguration>();
            var optionsBuilder = new DbContextOptionsBuilder<AmritaTribeConfigurationDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("AmritaTribeDb"));
            return new AmritaTribeConfigurationDbContext(optionsBuilder.Options)
            {
                StoreOptions = DuendeIdentityExtensions.SpawnOneConfigurationStoreOptions()
            };
        }).InstancePerDependency();
        
        // OperationalStore
        builder.Register(context =>
        {
            var config = context.Resolve<IConfiguration>();
            var optionsBuilder = new DbContextOptionsBuilder<AmritaTribeOperationDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("AmritaTribeDb"));
            return new AmritaTribeOperationDbContext(optionsBuilder.Options)
            {
                StoreOptions = DuendeIdentityExtensions.SpawnOneOperationalStoreOptions()
            };
        }).InstancePerDependency();
    }
}