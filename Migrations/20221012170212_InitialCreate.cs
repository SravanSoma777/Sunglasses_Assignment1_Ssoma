using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunglasses_Assignment1_Ssoma.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sunglasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ShadeType = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    review = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sunglasses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sunglasses");
        }
    }
}
