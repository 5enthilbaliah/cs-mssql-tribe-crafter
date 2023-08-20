namespace AmritaDb.Tribe.Domain;

using Duende.IdentityServer.EntityFramework.Options;

public static class DuendeEntityExtensions
{
    public static ConfigurationStoreOptions SpawnOneConfigurationStoreOptions()
    {
        return new ConfigurationStoreOptions
        {
            ApiResource = new TableConfiguration("api_resource"),
            ApiScope = new TableConfiguration("api_scope"),
            Client = new TableConfiguration("client"), 
            IdentityProvider = new TableConfiguration("identity_provider"),
            IdentityResource = new TableConfiguration("identity_resource"),
            ApiResourceClaim = new TableConfiguration("api_resource_claim"),
            ApiResourceProperty = new TableConfiguration("api_resource_property"),
            ApiResourceScope = new TableConfiguration("api_resource_scope"),
            ApiResourceSecret = new TableConfiguration("api_resource_secret"),
            ApiScopeClaim = new TableConfiguration("api_scope_claim"),
            ApiScopeProperty = new TableConfiguration("api_scope_property"),
            ClientClaim = new TableConfiguration("client_claim"),
            ClientCorsOrigin = new TableConfiguration("client_cors_origin"),
            ClientGrantType = new TableConfiguration("client_grant_type"),
            ClientIdPRestriction = new TableConfiguration("client_id_p_restriction"),
            ClientPostLogoutRedirectUri = new TableConfiguration("client_post_logout_redirect_uri"),
            ClientProperty = new TableConfiguration("client_property"),
            ClientRedirectUri = new TableConfiguration("client_redirect_uri"),
            ClientScopes = new TableConfiguration("client_scope"),
            ClientSecret = new TableConfiguration("client_secret"),
            IdentityResourceClaim = new TableConfiguration("identity_resource_claim"),
            IdentityResourceProperty = new TableConfiguration("identity_resource_property")
        };
    }
}