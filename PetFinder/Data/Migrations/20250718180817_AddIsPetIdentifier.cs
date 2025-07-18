using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPetIdentifier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPet",
                table: "PetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPet",
                table: "PetUsers");
        }
    }
}
