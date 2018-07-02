using Microsoft.AspNetCore.Mvc;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult GetPlaylistByID([FromRoute]int id)
        {
            var playlist = _context.Playlists.FirstOrDefault(l => l.ID == id);
            playlist.Songs = _context.Songs.Where(i => i.Genre == playlist.Name).ToList();
            if (playlist == null)
            {
                return NotFound();
            }

            return Ok(playlist);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Playlist playlist)
        {
            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);
        }
    }
}
