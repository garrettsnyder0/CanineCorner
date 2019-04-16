using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CanineCorner.Migrations
{
    public partial class BreedStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adaptibility",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Overall = table.Column<int>(nullable: false),
                    Apartment = table.Column<int>(nullable: false),
                    NoviceOwners = table.Column<int>(nullable: false),
                    Sensitivity = table.Column<int>(nullable: false),
                    Alone = table.Column<int>(nullable: false),
                    ColdWeather = table.Column<int>(nullable: false),
                    HotWeather = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adaptibility", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Overall = table.Column<int>(nullable: false),
                    EnergyLevel = table.Column<int>(nullable: false),
                    Intensity = table.Column<int>(nullable: false),
                    ExerciseNeed = table.Column<int>(nullable: false),
                    Playfulness = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Friendliness",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Overall = table.Column<int>(nullable: false),
                    WithFamily = table.Column<int>(nullable: false),
                    WithKids = table.Column<int>(nullable: false),
                    OtherDogs = table.Column<int>(nullable: false),
                    WithStrangers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendliness", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Health",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Overall = table.Column<int>(nullable: false),
                    General = table.Column<int>(nullable: false),
                    WeightGain = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Overall = table.Column<int>(nullable: false),
                    Easiness = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Mouthiness = table.Column<int>(nullable: false),
                    PreyDrive = table.Column<int>(nullable: false),
                    Barking = table.Column<int>(nullable: false),
                    Wanderlust = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adaptibility");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Friendliness");

            migrationBuilder.DropTable(
                name: "Health");

            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
