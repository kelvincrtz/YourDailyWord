using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace YourDailyWord.Data.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "DailyDevotionInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "DailyDevotionInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description4",
                table: "DailyDevotionInfos");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "DailyDevotionInfos");
        }
    }
}
