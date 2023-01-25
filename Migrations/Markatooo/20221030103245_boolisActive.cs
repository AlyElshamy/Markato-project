using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class boolisActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Gateways",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Gateways");
        }
    }
}
