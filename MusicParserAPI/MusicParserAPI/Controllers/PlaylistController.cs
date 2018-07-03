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

        public PlaylistController(MusicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Playlist> Get()
        {
            return _context.Playlists;
        }

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

        [HttpPost("{genreID}")]
        public async Task<IActionResult> PostByGenre(int? genreID)
        {
            List<Song> ofSongs = new List<Song>();
            Playlist playlist = new Playlist();
            playlist.GenreID = (genreID != null) ? genreID : 0;
            playlist.Songs = playlist.CreatePlaylist(ofSongs, genreID).Result;
            playlist.Name = (genreID != null) ? playlist.Songs[0].Genre : "Unknown";

            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);

        }

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
