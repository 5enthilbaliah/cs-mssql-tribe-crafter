using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tribe.Infrastructure.Migrations.AmritaTribeOperationDb
{
    /// <inheritdoc />
    public partial class InitialOperationDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "grant");

            migrationBuilder.CreateTable(
                name: "device_flow_code",
                schema: "grant",
                columns: table => new
                {
                    user_code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    subject_id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    session_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    client_id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    creation_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device_flow_code", x => x.user_code);
                });

            migrationBuilder.CreateTable(
                name: "key",
                schema: "grant",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    version = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    is_x509_certificate = table.Column<bool>(type: "bit", nullable: false),
                    data_protected = table.Column<bool>(type: "bit", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_key", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persisted_grant",
                schema: "grant",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    subject_id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    session_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    client_id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    creation_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    consumed_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persisted_grant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "server_side_session",
                schema: "grant",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    scheme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    subject_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    session_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    display_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    renewed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_server_side_session", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_device_flow_code_code",
                schema: "grant",
                table: "device_flow_code",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_device_flow_code_expiration",
                schema: "grant",
                table: "device_flow_code",
                column: "expiration");

            migrationBuilder.CreateIndex(
                name: "IX_key_use",
                schema: "grant",
                table: "key",
                column: "use");

            migrationBuilder.CreateIndex(
                name: "IX_persisted_grant_consumed_time",
                schema: "grant",
                table: "persisted_grant",
                column: "consumed_time");

            migrationBuilder.CreateIndex(
                name: "IX_persisted_grant_expiration",
                schema: "grant",
                table: "persisted_grant",
                column: "expiration");

            migrationBuilder.CreateIndex(
                name: "IX_persisted_grant_key",
                schema: "grant",
                table: "persisted_grant",
                column: "key",
                unique: true,
                filter: "[key] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_persisted_grant_subject_id_client_id_type",
                schema: "grant",
                table: "persisted_grant",
                columns: new[] { "subject_id", "client_id", "type" });

            migrationBuilder.CreateIndex(
                name: "IX_persisted_grant_subject_id_session_id_type",
                schema: "grant",
                table: "persisted_grant",
                columns: new[] { "subject_id", "session_id", "type" });

            migrationBuilder.CreateIndex(
                name: "IX_server_side_session_display_name",
                schema: "grant",
                table: "server_side_session",
                column: "display_name");

            migrationBuilder.CreateIndex(
                name: "IX_server_side_session_expires",
                schema: "grant",
                table: "server_side_session",
                column: "expires");

            migrationBuilder.CreateIndex(
                name: "IX_server_side_session_key",
                schema: "grant",
                table: "server_side_session",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_server_side_session_session_id",
                schema: "grant",
                table: "server_side_session",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_server_side_session_subject_id",
                schema: "grant",
                table: "server_side_session",
                column: "subject_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "device_flow_code",
                schema: "grant");

            migrationBuilder.DropTable(
                name: "key",
                schema: "grant");

            migrationBuilder.DropTable(
                name: "persisted_grant",
                schema: "grant");

            migrationBuilder.DropTable(
                name: "server_side_session",
                schema: "grant");
        }
    }
}
