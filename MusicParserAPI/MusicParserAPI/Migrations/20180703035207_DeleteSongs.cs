using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicParserAPI.Migrations
{
    public partial class DeleteSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_PlaylistID",
                table: "Songs");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistID",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_PlaylistID",
                table: "Songs",
                column: "PlaylistID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_PlaylistID",
                table: "Songs");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistID",
                table: "Songs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_PlaylistID",
                table: "Songs",
                column: "PlaylistID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
