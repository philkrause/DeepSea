using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepSea.Migrations
{
    public partial class enteredSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elevation",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "SizeInSquareMiles",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Visited",
                table: "Creatures");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Elevation",
                table: "Creatures",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Creatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeInSquareMiles",
                table: "Creatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Visited",
                table: "Creatures",
                nullable: false,
                defaultValue: false);
        }
    }
}
