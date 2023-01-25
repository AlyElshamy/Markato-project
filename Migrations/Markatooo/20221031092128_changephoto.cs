using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class changephoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1,
                column: "Image",
                value: "unnamed.png");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                column: "Image",
                value: "KNET.jpeg");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "Image",
                value: "MasterCard_early_1990s_logo.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1,
                column: "Image",
                value: "NBKLogo.png");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                column: "Image",
                value: "NBKLogo.png");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "Image",
                value: "NBKLogo.png");
        }
    }
}
