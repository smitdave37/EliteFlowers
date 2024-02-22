using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EliteFlowers.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Flowers");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Flowers",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Flowers",
                newName: "FlowerType");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Flowers",
                newName: "Color");

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Flowers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Flowers");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Flowers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "FlowerType",
                table: "Flowers",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Flowers",
                newName: "Genre");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Flowers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
