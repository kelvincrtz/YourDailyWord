using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace YourDailyWord.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "WordGalleries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "WordGalleries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndexUrl",
                table: "WordGalleries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Verse2",
                table: "WordGalleries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Verse3",
                table: "WordGalleries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description2",
                table: "WordGalleries");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "WordGalleries");

            migrationBuilder.DropColumn(
                name: "IndexUrl",
                table: "WordGalleries");

            migrationBuilder.DropColumn(
                name: "Verse2",
                table: "WordGalleries");

            migrationBuilder.DropColumn(
                name: "Verse3",
                table: "WordGalleries");
        }
    }
}
