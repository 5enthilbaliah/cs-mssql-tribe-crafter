namespace AmritaDb.Tribe.Infrastructure;

using Autofac;

using Duende.IdentityServer.EntityFramework.Interfaces;
using Duende.IdentityServer.EntityFramework.Options;
using Duende.IdentityServer.EntityFramework.Services;
using Duende.IdentityServer.EntityFramework.Stores;
using Duende.IdentityServer.Hosting.DynamicProviders;
using Duende.IdentityServer.Services;
using Duende.IdentityServer.Stores;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class InfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // ConfigurationStore
        var options = new ConfigurationStoreOptions { ClientGrantType = new TableConfiguration("client_grant_type") };
        builder.Register(_ => options).SingleInstance();
        builder.RegisterType<ClientStore>()
            .InstancePerDependency();
        builder.RegisterType<ValidatingClientStore<ClientStore>>().As<IClientStore>()
            .InstancePerDependency();

        builder.RegisterType<ResourceStore>().As<IResourceStore>()
            .InstancePerDependency();

        builder.RegisterType<CorsPolicyService>().As<ICorsPolicyService>()
            .InstancePerDependency();

        builder.RegisterType<IdentityProviderStore>()
            .InstancePerDependency();
        builder.RegisterType<ValidatingIdentityProviderStore<IdentityProviderStore>>()
            .InstancePerDependency();
        builder.RegisterType<NonCachingIdentityProviderStore<ValidatingIdentityProviderStore<IdentityProviderStore>>>()
            .As<IIdentityProviderStore>()
            .InstancePerDependency();
        
        
        builder.Register(context =>
        {
            var config = context.Resolve<IConfiguration>();
            var optionsBuilder = new DbContextOptionsBuilder<AmritaTribeConfigurationDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("AmritaTribeDb"));
            return new AmritaTribeConfigurationDbContext(optionsBuilder.Options);
        }).As<IConfigurationDbContext>().InstancePerDependency();
    }
}