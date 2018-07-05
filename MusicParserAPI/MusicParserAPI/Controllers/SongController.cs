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
    }
}
