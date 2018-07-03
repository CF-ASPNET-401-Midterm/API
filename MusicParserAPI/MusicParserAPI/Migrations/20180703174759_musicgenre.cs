using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicParserAPI.Migrations
{
    public partial class musicgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Playlists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Playlists");
        }
    }
}
