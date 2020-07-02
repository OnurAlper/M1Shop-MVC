using Microsoft.EntityFrameworkCore.Migrations;

namespace M1Shop.Data.Migrations
{
    public partial class CarUserIlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IlanUser",
                table: "CarDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanUser",
                table: "CarDetail");
        }
    }
}
