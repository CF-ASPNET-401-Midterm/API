using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicParserAPI.Controllers;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ApiTest
{
    public class SongTest
    {
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
                context.Playlists.Add(playlist);
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
                context.Songs.Add(song);
                context.SaveChanges();

                var findSong = await context.Songs.FirstAsync(s => s.Name == song.Name);

                // Act
                var result = sc.GetSongByID(findSong.ID);
                var answer = (OkObjectResult)result;

                // Assert
                Assert.Equal((HttpStatusCode.OK), (HttpStatusCode)answer.StatusCode);
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
                CreatedAtRouteResult carr = (CreatedAtRouteResult)test.Result;
                Song mysoun = (Song)carr.Value;
                Assert.Equal(1, mysoun.ID);
            }
        }
        [Fact]
        public async void CanPutSong()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
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
                await context.Songs.AddAsync(song);
                await context.SaveChangesAsync();
                SongController sc = new SongController(context);
                var findSong = await context.Songs.FirstAsync(s => s.Name == song.Name);
                var x = sc.Put(findSong.ID, 2).Result;
                var result = (OkResult)x;
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);
                Assert.Equal(2, song.PlaylistID);
            }
        }


        [Fact]
        public async Task CanDeleteSong()
        {
            DbContextOptions<MusicDbContext> options =
        new DbContextOptionsBuilder<MusicDbContext>()
        .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

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
                await context.Songs.AddAsync(song);
                await context.SaveChangesAsync();
                var findSong = await context.Songs.FirstAsync(s => s.Name == song.Name);
                var response = sc.Delete(findSong.ID).Result;
                var result = (NoContentResult)response;
                Assert.Equal(HttpStatusCode.NoContent, (HttpStatusCode)result.StatusCode);
            }
        }
    }
}
