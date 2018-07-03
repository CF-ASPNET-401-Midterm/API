using Microsoft.AspNetCore.Mvc;
using MusicParserAPI.Data;
using MusicParserAPI.Models;
using Newtonsoft.Json;
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

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Playlist> GetAll()
        {
            return _context.Playlists;
        }

        //[HttpGet("{id}", Name = "GetPlaylist")]
        //public IActionResult GetPlaylistByID([FromRoute]int id)
        //{
        //    var playlist = _context.Playlists.FirstOrDefault(l => l.ID == id);
        //    if (playlist == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(playlist);
        //}


        [HttpGet(Name = "Create")]
        public async Task<IActionResult> Create(string songList)
        {
            var songs = JsonConvert.DeserializeObject<List<Song>>(songList);
            Playlist playlist = new Playlist()
            {
                Songs = songs.ToList(),
                Name = "John Example"
            };
            await _context.Playlists.AddAsync(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetPlaylist", new { id = playlist.ID }, playlist);
        }
    }
}
