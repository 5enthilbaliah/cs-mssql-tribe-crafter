namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientCorsOriginSpecifications : IEntityTypeConfiguration<ClientCorsOrigin>
{
    public void Configure(EntityTypeBuilder<ClientCorsOrigin> builder)
    {
        builder.Property(clientGrantType => clientGrantType.Id)
            .HasColumnName("id");
        builder.Property(clientGrantType => clientGrantType.Origin)
            .HasColumnName("origin");
        builder.Property(clientGrantType => clientGrantType.ClientId)
            .HasColumnName("client_id");
    }
}