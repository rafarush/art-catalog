using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Database.Migrations;

/// <inheritdoc />
public partial class AddUsertorole : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "fk_roles_users_user_id",
            schema: "public",
            table: "roles");

        migrationBuilder.DropIndex(
            name: "ix_roles_user_id",
            schema: "public",
            table: "roles");

        migrationBuilder.DropColumn(
            name: "user_id",
            schema: "public",
            table: "roles");

        migrationBuilder.CreateTable(
            name: "role_user",
            schema: "public",
            columns: table => new
            {
                roles_id = table.Column<Guid>(type: "uuid", nullable: false),
                users_id = table.Column<Guid>(type: "uuid", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_role_user", x => new { x.roles_id, x.users_id });
                table.ForeignKey(
                    name: "fk_role_user_roles_roles_id",
                    column: x => x.roles_id,
                    principalSchema: "public",
                    principalTable: "roles",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_role_user_users_users_id",
                    column: x => x.users_id,
                    principalSchema: "public",
                    principalTable: "users",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "ix_role_user_users_id",
            schema: "public",
            table: "role_user",
            column: "users_id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "role_user",
            schema: "public");

        migrationBuilder.AddColumn<Guid>(
            name: "user_id",
            schema: "public",
            table: "roles",
            type: "uuid",
            nullable: true);

        migrationBuilder.CreateIndex(
            name: "ix_roles_user_id",
            schema: "public",
            table: "roles",
            column: "user_id");

        migrationBuilder.AddForeignKey(
            name: "fk_roles_users_user_id",
            schema: "public",
            table: "roles",
            column: "user_id",
            principalSchema: "public",
            principalTable: "users",
            principalColumn: "id");
    }
}
