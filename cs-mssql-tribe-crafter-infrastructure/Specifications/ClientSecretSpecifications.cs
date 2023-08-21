namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientSecretSpecifications : IEntityTypeConfiguration<ClientSecret>
{
    public void Configure(EntityTypeBuilder<ClientSecret> builder)
    {
        builder.Property(clientGrantType => clientGrantType.Id)
            .HasColumnName("id");
        builder.Property(clientGrantType => clientGrantType.Description)
            .HasColumnName("description");
        builder.Property(clientGrantType => clientGrantType.Value)
            .HasColumnName("value");
        builder.Property(clientGrantType => clientGrantType.Expiration)
            .HasColumnName("expiration");
        builder.Property(clientGrantType => clientGrantType.Type)
            .HasColumnName("type");
        builder.Property(clientGrantType => clientGrantType.Created)
            .HasColumnName("created");
        builder.Property(clientGrantType => clientGrantType.ClientId)
            .HasColumnName("client_id");
    }
}