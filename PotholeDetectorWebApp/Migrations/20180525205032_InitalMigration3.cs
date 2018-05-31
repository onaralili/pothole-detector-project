using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PotholeDetectorWebApp.Migrations
{
    public partial class InitalMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Potholes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "time",
                table: "Potholes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time",
                table: "Potholes");

            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "Potholes",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
