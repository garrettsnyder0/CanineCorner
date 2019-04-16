using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CanineCorner.Migrations
{
    public partial class BreedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Breed = table.Column<string>(nullable: true),
                    adaptability = table.Column<int>(nullable: false),
                    friendliness = table.Column<int>(nullable: false),
                    health = table.Column<int>(nullable: false),
                    grooming = table.Column<int>(nullable: false),
                    training = table.Column<int>(nullable: false),
                    exercise = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreedInfo");
        }
    }
}
