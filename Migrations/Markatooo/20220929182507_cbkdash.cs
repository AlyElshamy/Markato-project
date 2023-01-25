using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class cbkdash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                column: "Password",
                value: "-B76ERtLowiNGtH8fYTTU8yqkeAii9O99bP8lhD6xh81");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                column: "Password",
                value: "B76ERtLowiNGtH8fYTTU8yqkeAii9O99bP8lhD6xh81");
        }
    }
}
