using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M1Shop.Data.Migrations
{
    public partial class CarDetay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    CarDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDateTime = table.Column<DateTime>(nullable: false),
                    Marka = table.Column<string>(nullable: true),
                    Seri = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Yakit = table.Column<string>(nullable: true),
                    Vites = table.Column<string>(nullable: true),
                    CarKm = table.Column<int>(nullable: false),
                    KasaType = table.Column<string>(nullable: true),
                    MotorGücü = table.Column<string>(nullable: true),
                    MotorHacmi = table.Column<string>(nullable: true),
                    Cekis = table.Column<string>(nullable: true),
                    Renk = table.Column<string>(nullable: true),
                    Garanti = table.Column<int>(nullable: false),
                    Plaka = table.Column<string>(nullable: true),
                    Takas = table.Column<int>(nullable: false),
                    Durum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetail", x => x.CarDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarDetail");
        }
    }
}
