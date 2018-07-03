using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicParserAPI.Models
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public string Genre { get; set; }

        public async Task<List<Song>> CreatePlaylist(List<Song> ofSongs, int? genreID)
        {
            using (var client = new HttpClient())
            {
                string query = "";
                if (genreID != null)
                {
                    query = $"&f_music_genre_id={genreID}";

                }
                // add the appropriate properties on top of the client base address.
                client.BaseAddress = new Uri("https://api.musixmatch.com/");

                //the .Result is important for us to extract the result of the response from the call
                var response = client.GetAsync($"ws/1.1/track.search?format=json&callback=callback{query}&page_size=3&apikey=2bb0516b2619119643fd7b179a16f8b0").Result;
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    Music item = JsonConvert.DeserializeObject<Music>(stringResult);
                    foreach (TrackList track in item.Message.Body.Track_list)
                    {
                        Song song = new Song()
                        {
                            Name = track.Track.Track_name,
                            Artist = track.Track.Artist_name,
                            Album = track.Track.Album_name,
                            Genre = track.Track.Primary_genres.Music_genre_list[0].Music_genre.Music_genre_name,
                            ReleaseDate = track.Track.First_release_date
                        };
                        ofSongs.Add(song);
                    };
                }
                return ofSongs;
            }
        }
    }
}
