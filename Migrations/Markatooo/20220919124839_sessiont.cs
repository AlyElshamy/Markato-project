using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class sessiont : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "version",
                value: "65");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "version",
                value: "49");
        }
    }
}
