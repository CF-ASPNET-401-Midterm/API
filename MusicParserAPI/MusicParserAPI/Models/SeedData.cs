using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicParserAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicParserAPI.Models
{
    public class SeedData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            var context = new MusicDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicDbContext>>());
            using (context)
            {
                // Look for any playlists.
                if (context.Playlists.Any())
                {
                    return;   // DB has been seeded
                }
                Playlist playlist = new Playlist();
                await context.Playlists.AddRangeAsync(
                    new Playlist
                    {
                        Name = "Blues",
                        GenreID = 2,
                        Songs = playlist.CreatePlaylist(2).Result
                    },

                    new Playlist
                    {
                        Name = "Comedy",
                        GenreID = 3,
                        Songs = playlist.CreatePlaylist(3).Result
                    },

                    new Playlist
                    {
                        Name = "Children's Music",
                        GenreID = 4,
                        Songs = playlist.CreatePlaylist(4).Result
                    },

                    new Playlist
                    {
                        Name = "Country",
                        GenreID = 6,
                        Songs = playlist.CreatePlaylist(6).Result
                    },

                    new Playlist
                    {
                        Name = "Holiday",
                        GenreID = 8,
                        Songs = playlist.CreatePlaylist(8).Result
                    },

                    new Playlist
                    {
                        Name = "Opera",
                        GenreID = 9,
                        Songs = playlist.CreatePlaylist(9).Result
                    },

                    new Playlist
                    {
                        Name = "Singer/Songwriter",
                        GenreID = 10,
                        Songs = playlist.CreatePlaylist(10).Result
                    },

                    new Playlist
                    {
                        Name = "Soundtrack",
                        GenreID = 16,
                        Songs = playlist.CreatePlaylist(16).Result
                    },

                    new Playlist
                    {
                        Name = "Hip Hop/Rap",
                        GenreID = 18,
                        Songs = playlist.CreatePlaylist(18).Result
                    },

                    new Playlist
                    {
                        Name = "Alternative",
                        GenreID = 20,
                        Songs = playlist.CreatePlaylist(20).Result
                    },

                    new Playlist
                    {
                        Name = "Christian & Gospel",
                        GenreID = 22,
                        Songs = playlist.CreatePlaylist(22).Result
                    },

                    new Playlist
                    {
                        Name = "Easy Listening",
                        GenreID = 25,
                        Songs = playlist.CreatePlaylist(15).Result
                    },

                    new Playlist
                    {
                        Name = "Instrumental",
                        GenreID = 53,
                        Songs = playlist.CreatePlaylist(53).Result
                    }
                );
                await context.SaveChangesAsync();

            }
            using (context)
            {
                foreach (Playlist list in context.Playlists)
                {
                    foreach (Song song in list.Songs)
                    {
                        await context.Songs.AddAsync(song);
                    }
                }
                await context.SaveChangesAsync();
            }
        }

    }
}
