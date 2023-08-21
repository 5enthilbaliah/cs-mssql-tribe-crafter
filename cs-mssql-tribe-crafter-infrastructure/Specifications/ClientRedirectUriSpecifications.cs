namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientRedirectUriSpecifications : IEntityTypeConfiguration<ClientRedirectUri>
{
    public void Configure(EntityTypeBuilder<ClientRedirectUri> builder)
    {
        builder.Property(client => client.Id)
            .HasColumnName("id");
        builder.Property(client => client.ClientId)
            .HasColumnName("client_id");
        builder.Property(client => client.RedirectUri)
            .HasColumnName("redirect_uri");
    }
}