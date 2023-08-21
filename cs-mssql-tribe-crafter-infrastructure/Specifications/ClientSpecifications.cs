namespace AmritaDb.Tribe.Infrastructure.Specifications;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClientSpecifications  : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(client => client.Id)
            .HasColumnName("id");
        builder.Property(client => client.ClientId)
            .HasColumnName("client_id");
        builder.Property(client => client.ProtocolType)
            .HasColumnName("protocol_type");
        builder.Property(client => client.ClientName)
            .HasColumnName("client_name");
        builder.Property(client => client.ClientUri)
            .HasColumnName("client_uri");
        builder.Property(client => client.LogoUri)
            .HasColumnName("logo_uri");
        builder.Property(client => client.Description)
            .HasColumnName("description");
        builder.Property(client => client.FrontChannelLogoutUri)
            .HasColumnName("front_channel_logout_uri");
        builder.Property(client => client.BackChannelLogoutUri)
            .HasColumnName("back_channel_logout_uri");
        builder.Property(client => client.ClientClaimsPrefix)
            .HasColumnName("client_claims_prefix");
        builder.Property(client => client.PairWiseSubjectSalt)
            .HasColumnName("pair_wise_subject_salt");
        builder.Property(client => client.UserCodeType)
            .HasColumnName("user_code_type");
        builder.Property(client => client.AllowedIdentityTokenSigningAlgorithms)
            .HasColumnName("allowed_identity_token_signing_algorithms");
        builder.Property(client => client.InitiateLoginUri)
            .HasColumnName("initiate_login_uri");
    }
}