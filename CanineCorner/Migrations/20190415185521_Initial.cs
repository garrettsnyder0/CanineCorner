using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CanineCorner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<int>(nullable: false),
                    DogName = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    DoB = table.Column<DateTime>(nullable: false),
                    TodayDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medical",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<int>(nullable: false),
                    DogName = table.Column<string>(nullable: true),
                    MedName = table.Column<string>(nullable: true),
                    Periodicity = table.Column<string>(nullable: true),
                    LastDateGiven = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogInfo");

            migrationBuilder.DropTable(
                name: "Medical");
        }
    }
}
