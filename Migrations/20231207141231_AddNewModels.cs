using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class AddNewModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Track",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Vinyl");

            migrationBuilder.RenameTable(
                name: "Track",
                newName: "Tracks");

            migrationBuilder.RenameIndex(
                name: "IX_Track_VinylId",
                table: "Tracks",
                newName: "IX_Tracks_VinylId");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Vinyl",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Vinyl",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    VinylId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Band",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    VinylId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_ArtistId",
                table: "Vinyl",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_BandId",
                table: "Vinyl",
                column: "BandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Vinyl_VinylId",
                table: "Tracks",
                column: "VinylId",
                principalTable: "Vinyl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyl_Artist_ArtistId",
                table: "Vinyl",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyl_Band_BandId",
                table: "Vinyl",
                column: "BandId",
                principalTable: "Band",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Vinyl_VinylId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyl_Artist_ArtistId",
                table: "Vinyl");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyl_Band_BandId",
                table: "Vinyl");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Band");

            migrationBuilder.DropIndex(
                name: "IX_Vinyl_ArtistId",
                table: "Vinyl");

            migrationBuilder.DropIndex(
                name: "IX_Vinyl_BandId",
                table: "Vinyl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Vinyl");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Vinyl");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Track");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_VinylId",
                table: "Track",
                newName: "IX_Track_VinylId");

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Vinyl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Track",
                table: "Track",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track",
                column: "VinylId",
                principalTable: "Vinyl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
