using Microsoft.EntityFrameworkCore.Migrations;

namespace M1Shop.Data.Migrations
{
    public partial class CarilanDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarilanTitle",
                table: "CarDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarilanTitle",
                table: "CarDetail");
        }
    }
}
