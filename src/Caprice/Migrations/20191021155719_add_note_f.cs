using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caprice.Migrations
{
    public partial class add_note_f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EditTime",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HtmlText",
                table: "Notes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditTime",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "HtmlText",
                table: "Notes");
        }
    }
}
