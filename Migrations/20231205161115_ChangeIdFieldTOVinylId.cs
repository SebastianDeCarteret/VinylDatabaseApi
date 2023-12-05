using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdFieldTOVinylId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vinyl",
                table: "Vinyl");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Vinyl");

            migrationBuilder.AlterColumn<int>(
                name: "VinylId",
                table: "Vinyl",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vinyl",
                table: "Vinyl",
                column: "VinylId");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track",
                column: "VinylId",
                principalTable: "Vinyl",
                principalColumn: "VinylId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Vinyl_VinylId",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vinyl",
                table: "Vinyl");

            migrationBuilder.AlterColumn<int>(
                name: "VinylId",
                table: "Vinyl",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Vinyl",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vinyl",
                table: "Vinyl",
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
