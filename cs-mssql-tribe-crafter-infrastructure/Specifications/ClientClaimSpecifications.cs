namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class ClientClaimSpecifications : IEntityTypeConfiguration<ClientClaim>
{
    public void Configure(EntityTypeBuilder<ClientClaim> builder)
    {
        builder.Property(clientGrantType => clientGrantType.Id)
            .HasColumnName("id");
        builder.Property(clientGrantType => clientGrantType.Type)
            .HasColumnName("type");
        builder.Property(clientGrantType => clientGrantType.ClientId)
            .HasColumnName("client_id");
        builder.Property(clientGrantType => clientGrantType.Value)
            .HasColumnName("value");
    }
}