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
        /// Grabs values from body, and instantiates a new playlist object with those properties, saves new playlist to database
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns>Get method for that specific playlist</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Playlist playlist)
        {
            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);
        }
        /// <summary>
        /// Put method that allows the changing of the name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns>a 200 OK route, if the playlist doesn't exist then not found page</returns>
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
