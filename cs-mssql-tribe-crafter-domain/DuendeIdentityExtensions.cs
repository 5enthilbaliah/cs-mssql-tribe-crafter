namespace AmritaDb.Tribe.Domain;

using Duende.IdentityServer.EntityFramework.Options;

public static class DuendeIdentityExtensions
{
    public static ConfigurationStoreOptions SpawnOneConfigurationStoreOptions()
    {
        return new ConfigurationStoreOptions
        {
            ApiResource = new TableConfiguration("api_resource", "api"),
            ApiScope = new TableConfiguration("api_scope", "api"),
            ApiResourceClaim = new TableConfiguration("api_resource_claim", "api"),
            ApiResourceProperty = new TableConfiguration("api_resource_property", "api"),
            ApiResourceScope = new TableConfiguration("api_resource_scope", "api"),
            ApiResourceSecret = new TableConfiguration("api_resource_secret", "api"),
            ApiScopeClaim = new TableConfiguration("api_scope_claim", "api"),
            ApiScopeProperty = new TableConfiguration("api_scope_property", "api"),
            Client = new TableConfiguration("client", "client"),
            ClientClaim = new TableConfiguration("client_claim", "client"),
            ClientCorsOrigin = new TableConfiguration("client_cors_origin", "client"),
            ClientGrantType = new TableConfiguration("client_grant_type", "client"),
            ClientIdPRestriction = new TableConfiguration("client_id_p_restriction", "client"),
            ClientPostLogoutRedirectUri = new TableConfiguration("client_post_logout_redirect_uri", "client"),
            ClientProperty = new TableConfiguration("client_property", "client"),
            ClientRedirectUri = new TableConfiguration("client_redirect_uri", "client"),
            ClientScopes = new TableConfiguration("client_scope", "client"),
            ClientSecret = new TableConfiguration("client_secret", "client"),
            IdentityProvider = new TableConfiguration("identity_provider", "identity"),
            IdentityResource = new TableConfiguration("identity_resource", "identity"),
            IdentityResourceClaim = new TableConfiguration("identity_resource_claim", "identity"),
            IdentityResourceProperty = new TableConfiguration("identity_resource_property", "identity")
        };
    }
}