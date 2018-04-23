using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace YourDailyWord.Data.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "WordGalleries",
                newName: "Verse1");

            migrationBuilder.RenameColumn(
                name: "BibleVerse",
                table: "WordGalleries",
                newName: "Description1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Verse1",
                table: "WordGalleries",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Description1",
                table: "WordGalleries",
                newName: "BibleVerse");
        }
    }
}
