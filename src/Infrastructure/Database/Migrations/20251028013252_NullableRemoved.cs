using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Database.Migrations;

/// <inheritdoc />
public partial class NullableRemoved : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "users",
            type: "boolean",
            nullable: false,
            defaultValue: false,
            oldClrType: typeof(bool),
            oldType: "boolean",
            oldNullable: true);

        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "todo_items",
            type: "boolean",
            nullable: false,
            defaultValue: false,
            oldClrType: typeof(bool),
            oldType: "boolean",
            oldNullable: true);

        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "roles",
            type: "boolean",
            nullable: false,
            defaultValue: false,
            oldClrType: typeof(bool),
            oldType: "boolean",
            oldNullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "users",
            type: "boolean",
            nullable: true,
            oldClrType: typeof(bool),
            oldType: "boolean");

        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "todo_items",
            type: "boolean",
            nullable: true,
            oldClrType: typeof(bool),
            oldType: "boolean");

        migrationBuilder.AlterColumn<bool>(
            name: "is_deleted",
            schema: "public",
            table: "roles",
            type: "boolean",
            nullable: true,
            oldClrType: typeof(bool),
            oldType: "boolean");
    }
}
