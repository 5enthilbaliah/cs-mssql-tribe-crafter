using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tribe.Infrastructure.Migrations.AmritaTribeApplicationDb
{
    /// <inheritdoc />
    public partial class RemoveIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_AspNetUsers_id",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_claim_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_user_login_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_login");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_role");

            migrationBuilder.DropForeignKey(
                name: "FK_user_token_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_token");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "access_failed_count",
                schema: "asp_net",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "concurrency_stamp",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "email_confirmed",
                schema: "asp_net",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lockout_enabled",
                schema: "asp_net",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "lockout_end",
                schema: "asp_net",
                table: "user",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "normalized_email",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "normalized_user_name",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password_hash",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "phone_number_confirmed",
                schema: "asp_net",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "security_stamp",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "two_factor_enabled",
                schema: "asp_net",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                schema: "asp_net",
                table: "user",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "asp_net",
                table: "user",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "asp_net",
                table: "user",
                column: "normalized_user_name",
                unique: true,
                filter: "[normalized_user_name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_user_claim_user_user_id",
                schema: "asp_net",
                table: "user_claim",
                column: "user_id",
                principalSchema: "asp_net",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_login_user_user_id",
                schema: "asp_net",
                table: "user_login",
                column: "user_id",
                principalSchema: "asp_net",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_user_user_id",
                schema: "asp_net",
                table: "user_role",
                column: "user_id",
                principalSchema: "asp_net",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_token_user_user_id",
                schema: "asp_net",
                table: "user_token",
                column: "user_id",
                principalSchema: "asp_net",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_claim_user_user_id",
                schema: "asp_net",
                table: "user_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_user_login_user_user_id",
                schema: "asp_net",
                table: "user_login");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_user_user_id",
                schema: "asp_net",
                table: "user_role");

            migrationBuilder.DropForeignKey(
                name: "FK_user_token_user_user_id",
                schema: "asp_net",
                table: "user_token");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "access_failed_count",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "concurrency_stamp",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "email",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "email_confirmed",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "lockout_enabled",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "lockout_end",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "normalized_email",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "normalized_user_name",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "password_hash",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "phone_number",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "phone_number_confirmed",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "security_stamp",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "two_factor_enabled",
                schema: "asp_net",
                table: "user");

            migrationBuilder.DropColumn(
                name: "user_name",
                schema: "asp_net",
                table: "user");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    access_failed_count = table.Column<int>(type: "int", nullable: false),
                    concurrency_stamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(type: "bit", nullable: false),
                    lockout_enabled = table.Column<bool>(type: "bit", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    normalized_email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    password_hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "bit", nullable: false),
                    security_stamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    two_factor_enabled = table.Column<bool>(type: "bit", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "normalized_user_name",
                unique: true,
                filter: "[normalized_user_name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_user_AspNetUsers_id",
                schema: "asp_net",
                table: "user",
                column: "id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_claim_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_claim",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_login_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_login",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_role",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_token_AspNetUsers_user_id",
                schema: "asp_net",
                table: "user_token",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
