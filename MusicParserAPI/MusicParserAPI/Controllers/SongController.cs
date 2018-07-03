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
    }
}
