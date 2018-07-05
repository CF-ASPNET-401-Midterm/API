using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    [Route("api/playlist")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private MusicDbContext _context;
        /// <summary>
        /// Creating a reference to our Database
        /// </summary>
        /// <param name="context"></param>
        public PlaylistController(MusicDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Grabs all of the default playlist we have created
        /// </summary>
        /// <returns>A list of Playlists from our database</returns>
        [HttpGet]
        public IEnumerable<Playlist> Get()
        {
            return _context.Playlists;
        }
        /// <summary>
        /// Grabs a specific playlist with the ID of the parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a network 200 OK sign along with the playlist of that id</returns>
        [HttpGet("{id}", Name = "GetPlaylist")]
        public async Task<IActionResult> GetPlaylistByID([FromRoute]int id)
        {
            var playlist = _context.Playlists.FirstOrDefault(l => l.ID == id);
            if (playlist == null)
            {
                return NotFound();
            }
            playlist.Songs = await _context.Songs.Where(i => i.PlaylistID == id).ToListAsync();

            return Ok(playlist);
        }
        /// <summary>
        /// instantiates a playlist based off the genere the user requests for
        /// </summary>
        /// <param name="genreID"></param>
        /// <returns>Sends the created playlist to our Get() method, which displays the playlist</returns>
        [HttpPost("{genreID}")]
        public async Task<IActionResult> PostByGenre(int genreID)
        {
            List<Song> ofSongs = new List<Song>();
            Playlist playlist = new Playlist();
            playlist.GenreID = genreID;
            playlist.Songs = playlist.CreatePlaylist(ofSongs, genreID).Result;
            playlist.Name = playlist.Songs[0].Genre;

            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);
        }
        /// <summary>
        /// Deletes the specific playlist with the id they request
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Nothing</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            var playlist = await _context.Playlists.FindAsync(id);

            if (playlist == null)
            {
                return NotFound();
            }

            List<Song> songs = await _context.Songs.Where(i => i.PlaylistID == id).ToListAsync();

            foreach (Song song in songs)
            {
                _context.Songs.Remove(song);
            }
            
            _context.Playlists.Remove(playlist);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
