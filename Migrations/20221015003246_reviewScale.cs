using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunglasses_Assignment1_Ssoma.Migrations
{
    public partial class reviewScale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Sunglasses",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "reviewScale",
                table: "Sunglasses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reviewScale",
                table: "Sunglasses");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Sunglasses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
