using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations
{
    public partial class lastchangepass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangePassword",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "LastChangePassword",
                table: "AspNetUsers");

        }
    }
}
