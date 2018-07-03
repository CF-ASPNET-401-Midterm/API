using Microsoft.AspNetCore.Mvc;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicParserAPI.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : Controller
    {
        //[HttpGet("{genreID}")]
        //public async Task<IActionResult> GetByGenre(int? genreID)
        //{
        //    List<Song> ofSongs = new List<Song>();

        //    string x = "[";
        //    using (var client = new HttpClient())
        //    {
        //        string query = "";
        //        if (genreID != null)
        //        {
        //            query = $"&f_music_genre_id={genreID}";

        //        }
        //        // add the appropriate properties on top of the client base address.
        //        client.BaseAddress = new Uri("https://api.musixmatch.com/");

        //        //the .Result is important for us to extract the result of the response from the call
        //        var response = client.GetAsync($"ws/1.1/track.search?format=json&callback=callback{query}&page_size=3&apikey=2bb0516b2619119643fd7b179a16f8b0").Result;
        //        if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
        //        {
        //            var stringResult = await response.Content.ReadAsStringAsync();
        //            Music item = JsonConvert.DeserializeObject<Music>(stringResult);
        //            foreach (TrackList track in item.Message.Body.Track_list)
        //            {
        //                Song song = new Song()
        //                {
        //                    Name = track.Track.Track_name,
        //                    Artist = track.Track.Artist_name,
        //                    Album = track.Track.Album_name,
        //                    Genre = track.Track.Primary_genres.Music_genre_list[0].Music_genre.Music_genre_name,
        //                    ReleaseDate = track.Track.First_release_date
        //                };
                        

        //                 x = x + $"{JsonConvert.SerializeObject(song)}, ";
        //            }
        //            x = x + "]";
        //        }
        //    return RedirectToAction("Create", "Playlist", new { songList = x });
        //        //return NotFound();

        //    }

        //}

        //public string Test(Song song)
        //{
        //    return "Please work";
        //}

    }
}
