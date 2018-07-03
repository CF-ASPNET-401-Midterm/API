using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicParserAPI.Migrations
{
    public partial class editPlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Playlists");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Playlists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Playlists");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Playlists",
                nullable: true);
        }
    }
}
