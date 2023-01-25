using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations
{
    public partial class UserPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "317b9ff1-d340-4ca6-bcd3-6e30401fd8ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c054a70-fe97-4cab-a436-d28c62d36a74");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c57ad1a-e7ea-4268-b7db-0269519172d5", "4ffc69f0-5a66-43eb-809f-96f0d53146dc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64d1ed6a-c7cd-4de9-9c13-5231e54d45e7", "aea287ed-7ccb-4948-a164-b3a8802c0204", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c57ad1a-e7ea-4268-b7db-0269519172d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64d1ed6a-c7cd-4de9-9c13-5231e54d45e7");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "317b9ff1-d340-4ca6-bcd3-6e30401fd8ab", "46e47aab-1330-4f12-b54c-ac36b74d8b0d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c054a70-fe97-4cab-a436-d28c62d36a74", "7dee8632-8871-4176-ba81-8fbd5ed67941", "Customer", "CUSTOMER" });
        }
    }
}
