using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicParserAPI.Models
{
    public class Music
    {
        public Message Message { get; set; }
    }

    public class Message
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
    }

    public class Header : Message
    {
        public int Status_code { get; set; }
        public double Execute_time { get; set; }
        public int Available { get; set; }
    }

    public class Body
    {
        public List<TrackList> Track_list { get; set; }
    }

    public class TrackList
    {
        public Track Track { get; set; }
    }

    public class Track
    {
        public long Track_id { get; set; }
        public string Track_mbid { get; set; }
        public string Track_isrc { get; set; }
        public string Track_spotify_id { get; set; }
        public string Track_soundcloud_id { get; set; }
        public string Track_xboxmusic_id { get; set; }
        public string Track_name { get; set; }
        public string[] Track_name_translation_list { get; set; }
        public int Track_rating { get; set; }
        public int Track_length { get; set; }
        public long Commontrack_id { get; set; }
        public int Instrumental { get; set; }
        public int Explicit { get; set; }
        public int Has_lyrics { get; set; }
        public int Has_lyrics_crowd { get; set; }
        public int Has_subtitles { get; set; }
        public int Has_richsync { get; set; }
        public int Num_favourite { get; set; }
        public long Lyrics_id { get; set; }
        public int Subtitle_id { get; set; }
        public long Album_id { get; set; }
        public string Album_name { get; set; }
        public long Artist_id { get; set; }
        public string Artist_mbid { get; set; }
        public string Artist_name { get; set; }
        public string Album_coverart_100x100 { get; set; }
        public string Album_coverart_350x350 { get; set; }
        public string Album_coverart_500x500 { get; set; }
        public string Album_coverart_800x800 { get; set; }
        public string Track_share_url { get; set; }
        public string Track_edit_url { get; set; }
        public string Commontrack_vanity_id { get; set; }
        public int Restricted { get; set; }
        public DateTime First_release_date { get; set; }
        public DateTime Updated_time { get; set; }
        public PrimaryGenres Primary_genres { get; set; }
        public PrimaryGenres Secondary_genres { get; set; }
    }

    public class PrimaryGenres
    {
        public List<Genre> Music_genre_list { get; set; }
    }

    public class Genre
    {
        public int Music_genre_id { get; set; }
        public int Music_genre_parent_id { get; set; }
        public string Music_genre_name { get; set; }
        public string Music_genre_name_extended { get; set; }
        public string Music_genre_vanity { get; set; }
    }
}
