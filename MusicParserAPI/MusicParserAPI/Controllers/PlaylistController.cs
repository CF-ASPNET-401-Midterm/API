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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Playlist playlist)
        {
            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody]string name)
        {
            Playlist result = await _context.Playlists.FirstOrDefaultAsync(p => p.ID == id);

            if (result == null)
            {
                return NotFound();
            }

            result.Name = name;

            _context.Playlists.Update(result);
            await _context.SaveChangesAsync();

            return Ok();
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
