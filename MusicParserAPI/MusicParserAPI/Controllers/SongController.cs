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
        private MusicDbContext _context;

        public SongController(MusicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs;
        }

        [HttpGet("{id}", Name = "GetSong")]
        public IActionResult GetSongByID([FromRoute]int id)
        {
            var song = _context.Songs.FirstOrDefault(l => l.ID == id);
            if (song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Song song)
        {
            await _context.Songs.AddAsync(song);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSong", new { id = song.ID }, song);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody]int playlistID)
        {
            var result = _context.Songs.FirstOrDefault(s => s.ID == id);

            if (result == null)
            {
                return NotFound();
            }

            result.PlaylistID = playlistID;

            _context.Songs.Update(result);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            var song = await _context.Songs.FindAsync(id);

            if (song == null)
            {
                return NotFound();
            }

            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
