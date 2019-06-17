using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DeepSea.Migrations
{
    public partial class AddedCreatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Species = table.Column<string>(nullable: true),
                    CountOfTimesSeen = table.Column<int>(nullable: false),
                    LocationOfLastSeen = table.Column<string>(nullable: true),
                    SizeInSquareMiles = table.Column<int>(nullable: false),
                    Elevation = table.Column<float>(nullable: false),
                    Population = table.Column<int>(nullable: false),
                    Visited = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Creatures");
        }
    }
}
