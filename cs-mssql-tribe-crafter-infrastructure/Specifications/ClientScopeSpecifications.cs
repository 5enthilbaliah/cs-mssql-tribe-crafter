namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientScopeSpecifications : IEntityTypeConfiguration<ClientScope>
{
    public void Configure(EntityTypeBuilder<ClientScope> builder)
    {
        builder.Property(client => client.Id)
            .HasColumnName("id");
        builder.Property(client => client.ClientId)
            .HasColumnName("client_id");
        builder.Property(client => client.Scope)
            .HasColumnName("scope");
    }
}