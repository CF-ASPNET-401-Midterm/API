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
    public class PlaylistTest
    {
        [Fact]
        public void CanGetSongName()
        {
            Song song = new Song();
            song.Name = "Shake It Off";
            string name = song.Name;
            Assert.Equal("Shake It Off", name);
        }
        [Fact]
        public void CanSetSongName()
        {
            Song song = new Song();
            song.Name = "Shake It Off";
            string name = "State of Grace";
            song.Name = name;
            Assert.Equal(song.Name, name);
        }
        [Fact]
        public void CanGetSongID()
        {
            Song song = new Song();
            song.ID = 1;
            int id = song.ID;
            Assert.Equal(1, id);
        }
        [Fact]
        public void CanSetSongID()
        {
            Song song = new Song();
            song.ID = 2;
            int id = 5;
            song.ID = id;
            Assert.Equal(song.ID, id);
        }
        [Fact]
        public void CanGetSongGenre()
        {
            Song song = new Song();
            song.Genre = "Pop";
            string genre = song.Genre;
            Assert.Equal("Pop", genre);
        }
        [Fact]
        public void CanSetSongGenre()
        {
            Song song = new Song();
            song.Genre = "Blues";
            string genre = "Jazz";
            song.Genre = genre;
            Assert.Equal(song.Genre, genre);
        }
        [Fact]
        public void CanGetSongAlbum()
        {
            Song song = new Song();
            song.Album = "1989";
            string album = song.Album;
            Assert.Equal("1989", album);
        }
        [Fact]
        public void CanSetSongAlbum()
        {
            Song song = new Song();
            song.Album = "Fearless";
            string album = "Red";
            song.Album = album;
            Assert.Equal(song.Album, album);
        }
        [Fact]
        public void CanGetSongArtist()
        {
            Song song = new Song();
            song.Artist = "Taylor Swift";
            string Artist = song.Artist;
            Assert.Equal("Taylor Swift", Artist);
        }
        [Fact]
        public void CanSetSongArtist()
        {
            Song song = new Song();
            song.Artist = "Taylor Swift";
            string artist = "Still Taylor Swift";
            song.Artist = artist;
            Assert.Equal(song.Artist, artist);
        }
        [Fact]
        public void CanGetSongReleaseDate()
        {
            Song song = new Song();
            song.ReleaseDate = DateTime.Parse("2014 - 01 - 01T00: 00:00");
            DateTime dt = song.ReleaseDate;
            Assert.Equal(DateTime.Parse("2014 - 01 - 01T00: 00:00"), dt);
        }
        [Fact]
        public void CanSetSongReleaseDate()
        {
            Song song = new Song();
            song.ReleaseDate = DateTime.Parse("2014 - 01 - 01T00: 00:00");
            DateTime dt = DateTime.Today;
            song.ReleaseDate = dt;
            Assert.Equal(song.ReleaseDate, dt);
        }
        [Fact]
        public void CanGetSongPlayListID()
        {
            Song song = new Song();
            song.PlaylistID = 5;
            int PlaylistID = song.PlaylistID;
            Assert.Equal(5, PlaylistID);
        }
        [Fact]
        public void CanSetSongPlaylistID()
        {
            Song song = new Song();
            song.PlaylistID = 5;
            int id = 10;
            song.PlaylistID = id;
            Assert.Equal(song.PlaylistID, id);
        }
        [Fact]
        public void CanGetPlaylistID()
        {
            Playlist playlist = new Playlist();
            playlist.ID = 5;
            int ID = playlist.ID;
            Assert.Equal(5, ID);
        }
        [Fact]
        public void CanSetPlaylistID()
        {
            Playlist playlist = new Playlist();
            playlist.ID = 5;
            int ID = 10;
            playlist.ID = ID;
            Assert.Equal(playlist.ID, ID);
        }
        [Fact]
        public void CanGetPlaylistName()
        {
            Playlist playlist = new Playlist();
            playlist.Name = "John";
            string name = playlist.Name;
            Assert.Equal(playlist.Name, name);
        }
        [Fact]
        public void CanSetPlaylistName()
        {
            Playlist playlist = new Playlist();
            playlist.Name = "John";
            string name = "Sam";
            playlist.Name = name;
            Assert.Equal(playlist.Name, name);
        }
        [Fact]
        public void CanGetPlaylistGenre()
        {
            Playlist playlist = new Playlist();
            playlist.Genre = "Jazz";
            string genre = playlist.Genre;
            Assert.Equal("Jazz", genre);
        }
        [Fact]
        public void CanSetPlaylistGenre()
        {
            Playlist playlist = new Playlist();
            playlist.Genre = "Jazz";
            string genre = "Pop";
            playlist.Genre = genre;
            Assert.Equal(playlist.Genre, genre);
        }
        [Fact]
        public void CanGetSongListName()
        {
            Playlist playlist = new Playlist();
            playlist.Songs = new List<Song>();
            Song song = new Song()
            {
                Name = "John",
                ID = 1,
                Artist = "Teacher",
                Album = "Code Fellows",
                Genre = "Folk",
                ReleaseDate = DateTime.Parse("2014 - 01 - 01T00: 00:00"),
                PlaylistID = 1
            };
            playlist.Songs.Add(song);
            Assert.NotEmpty(playlist.Songs);
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
                var test2 = pc.PostByGenre(4);

                Assert.Equal(1, test.Id);
                Assert.Equal(2, test2.Id);
            }
        }
        [Fact]
        public void CanRetrieveSongs()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase("apiDB").Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                var playlist = new Playlist();
                playlist.Songs = new List<Song>();
                playlist.CreatePlaylist(playlist.Songs, 2);
                Assert.NotEmpty(playlist.Songs);
            }
        }
        [Fact]
        public void CanGetPlaylist()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                PlaylistController pc = new PlaylistController(context);
                Playlist playlist = new Playlist();
                playlist.ID = 1;
                playlist.Name = "Test";
                context.Playlists.AddAsync(playlist);
                context.SaveChangesAsync();
                var response = pc.GetPlaylistByID(1).Result;
                var result = (ObjectResult)response;
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode.Value);
            }
        }
        [Fact]
        public void CanGetAllPlaylists()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Playlist playlist = new Playlist();
                playlist.ID = 1;
                playlist.Name = "Test";
                Playlist playlist1 = new Playlist();
                playlist1.ID = 2;
                playlist1.Name = "Test1";
                context.Playlists.AddAsync(playlist);
                context.Playlists.AddAsync(playlist1);
                context.SaveChangesAsync();
                PlaylistController pc = new PlaylistController(context);
                var FakeNews = context.Playlists;
                Assert.Equal(pc.Get(), FakeNews);
            }
        }
        [Fact]
        public void CanDeletePlaylist()
        {
            DbContextOptions<MusicDbContext> options =
            new DbContextOptionsBuilder<MusicDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            using (MusicDbContext context = new MusicDbContext(options))
            {
                Playlist playlist = new Playlist();
                playlist.ID = 1;
                playlist.Name = "Test";
                Playlist playlist1 = new Playlist();
                playlist1.ID = 2;
                playlist1.Name = "Test1";
                context.Playlists.AddAsync(playlist);
                context.Playlists.AddAsync(playlist1);
                context.SaveChangesAsync();
                PlaylistController pc = new PlaylistController(context);
                var response = pc.Delete(1).Result;
                var result = (NoContentResult)response;
                Assert.Equal(HttpStatusCode.NoContent, (HttpStatusCode)result.StatusCode);
            }
        }
    }
}
