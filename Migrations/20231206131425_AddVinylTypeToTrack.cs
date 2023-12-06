using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class AddVinylTypeToTrack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VinylId",
                table: "Vinyl",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "Track",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vinyl",
                newName: "VinylId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Track",
                newName: "TrackId");
        }
    }
}
