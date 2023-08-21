﻿namespace AmritaDb.Tribe.Infrastructure.Specifications.Identity;

using Duende.IdentityServer.EntityFramework.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class IdentityResourceClaimSpecifications : IEntityTypeConfiguration<IdentityResourceClaim>
{
    public void Configure(EntityTypeBuilder<IdentityResourceClaim> builder)
    {
        builder.Property(identityResource => identityResource.Id)
            .HasColumnName("id");
        builder.Property(identityResource => identityResource.IdentityResourceId)
            .HasColumnName("identity_resource_id");
        builder.Property(identityResource => identityResource.Type)
            .HasColumnName("type");
    }
}