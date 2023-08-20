using System.Reflection;

using AmritaDb.Tribe.Infrastructure;

using Autofac;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json",
        false, true)
    .AddUserSecrets(Assembly.GetExecutingAssembly());

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(container =>
{
    container.RegisterModule<InfrastructureModule>();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();