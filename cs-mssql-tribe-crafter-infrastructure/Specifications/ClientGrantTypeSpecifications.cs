namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientGrantTypeSpecifications : IEntityTypeConfiguration<ClientGrantType>
{
    public void Configure(EntityTypeBuilder<ClientGrantType> builder)
    {
        builder.ToTable("client_grant_type");
        builder.Property(cartItem => cartItem.GrantType)
            .HasColumnName("grant_type");
    }
}