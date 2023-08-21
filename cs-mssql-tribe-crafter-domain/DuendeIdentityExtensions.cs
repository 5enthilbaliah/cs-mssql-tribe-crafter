namespace AmritaDb.Tribe.Domain;

using Duende.IdentityServer.EntityFramework.Options;

public static class DuendeIdentityExtensions
{
    public static ConfigurationStoreOptions SpawnOneConfigurationStoreOptions()
    {
        return new ConfigurationStoreOptions
        {
            ApiResource = new TableConfiguration("resource", "api"),
            ApiScope = new TableConfiguration("scope", "api"),
            ApiResourceClaim = new TableConfiguration("resource_claim", "api"),
            ApiResourceProperty = new TableConfiguration("resource_property", "api"),
            ApiResourceScope = new TableConfiguration("resource_scope", "api"),
            ApiResourceSecret = new TableConfiguration("resource_secret", "api"),
            ApiScopeClaim = new TableConfiguration("scope_claim", "api"),
            ApiScopeProperty = new TableConfiguration("scope_property", "api"),
            Client = new TableConfiguration("info", "client"),
            ClientClaim = new TableConfiguration("claim", "client"),
            ClientCorsOrigin = new TableConfiguration("cors_origin", "client"),
            ClientGrantType = new TableConfiguration("grant_type", "client"),
            ClientIdPRestriction = new TableConfiguration("id_p_restriction", "client"),
            ClientPostLogoutRedirectUri = new TableConfiguration("post_logout_redirect_uri", "client"),
            ClientProperty = new TableConfiguration("property", "client"),
            ClientRedirectUri = new TableConfiguration("redirect_uri", "client"),
            ClientScopes = new TableConfiguration("scope", "client"),
            ClientSecret = new TableConfiguration("secret", "client"),
            IdentityProvider = new TableConfiguration("provider", "identity"),
            IdentityResource = new TableConfiguration("resource", "identity"),
            IdentityResourceClaim = new TableConfiguration("resource_claim", "identity"),
            IdentityResourceProperty = new TableConfiguration("resource_property", "identity")
        };
    }
}