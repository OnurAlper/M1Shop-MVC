using Microsoft.EntityFrameworkCore.Migrations;

namespace M1Shop.Data.Migrations
{
    public partial class CarPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "CarDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "CarDetail");
        }
    }
}
