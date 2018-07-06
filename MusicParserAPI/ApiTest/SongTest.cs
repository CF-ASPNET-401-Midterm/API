using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicParserAPI.Controllers;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace ApiTest
{
    public class SongTest
    {
        public object SongController { get; private set; }

        [Fact]
        public async void GetAllSongsTest()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                // Arrange
                Playlist playlist = new Playlist()
                {
                    Name = "test"
                };
                await context.Playlists.AddAsync(playlist);
                await context.SaveChangesAsync();
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Today,
                    PlaylistID = 1
                };
                SongController sc = new SongController(context);
                await context.Songs.AddAsync(song);
                await context.SaveChangesAsync();

                // Act
                var result = sc.Get();

                // Assert
                Assert.Equal(context.Songs, result);
            }
        }

        [Fact]
        public async void GetSingleSongTest()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                // Arrange
                Playlist playlist = new Playlist()
                {
                    Name = "test"
                };
                await context.Playlists.AddAsync(playlist);
                await context.SaveChangesAsync();
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Today,
                    PlaylistID = 1
                };
                SongController sc = new SongController(context);
                await context.Songs.AddAsync(song);
                await context.SaveChangesAsync();

                // Act
                var result = sc.GetSongByID(1);
                var answer = (OkObjectResult)result;
                // Assert
                Assert.Equal(HttpStatusCode.OK , (HttpStatusCode)answer.StatusCode);
            }
        }
        [Fact]
        public void CanPostSong()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Today,
                    PlaylistID = 1
                };
                SongController sc = new SongController(context);
                var test = sc.Post(song);
                Assert.Equal(1, test.Id);
            }
        }
        [Fact]
        public void CanPutSong()
        {
            DbContextOptions<MusicDbContext> options =
new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Today,
                    PlaylistID = 1
                };
                context.Songs.AddAsync(song);
                context.SaveChangesAsync();
                SongController sc = new SongController(context);
                var x = sc.Put(1, 2);
                var response = sc.GetSongByID(1);
                var result = (ObjectResult)response;

                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode.Value);
                Assert.Equal(2, song.PlaylistID);
            }
        }


        [Fact]
        public void CanDeleteSong()
        {
            DbContextOptions<MusicDbContext> options =
new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Song song = new Song()
                {
                    Name = "Shake It Off",
                    Artist = "Taylor Swift",
                    Album = "1989",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Today,
                    PlaylistID = 1
                };
                SongController sc = new SongController(context);
                context.Songs.AddAsync(song);
                context.SaveChangesAsync();
                var response = sc.Delete(1).Result;
                var result = (NoContentResult)response;
                Assert.Equal(HttpStatusCode.NoContent, (HttpStatusCode)result.StatusCode);
            }
        }
    }
}
