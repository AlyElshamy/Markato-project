using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class updateimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1,
                column: "Image",
                value: "Images/NBKLogo.png");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                column: "Image",
                value: "Images/NBKLogo.png");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "Image",
                value: "Images/NBKLogo.png");
        }
    }
}
