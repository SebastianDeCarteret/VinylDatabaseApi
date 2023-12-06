using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVinylToRemoveNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vinyl",
                columns: new[] { "VinylId", "Artist", "ImageLink", "NumberOfLps", "NumberOfTracks", "Price", "ReleaseDate", "Title" },
                values: new object[] { 1, "Bon Jovi", "Link", 2, 16, 39.99f, new DateTime(1982, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slippery When Wet" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vinyl",
                keyColumn: "VinylId",
                keyValue: 1);
        }
    }
}
