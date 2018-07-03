using Microsoft.EntityFrameworkCore;
using MusicParserAPI.Controllers;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiTest
{
    public class PlaylistTest
    {
        [Fact]
        public void CanCreateSong()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase("apiDB").Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Genre = "Pop",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    PlaylistID = 1
                };
                Song song2 = new Song()
                {
                    Name = "State of Grace",
                    Genre = "Pop",
                    Artist = "Taylor Swift",
                    Album = "Red",
                    PlaylistID = 1
                };
                
                Assert.Equal("Pop", song.Genre);
                Assert.Equal("State of Grace", song2.Name);

            };
        }

        [Fact]
        public void CanCreatePlaylist()
        {
            DbContextOptions<MusicDbContext> options = new
                DbContextOptionsBuilder<MusicDbContext>()
                .UseInMemoryDatabase("testDB").Options;

            using (MusicDbContext context = new MusicDbContext(options))
            {
                PlaylistController pc = new PlaylistController(context);
                var test = pc.PostByGenre(2);
                var test2 = pc.PostByGenre(22);

                var result = pc.GetPlaylistByID(test.Id);
                var result2 = pc.GetPlaylistByID(test2.Id);

                Assert.Equal(test, result);


            }
        }
    }
}
