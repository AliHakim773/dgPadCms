using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dgPadCms.Migrations
{
    public partial class DateTimetoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreationDate",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
