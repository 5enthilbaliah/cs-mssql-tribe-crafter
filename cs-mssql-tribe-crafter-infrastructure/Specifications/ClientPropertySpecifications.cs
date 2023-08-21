namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientPropertySpecifications : IEntityTypeConfiguration<ClientProperty>
{
    public void Configure(EntityTypeBuilder<ClientProperty> builder)
    {
        builder.Property(clientGrantType => clientGrantType.Id)
            .HasColumnName("id");
        builder.Property(clientGrantType => clientGrantType.Key)
            .HasColumnName("key");
        builder.Property(clientGrantType => clientGrantType.Value)
            .HasColumnName("value");
        builder.Property(clientGrantType => clientGrantType.ClientId)
            .HasColumnName("client_id");
    }
}