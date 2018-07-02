using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicParserAPI.Models
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
