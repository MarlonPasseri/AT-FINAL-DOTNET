using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT_DE_JAVA.Migrations
{
    public partial class DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Talheres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Restaurante",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Talheres");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Restaurante");
        }
    }
}
