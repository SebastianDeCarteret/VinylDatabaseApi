using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class AddIEnumberableToTrack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track");

            migrationBuilder.DropIndex(
                name: "IX_Track_VinylId",
                table: "Track");

            migrationBuilder.CreateTable(
                name: "TrackVinyl",
                columns: table => new
                {
                    TracksId = table.Column<int>(type: "int", nullable: false),
                    VinylId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackVinyl", x => new { x.TracksId, x.VinylId });
                    table.ForeignKey(
                        name: "FK_TrackVinyl_Track_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Track",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackVinyl_Vinyl_VinylId",
                        column: x => x.VinylId,
                        principalTable: "Vinyl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackVinyl_VinylId",
                table: "TrackVinyl",
                column: "VinylId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackVinyl");

            migrationBuilder.CreateIndex(
                name: "IX_Track_VinylId",
                table: "Track",
                column: "VinylId");

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
