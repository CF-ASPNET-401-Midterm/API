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
        /// <summary>
        /// Our hidden reference to the database
        /// </summary>
        /// <param name="context"></param>
        public SongController(MusicDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Grabs all songs in our database
        /// </summary>
        /// <returns>A list of all the songs</returns>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs;
        }

        /// <summary>
        /// grabs a specific song with the ID of the parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a 200 status code with our song object</returns>
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
        /// <summary>
        /// Creates a new song and adds it to our Song Database
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Song song)
        {
            await _context.Songs.AddAsync(song);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSong", new { id = song.ID }, song);
        }
        /// <summary>
        /// Updates the playlist ID of a specific song
        /// </summary>
        /// <param name="id"></param>
        /// <param name="playlistID"></param>
        /// <returns>a 200 OK</returns>
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
        /// <summary>
        /// Deletes a specific song from our Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Nothing</returns>
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
