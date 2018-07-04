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
        public int GenreID { get; set; }
        public List<Song> Songs { get; set; }

        public async Task<List<Song>> CreatePlaylist(int genreID)
        {
            List<Song> ofSongs = new List<Song>();
            using (var client = new HttpClient())
            {
                string query = $"&f_music_genre_id={genreID}";
                
                // add the appropriate properties on top of the client base address.
                client.BaseAddress = new Uri("https://api.musixmatch.com/");

                //the .Result is important for us to extract the result of the response from the call
                var response = client.GetAsync($"ws/1.1/track.search?format=json&callback=callback{query}&page_size=75&apikey=2bb0516b2619119643fd7b179a16f8b0").Result;
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    Random num = new Random();
                    List<int> m = new List<int>();
                    var stringResult = await response.Content.ReadAsStringAsync();
                    Music item = JsonConvert.DeserializeObject<Music>(stringResult);
                    List<TrackList> newList = new List<TrackList>();
                    for(int i = 0; i < 8; i++)
                    {
                        int j = num.Next(0, item.Message.Body.Track_list.Count());
                        if (!m.Contains(j))
                        {
                        m.Add(j);
                        newList.Add(item.Message.Body.Track_list[j]);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    foreach (TrackList track in newList)
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
