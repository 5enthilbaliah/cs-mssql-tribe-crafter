using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tribe.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialConfigutaionDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "client");

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.EnsureSchema(
                name: "api");

            migrationBuilder.CreateTable(
                name: "info",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    client_id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    protocol_type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    require_client_secret = table.Column<bool>(type: "bit", nullable: false),
                    client_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    client_uri = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    logo_uri = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    require_consent = table.Column<bool>(type: "bit", nullable: false),
                    allow_remember_consent = table.Column<bool>(type: "bit", nullable: false),
                    always_include_user_claims_in_id_token = table.Column<bool>(type: "bit", nullable: false),
                    require_pkce = table.Column<bool>(type: "bit", nullable: false),
                    allow_plain_text_pkce = table.Column<bool>(type: "bit", nullable: false),
                    require_request_object = table.Column<bool>(type: "bit", nullable: false),
                    allow_access_tokens_via_browser = table.Column<bool>(type: "bit", nullable: false),
                    require_d_pop = table.Column<bool>(type: "bit", nullable: false),
                    d_pop_validation_mode = table.Column<int>(type: "int", nullable: false),
                    d_pop_clock_skew = table.Column<TimeSpan>(type: "time", nullable: false),
                    front_channel_logout_uri = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    front_channel_logout_session_required = table.Column<bool>(type: "bit", nullable: false),
                    back_channel_logout_uri = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    back_channel_logout_session_required = table.Column<bool>(type: "bit", nullable: false),
                    allow_offline_access = table.Column<bool>(type: "bit", nullable: false),
                    identity_token_lifetime = table.Column<int>(type: "int", nullable: false),
                    allowed_identity_token_signing_algorithms = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    access_token_lifetime = table.Column<int>(type: "int", nullable: false),
                    authorization_code_lifetime = table.Column<int>(type: "int", nullable: false),
                    consent_lifetime = table.Column<int>(type: "int", nullable: true),
                    absolute_refresh_token_lifetime = table.Column<int>(type: "int", nullable: false),
                    sliding_refresh_token_lifetime = table.Column<int>(type: "int", nullable: false),
                    refresh_token_usage = table.Column<int>(type: "int", nullable: false),
                    update_access_token_claims_on_refresh = table.Column<bool>(type: "bit", nullable: false),
                    refresh_token_expiration = table.Column<int>(type: "int", nullable: false),
                    access_token_type = table.Column<int>(type: "int", nullable: false),
                    enable_local_login = table.Column<bool>(type: "bit", nullable: false),
                    include_jwt_id = table.Column<bool>(type: "bit", nullable: false),
                    always_send_client_claims = table.Column<bool>(type: "bit", nullable: false),
                    client_claims_prefix = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    pair_wise_subject_salt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    initiate_login_uri = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    user_sso_lifetime = table.Column<int>(type: "int", nullable: true),
                    user_code_type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    device_code_lifetime = table.Column<int>(type: "int", nullable: false),
                    ciba_lifetime = table.Column<int>(type: "int", nullable: true),
                    polling_interval = table.Column<int>(type: "int", nullable: true),
                    coordinate_lifetime_with_user_session = table.Column<bool>(type: "bit", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_accessed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    non_editable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "provider",
                schema: "identity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scheme = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    display_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_accessed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    non_editable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "resource",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    display_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    allowed_access_token_signing_algorithms = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    show_in_discovery_document = table.Column<bool>(type: "bit", nullable: false),
                    require_resource_indicator = table.Column<bool>(type: "bit", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_accessed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    non_editable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "resource",
                schema: "identity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    display_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    required = table.Column<bool>(type: "bit", nullable: false),
                    emphasize = table.Column<bool>(type: "bit", nullable: false),
                    show_in_discovery_document = table.Column<bool>(type: "bit", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    non_editable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scope",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enabled = table.Column<bool>(type: "bit", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    display_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    required = table.Column<bool>(type: "bit", nullable: false),
                    emphasize = table.Column<bool>(type: "bit", nullable: false),
                    show_in_discovery_document = table.Column<bool>(type: "bit", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_accessed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    non_editable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scope", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "claim",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    value = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claim", x => x.id);
                    table.ForeignKey(
                        name: "FK_claim_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cors_origin",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origin = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cors_origin", x => x.id);
                    table.ForeignKey(
                        name: "FK_cors_origin_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grant_type",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grant_type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grant_type", x => x.id);
                    table.ForeignKey(
                        name: "FK_grant_type_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "id_p_restriction",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_id_p_restriction", x => x.id);
                    table.ForeignKey(
                        name: "FK_id_p_restriction_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_logout_redirect_uri",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_logout_redirect_uri = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_logout_redirect_uri", x => x.id);
                    table.ForeignKey(
                        name: "FK_post_logout_redirect_uri_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    key = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "redirect_uri",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    redirect_uri = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_redirect_uri", x => x.id);
                    table.ForeignKey(
                        name: "FK_redirect_uri_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scope",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scope = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scope", x => x.id);
                    table.ForeignKey(
                        name: "FK_scope_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "secret",
                schema: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    value = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secret", x => x.id);
                    table.ForeignKey(
                        name: "FK_secret_info_client_id",
                        column: x => x.client_id,
                        principalSchema: "client",
                        principalTable: "info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_claim",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    api_resource_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_claim", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_claim_resource_api_resource_id",
                        column: x => x.api_resource_id,
                        principalSchema: "api",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_property",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    api_resource_id = table.Column<int>(type: "int", nullable: false),
                    key = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_property", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_property_resource_api_resource_id",
                        column: x => x.api_resource_id,
                        principalSchema: "api",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_scope",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scope = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    api_resource_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_scope", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_scope_resource_api_resource_id",
                        column: x => x.api_resource_id,
                        principalSchema: "api",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_secret",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    api_resource_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    value = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_secret", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_secret_resource_api_resource_id",
                        column: x => x.api_resource_id,
                        principalSchema: "api",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_claim",
                schema: "identity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identity_resource_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_claim", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_claim_resource_identity_resource_id",
                        column: x => x.identity_resource_id,
                        principalSchema: "identity",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resource_property",
                schema: "identity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identity_resource_id = table.Column<int>(type: "int", nullable: false),
                    key = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_property", x => x.id);
                    table.ForeignKey(
                        name: "FK_resource_property_resource_identity_resource_id",
                        column: x => x.identity_resource_id,
                        principalSchema: "identity",
                        principalTable: "resource",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scope_claim",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scope_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scope_claim", x => x.id);
                    table.ForeignKey(
                        name: "FK_scope_claim_scope_scope_id",
                        column: x => x.scope_id,
                        principalSchema: "api",
                        principalTable: "scope",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scope_property",
                schema: "api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scope_id = table.Column<int>(type: "int", nullable: false),
                    key = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scope_property", x => x.id);
                    table.ForeignKey(
                        name: "FK_scope_property_scope_scope_id",
                        column: x => x.scope_id,
                        principalSchema: "api",
                        principalTable: "scope",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_claim_client_id_type_value",
                schema: "client",
                table: "claim",
                columns: new[] { "client_id", "type", "value" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cors_origin_client_id_origin",
                schema: "client",
                table: "cors_origin",
                columns: new[] { "client_id", "origin" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_grant_type_client_id_grant_type",
                schema: "client",
                table: "grant_type",
                columns: new[] { "client_id", "grant_type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_id_p_restriction_client_id_provider",
                schema: "client",
                table: "id_p_restriction",
                columns: new[] { "client_id", "provider" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_info_client_id",
                schema: "client",
                table: "info",
                column: "client_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_post_logout_redirect_uri_client_id_post_logout_redirect_uri",
                schema: "client",
                table: "post_logout_redirect_uri",
                columns: new[] { "client_id", "post_logout_redirect_uri" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_property_client_id_key",
                schema: "client",
                table: "property",
                columns: new[] { "client_id", "key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_provider_scheme",
                schema: "identity",
                table: "provider",
                column: "scheme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_redirect_uri_client_id_redirect_uri",
                schema: "client",
                table: "redirect_uri",
                columns: new[] { "client_id", "redirect_uri" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_name",
                schema: "api",
                table: "resource",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_name",
                schema: "identity",
                table: "resource",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_claim_api_resource_id_type",
                schema: "api",
                table: "resource_claim",
                columns: new[] { "api_resource_id", "type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_claim_identity_resource_id_type",
                schema: "identity",
                table: "resource_claim",
                columns: new[] { "identity_resource_id", "type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_property_api_resource_id_key",
                schema: "api",
                table: "resource_property",
                columns: new[] { "api_resource_id", "key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_property_identity_resource_id_key",
                schema: "identity",
                table: "resource_property",
                columns: new[] { "identity_resource_id", "key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_scope_api_resource_id_scope",
                schema: "api",
                table: "resource_scope",
                columns: new[] { "api_resource_id", "scope" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_resource_secret_api_resource_id",
                schema: "api",
                table: "resource_secret",
                column: "api_resource_id");

            migrationBuilder.CreateIndex(
                name: "IX_scope_name",
                schema: "api",
                table: "scope",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_scope_client_id_scope",
                schema: "client",
                table: "scope",
                columns: new[] { "client_id", "scope" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_scope_claim_scope_id_type",
                schema: "api",
                table: "scope_claim",
                columns: new[] { "scope_id", "type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_scope_property_scope_id_key",
                schema: "api",
                table: "scope_property",
                columns: new[] { "scope_id", "key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_secret_client_id",
                schema: "client",
                table: "secret",
                column: "client_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "claim",
                schema: "client");

            migrationBuilder.DropTable(
                name: "cors_origin",
                schema: "client");

            migrationBuilder.DropTable(
                name: "grant_type",
                schema: "client");

            migrationBuilder.DropTable(
                name: "id_p_restriction",
                schema: "client");

            migrationBuilder.DropTable(
                name: "post_logout_redirect_uri",
                schema: "client");

            migrationBuilder.DropTable(
                name: "property",
                schema: "client");

            migrationBuilder.DropTable(
                name: "provider",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "redirect_uri",
                schema: "client");

            migrationBuilder.DropTable(
                name: "resource_claim",
                schema: "api");

            migrationBuilder.DropTable(
                name: "resource_claim",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "resource_property",
                schema: "api");

            migrationBuilder.DropTable(
                name: "resource_property",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "resource_scope",
                schema: "api");

            migrationBuilder.DropTable(
                name: "resource_secret",
                schema: "api");

            migrationBuilder.DropTable(
                name: "scope",
                schema: "client");

            migrationBuilder.DropTable(
                name: "scope_claim",
                schema: "api");

            migrationBuilder.DropTable(
                name: "scope_property",
                schema: "api");

            migrationBuilder.DropTable(
                name: "secret",
                schema: "client");

            migrationBuilder.DropTable(
                name: "resource",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "resource",
                schema: "api");

            migrationBuilder.DropTable(
                name: "scope",
                schema: "api");

            migrationBuilder.DropTable(
                name: "info",
                schema: "client");
        }
    }
}
