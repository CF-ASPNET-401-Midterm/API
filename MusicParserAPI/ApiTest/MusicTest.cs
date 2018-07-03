using MusicParserAPI.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiTest
{
    public class MusicTest
    {
        [Fact]
        public void GenreMusicIDGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12
            };

            // Act 
            // (get)
            int musicGenreID = genre.Music_genre_id;

            // Assert
            Assert.Equal(12, musicGenreID);
        }
        [Fact]
        public void GenreMusicIDSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12
            };

            // Act 
            // (set)
            genre.Music_genre_id = 15;
            // (get)
            int musicGenreID = genre.Music_genre_id;

            // Assert
            Assert.Equal(15, musicGenreID);
        }

        [Fact]
        public void GenreMusicParentIDGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_parent_id = 12
            };

            // Act 
            // (get)
            int musicGenreParentID = genre.Music_genre_parent_id;

            // Assert
            Assert.Equal(12, musicGenreParentID);
        }
        [Fact]
        public void GenreMusicParentIDSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_parent_id = 12
            };

            // Act 
            // (set)
            genre.Music_genre_parent_id = 15;
            // (get)
            int musicGenreParentID = genre.Music_genre_parent_id;

            // Assert
            Assert.Equal(15, musicGenreParentID);
        }

        [Fact]
        public void GenreMusicNameGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_name = "Rock"
            };

            // Act 
            // (get)
            string MusicGenre = genre.Music_genre_name;

            // Assert
            Assert.Equal("Rock", MusicGenre);
        }
        [Fact]
        public void GenreMusicNameSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_name = "Rock"
            };

            // Act 
            // (set)
            genre.Music_genre_name = "Rock and Roll";
            // (get)
            string MusicGenre = genre.Music_genre_name;

            // Assert
            Assert.Equal("Rock and Roll", MusicGenre);
        }

        [Fact]
        public void GenreMusicNameExtendedGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_name_extended = "Rock and Roll"
            };

            // Act 
            // (get)
            string MusicGenreExtended = genre.Music_genre_name_extended;

            // Assert
            Assert.Equal("Rock and Roll", MusicGenreExtended);
        }
        [Fact]
        public void GenreMusicNameExtendedSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_name_extended = "Rock and Roll"
            };

            // Act 
            // (set)
            genre.Music_genre_name_extended = "Rock and Roll Now";
            // (get)
            string MusicGenreExtended = genre.Music_genre_name_extended;

            // Assert
            Assert.Equal("Rock and Roll Now", MusicGenreExtended);
        }

        [Fact]
        public void GenreMusicVanityGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_vanity = "vanity"
            };

            // Act 
            // (get)
            string MusicVanity = genre.Music_genre_vanity;

            // Assert
            Assert.Equal("vanity", MusicVanity);
        }
        [Fact]
        public void GenreMusicVanitySetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_vanity = "vanity"
            };

            // Act 
            // (set)
            genre.Music_genre_vanity = "vanities";
            // (get)
            string MusicVanity = genre.Music_genre_vanity;

            // Assert
            Assert.Equal("vanities", MusicVanity);
        }

        [Fact]
        public void MusicGenreListGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };

            // Act 
            // (get)
            Genre testGenre = musicGenreList.Music_genre;

            // Assert
            Assert.Equal(genre, testGenre);
        }
        [Fact]
        public void MusicGenreListSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };
            Genre genre2 = new Genre
            {
                Music_genre_id = 15,
                Music_genre_parent_id = 15,
                Music_genre_name = "Rocky",
                Music_genre_name_extended = "Rocky and Rolly",
                Music_genre_vanity = "vanities"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };

            // Act 
            // (set)
            musicGenreList.Music_genre = genre2;
            // (get)
            Genre testGenre = musicGenreList.Music_genre;

            // Assert
            Assert.Equal(genre2, testGenre);
        }

        [Fact]
        public void PrimaryGenresGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };

            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };

            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };

            PrimaryGenres primaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };

            // Act 
            // (get)
            List<MusicGenreList> testMusicGenreList = primaryGenres.Music_genre_list;

            // Assert
            Assert.Equal(musicGenreLists, testMusicGenreList);
        }
        [Fact]
        public void PrimaryGenresSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };
            Genre genre2 = new Genre
            {
                Music_genre_id = 15,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rocky",
                Music_genre_name_extended = "Rocky and Rolly",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = genre2
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };

            // Act 
            // (set)
            primaryGenres.Music_genre_list = musicGenreLists2;
            // (get)
            List<MusicGenreList> testMusicGenreList = primaryGenres.Music_genre_list;

            // Assert
            Assert.Equal(musicGenreLists2, testMusicGenreList);
        }

        [Fact]
        public void TrackPrimaryGenreGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };

            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };

            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };

            PrimaryGenres primaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };

            Track track = new Track()
            {
                Primary_genres = primaryGenres
            };

            // Act 
            // (get)
            PrimaryGenres testPrimaryGenres = track.Primary_genres;

            // Assert
            Assert.Equal(primaryGenres, testPrimaryGenres);
        }
        [Fact]
        public void TrackPrimaryGenresSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };
            Genre genre2 = new Genre
            {
                Music_genre_id = 15,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rocky",
                Music_genre_name_extended = "Rocky and Rolly",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = genre2
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };
            PrimaryGenres primaryGenres2 = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };
            Track track = new Track()
            {
                Primary_genres = primaryGenres
            };

            // Act 
            // (set)
            track.Primary_genres = primaryGenres2;

            // (get)
            PrimaryGenres testPrimaryGenres = track.Primary_genres;

            // Assert
            Assert.Equal(primaryGenres2, testPrimaryGenres);
        }
        [Fact]
        public void TrackSecondaryGenreGetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };

            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };

            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };

            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };

            Track track = new Track()
            {
                Secondary_genres = secondaryGenres
            };

            // Act 
            // (get)
            PrimaryGenres testSecondaryGenres = track.Secondary_genres;

            // Assert
            Assert.Equal(secondaryGenres, testSecondaryGenres);
        }
        [Fact]
        public void TrackSecondaryGenresSetTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };
            Genre genre2 = new Genre
            {
                Music_genre_id = 15,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rocky",
                Music_genre_name_extended = "Rocky and Rolly",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = genre2
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };
            PrimaryGenres secondaryGenres2 = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };
            Track track = new Track()
            {
                Secondary_genres = secondaryGenres
            };

            // Act 
            // (set)
            track.Secondary_genres = secondaryGenres2;

            // (get)
            PrimaryGenres testSecondaryGenres = track.Secondary_genres;

            // Assert
            Assert.Equal(secondaryGenres2, testSecondaryGenres);
        }

        [Fact]
        public void FirstReleaseDateGetTest()
        {
            // Arrange
            DateTime dateTime = new DateTime(2001, 12, 23);
            Track track = new Track()
            {
                First_release_date = dateTime
            };

            // Act
            // (get)
            DateTime testTime = track.First_release_date;

            // Assert
            Assert.Equal(dateTime, testTime);

        }
        [Fact]
        public void FirstReleaseDateSetTest()
        {
            // Arrange
            DateTime dateTime = new DateTime(2001, 12, 23);
            DateTime dateTime2 = new DateTime(2002, 2, 22);
            Track track = new Track()
            {
                First_release_date = dateTime
            };

            // Act
            // (set)
            track.First_release_date = dateTime2;
            // (get)
            DateTime testTime = track.First_release_date;

            // Assert
            Assert.Equal(dateTime2, testTime);

        }

        [Fact]
        public void UpdatedTimeGetTest()
        {
            // Arrange
            DateTime dateTime = new DateTime(2001, 12, 23);
            Track track = new Track()
            {
                Updated_time = dateTime
            };

            // Act
            // (get)
            DateTime testTime = track.Updated_time;

            // Assert
            Assert.Equal(dateTime, testTime);

        }
        [Fact]
        public void UpdatedTimeSetTest()
        {
            // Arrange
            DateTime dateTime = new DateTime(2001, 12, 23);
            DateTime dateTime2 = new DateTime(2002, 2, 22);
            Track track = new Track()
            {
                Updated_time = dateTime
            };

            // Act
            // (set)
            track.Updated_time = dateTime2;
            // (get)
            DateTime testTime = track.Updated_time;

            // Assert
            Assert.Equal(dateTime2, testTime);

        }

        [Fact]
        public void RestrictedGetTest()
        {
            // Arrange
            int restr = 1;
            Track track = new Track()
            {
                Restricted = restr
            };

            // Act
            // (get)
            int testRestr = track.Restricted;

            // Assert
            Assert.Equal(restr, testRestr);
        }
        [Fact]
        public void RestrictedSetTest()
        {
            // Arrange
            int restr = 1;
            int restr2 = 0;
            Track track = new Track()
            {
                Restricted = restr
            };

            // Act
            // (set)
            track.Restricted = restr2;
            // (get)
            int testRestr = track.Restricted;

            // Assert
            Assert.Equal(restr2, testRestr);
        }

        [Fact]
        public void CommonTrackVanityIDGetTest()
        {
            // Arrange
            string vanityID = "a490sle09930kdls";
            Track track = new Track()
            {
                Commontrack_vanity_id = vanityID
            };

            // Act
            // (get)
            string testVanityID = track.Commontrack_vanity_id;

            // Assert
            Assert.Equal(vanityID, testVanityID);
        }
        [Fact]
        public void CommonTrackVanityIDSetTest()
        {
            // Arrange
            string vanityID = "a490sle09930kdls";
            string vanityID2 = "a490sle09930kdls3fljgoi";
            Track track = new Track()
            {
                Commontrack_vanity_id = vanityID
            };

            // Act
            // (set)
            track.Commontrack_vanity_id = vanityID2;
            // (get)
            string testVanityID = track.Commontrack_vanity_id;

            // Assert
            Assert.Equal(vanityID2, testVanityID);
        }

        [Fact]
        public void TrackShareUrlGetTest()
        {
            // Arrange
            string url = "test.com";
            Track track = new Track()
            {
                Track_share_url = url
            };

            // Act
            // (get)
            string testUrl = track.Track_share_url;

            // Assert
            Assert.Equal(url, testUrl);
        }
        [Fact]
        public void TrackShareUrlSetTest()
        {
            // Arrange
            string url = "test.com";
            string url2 = "testing.com";
            Track track = new Track()
            {
                Track_share_url = url
            };

            // Act
            // (set)
            track.Track_share_url = url2;

            // (get)
            string testUrl = track.Track_share_url;

            // Assert
            Assert.Equal(url2, testUrl);
        }

        [Fact]
        public void TrackEditUrlGetTest()
        {
            // Arrange
            string url = "test.com";
            Track track = new Track()
            {
                Track_edit_url = url
            };

            // Act
            // (get)
            string testUrl = track.Track_edit_url;

            // Assert
            Assert.Equal(url, testUrl);
        }
        [Fact]
        public void TrackEditUrlSetTest()
        {
            // Arrange
            string url = "test.com";
            string url2 = "testing.com";
            Track track = new Track()
            {
                Track_edit_url = url
            };

            // Act
            // (set)
            track.Track_edit_url = url2;

            // (get)
            string testUrl = track.Track_edit_url;

            // Assert
            Assert.Equal(url2, testUrl);
        }
        
        [Fact]
        public void AlbumCoverArt100GetTest()
        {
            // Arrange
            string albumCoverArt100 = "cover:100";
            Track track = new Track()
            {
                Album_coverart_100x100 = albumCoverArt100
            };

            // Act
            // (get)
            string testAlbum = track.Album_coverart_100x100;

            // Assert
            Assert.Equal(albumCoverArt100, testAlbum);
        }        
        [Fact]
        public void AlbumCoverArt100SetTest()
        {
            // Arrange
            string albumCoverArt100 = "cover:100";
            string album2CoverArt100 = "cover2:100";
            Track track = new Track()
            {
                Album_coverart_100x100 = albumCoverArt100
            };

            // Act
            // (set)
            track.Album_coverart_100x100 = album2CoverArt100;
            // (get)
            string testAlbum = track.Album_coverart_100x100;

            // Assert
            Assert.Equal(album2CoverArt100, testAlbum);
        }

        [Fact]
        public void AlbumCoverArt350GetTest()
        {
            // Arrange
            string albumCoverArt350 = "cover:350";
            Track track = new Track()
            {
                Album_coverart_350x350 = albumCoverArt350
            };

            // Act
            // (get)
            string testAlbum = track.Album_coverart_350x350;

            // Assert
            Assert.Equal(albumCoverArt350, testAlbum);
        }        
        [Fact]
        public void AlbumCoverArt350SetTest()
        {
            // Arrange
            string albumCoverArt350 = "cover:350";
            string album2CoverArt350 = "cover2:350";
            Track track = new Track()
            {
                Album_coverart_350x350 = albumCoverArt350
            };

            // Act
            // (set)
            track.Album_coverart_350x350 = album2CoverArt350;
            // (get)
            string testAlbum = track.Album_coverart_350x350;

            // Assert
            Assert.Equal(album2CoverArt350, testAlbum);
        }

        [Fact]
        public void AlbumCoverArt500GetTest()
        {
            // Arrange
            string albumCoverArt500 = "cover:500";
            Track track = new Track()
            {
                Album_coverart_500x500 = albumCoverArt500
            };

            // Act
            // (get)
            string testAlbum = track.Album_coverart_500x500;

            // Assert
            Assert.Equal(albumCoverArt500, testAlbum);
        }        
        [Fact]
        public void AlbumCoverArt500SetTest()
        {
            // Arrange
            string albumCoverArt500 = "cover:500";
            string album2CoverArt500 = "cover2:500";
            Track track = new Track()
            {
                Album_coverart_500x500 = albumCoverArt500
            };

            // Act
            // (set)
            track.Album_coverart_500x500 = album2CoverArt500;
            // (get)
            string testAlbum = track.Album_coverart_500x500;

            // Assert
            Assert.Equal(album2CoverArt500, testAlbum);
        }

        [Fact]
        public void AlbumCoverArt800GetTest()
        {
            // Arrange
            string albumCoverArt800 = "cover:800";
            Track track = new Track()
            {
                Album_coverart_800x800 = albumCoverArt800
            };

            // Act
            // (get)
            string testAlbum = track.Album_coverart_800x800;

            // Assert
            Assert.Equal(albumCoverArt800, testAlbum);
        }        
        [Fact]
        public void AlbumCoverArt800SetTest()
        {
            // Arrange
            string albumCoverArt800 = "cover:800";
            string album2CoverArt800 = "cover2:800";
            Track track = new Track()
            {
                Album_coverart_800x800 = albumCoverArt800
            };

            // Act
            // (set)
            track.Album_coverart_800x800 = album2CoverArt800;
            // (get)
            string testAlbum = track.Album_coverart_800x800;

            // Assert
            Assert.Equal(album2CoverArt800, testAlbum);
        }

        [Fact]
        public void ArtistNameGetTest()
        {
            // Arrange
            string artistName = "Taylor Swift";
            Track track = new Track()
            {
                Artist_name = artistName
            };

            // Act
            // (get)
            string testName = track.Artist_name;

            // Assert
            Assert.Equal(artistName, testName);
        }
        [Fact]
        public void ArtistNameSetTest()
        {
            // Arrange
            string artistName = "Taylor Swift";
            string artistName2 = "Taylor Swifty";
            Track track = new Track()
            {
                Artist_name = artistName
            };

            // Act
            // (set)
            track.Artist_name = artistName2;
            // (get)
            string testName = track.Artist_name;

            // Assert
            Assert.Equal(artistName2, testName);
        }

        [Fact]
        public void ArtistmbidGetTest()
        {
            // Arrange
            string mbid = "1fign2edl204";
            Track track = new Track()
            {
                Artist_mbid = mbid
            };

            // Act
            // (get)
            string testmbid = track.Artist_mbid;

            // Assert
            Assert.Equal(mbid, testmbid);
        }
        [Fact]
        public void ArtistmbidSetTest()
        {
            // Arrange
            string mbid = "1fign2edl204";
            string mbid2 = "1firhbreh9jown3598t4oiegn2edl204";
            Track track = new Track()
            {
                Artist_mbid = mbid
            };

            // Act
            // (set)
            track.Artist_mbid = mbid2;
            // (get)
            string testmbid = track.Artist_mbid;

            // Assert
            Assert.Equal(mbid2, testmbid);
        }

        [Fact]
        public void ArtistIDGetTest()
        {
            // Arrange
            long artistID = 1095103;
            Track track = new Track()
            {
                Artist_id = artistID
            };

            // Act
            // (get)
            long testArtistID = track.Artist_id;

            // Assert
            Assert.Equal(artistID, testArtistID);
        }
        [Fact]
        public void ArtistIDSetTest()
        {
            // Arrange
            long artistID = 1095103;
            long artistID2 = 105103;
            Track track = new Track()
            {
                Artist_id = artistID
            };

            // Act
            // (set)
            track.Artist_id = artistID2;
            // (get)
            long testArtistID = track.Artist_id;

            // Assert
            Assert.Equal(artistID2, testArtistID);
        }

        [Fact]
        public void AlbumNameGetTest()
        {
            // Arrange
            string albumName = "1989";
            Track track = new Track()
            {
                Album_name = albumName
            };

            // Act
            // (get)
            string testAlbumName = track.Album_name;

            // Assert
            Assert.Equal(albumName, testAlbumName);
        }
        [Fact]
        public void AlbumNameSetTest()
        {
            // Arrange
            string albumName = "1989";
            string artistName2 = "1991";
            Track track = new Track()
            {
                Album_name = albumName
            };

            // Act
            // (set)
            track.Album_name = artistName2;
            // (get)
            string testAlbumName = track.Album_name;

            // Assert
            Assert.Equal(artistName2, testAlbumName);
        }

        [Fact]
        public void AlbumIDGetTest()
        {
            // Arrange
            long albumID = 95653184;
            Track track = new Track()
            {
                Album_id = albumID
            };

            // Act
            // (get)
            long testArtistID = track.Album_id;

            // Assert
            Assert.Equal(albumID, testArtistID);
        }
        [Fact]
        public void AlbumIDSetTest()
        {
            // Arrange
            long albumID = 95653184;
            long albumID2 = 95653184551;
            Track track = new Track()
            {
                Album_id = albumID
            };

            // Act
            // (set)
            track.Album_id = albumID2;
            // (get)
            long testArtistID = track.Album_id;

            // Assert
            Assert.Equal(albumID2, testArtistID);
        }

        [Fact]
        public void SubtitleIDGetTest()
        {
            // Arrange
            int subtitleID = 0;
            Track track = new Track()
            {
                Subtitle_id = subtitleID
            };

            // Act
            // (get)
            int testSubtitleID = track.Subtitle_id;

            // Assert
            Assert.Equal(subtitleID, testSubtitleID);
        }
        [Fact]
        public void SubtitleIDSetTest()
        {
            // Arrange
            int subtitleID = 0;
            int subtitleID2 = 1;
            Track track = new Track()
            {
                Subtitle_id = subtitleID
            };

            // Act
            // (set)
            track.Subtitle_id = subtitleID2;
            // (get)
            int testSubtitleID = track.Subtitle_id;

            // Assert
            Assert.Equal(subtitleID2, testSubtitleID);
        }

        [Fact]
        public void LyricsIDGetTest()
        {
            // Arrange
            long lyricsID = 0;
            Track track = new Track()
            {
                Lyrics_id = lyricsID
            };

            // Act
            // (get)
            long testLyricsID = track.Lyrics_id;

            // Assert
            Assert.Equal(lyricsID, testLyricsID);
        }
        [Fact]
        public void LyricsIDSetTest()
        {
            // Arrange
            long lyricsID = 0;
            long lyricsID2 = 1;
            Track track = new Track()
            {
                Lyrics_id = lyricsID
            };

            // Act
            // (set)
            track.Lyrics_id = lyricsID2;
            // (get)
            long testLyricsID = track.Lyrics_id;

            // Assert
            Assert.Equal(lyricsID2, testLyricsID);
        }

        [Fact]
        public void NumFavouriteGetTest()
        {
            // Arrange
            int numFavourite = 0;
            Track track = new Track()
            {
                Num_favourite = numFavourite
            };

            // Act
            // (get)
            int testNumFavorite = track.Num_favourite;

            // Assert
            Assert.Equal(numFavourite, testNumFavorite);
        }
        [Fact]
        public void NumFavouriteDSetTest()
        {
            // Arrange
            int NumFavorite = 0;
            int NumFavorite2 = 1;
            Track track = new Track()
            {
                Num_favourite = NumFavorite
            };

            // Act
            // (set)
            track.Num_favourite = NumFavorite2;
            // (get)
            int testNumFavorite = track.Num_favourite;

            // Assert
            Assert.Equal(NumFavorite2, testNumFavorite);
        }

        [Fact]
        public void HasRichSyncGetTest()
        {
            // Arrange
            int richSync = 0;
            Track track = new Track()
            {
                Has_richsync = richSync
            };

            // Act
            // (get)
            int testRichSync = track.Has_richsync;

            // Assert
            Assert.Equal(richSync, testRichSync);
        }
        [Fact]
        public void HasRichSyncSetTest()
        {
            // Arrange
            int richSync = 0;
            int richSync2 = 1;
            Track track = new Track()
            {
                Has_richsync = richSync
            };

            // Act
            // (set)
            track.Has_richsync = richSync2;
            // (get)
            int test = track.Has_richsync;

            // Assert
            Assert.Equal(richSync2, test);
        }

        [Fact]
        public void HasSubtitlesGetTest()
        {
            // Arrange
            int hasSubtitles = 0;
            Track track = new Track()
            {
                Has_subtitles = hasSubtitles
            };

            // Act
            // (get)
            int test = track.Has_subtitles;

            // Assert
            Assert.Equal(hasSubtitles, test);
        }
        [Fact]
        public void HasSubtitlesSetTest()
        {
            // Arrange
            int hasSubtitles = 0;
            int hasSubtitles2 = 1;
            Track track = new Track()
            {
                Has_subtitles = hasSubtitles
            };

            // Act
            // (set)
            track.Has_subtitles = hasSubtitles2;
            // (get)
            int test = track.Has_subtitles;

            // Assert
            Assert.Equal(hasSubtitles2, test);
        }

        [Fact]
        public void HasLyricsCrowdGetTest()
        {
            // Arrange
            int hasLyricsCrowd = 0;
            Track track = new Track()
            {
                Has_lyrics_crowd = hasLyricsCrowd
            };

            // Act
            // (get)
            int test = track.Has_lyrics_crowd;

            // Assert
            Assert.Equal(hasLyricsCrowd, test);
        }
        [Fact]
        public void HasLyricsCrowdSetTest()
        {
            // Arrange
            int hasLyricsCrowd = 0;
            int hasLyricsCrowd2 = 1;
            Track track = new Track()
            {
                Has_lyrics_crowd = hasLyricsCrowd
            };

            // Act
            // (set)
            track.Has_lyrics_crowd = hasLyricsCrowd2;
            // (get)
            int test = track.Has_lyrics_crowd;

            // Assert
            Assert.Equal(hasLyricsCrowd2, test);
        }

        [Fact]
        public void HasLyricsGetTest()
        {
            // Arrange
            int hasLyrics = 0;
            Track track = new Track()
            {
                Has_lyrics = hasLyrics
            };

            // Act
            // (get)
            int test = track.Has_lyrics;

            // Assert
            Assert.Equal(hasLyrics, test);
        }
        [Fact]
        public void HasLyricsSetTest()
        {
            // Arrange
            int hasLyrics = 0;
            int hasLyrics2 = 1;
            Track track = new Track()
            {
                Has_lyrics = hasLyrics
            };

            // Act
            // (set)
            track.Has_lyrics = hasLyrics2;
            // (get)
            int test = track.Has_lyrics;

            // Assert
            Assert.Equal(hasLyrics2, test);
        }

        [Fact]
        public void ExplicitGetTest()
        {
            // Arrange
            int explic = 0;
            Track track = new Track()
            {
                Explicit = explic
            };

            // Act
            // (get)
            int test = track.Explicit;

            // Assert
            Assert.Equal(explic, test);
        }
        [Fact]
        public void ExplicitSetTest()
        {
            // Arrange
            int explic = 0;
            int explic2 = 1;
            Track track = new Track()
            {
                Explicit = explic
            };

            // Act
            // (set)
            track.Explicit = explic2;
            // (get)
            int test = track.Explicit;

            // Assert
            Assert.Equal(explic2, test);
        }

        [Fact]
        public void InstrumentalGetTest()
        {
            // Arrange
            int instrumental = 0;
            Track track = new Track()
            {
                Instrumental = instrumental
            };

            // Act
            // (get)
            int test = track.Instrumental;

            // Assert
            Assert.Equal(instrumental, test);
        }
        [Fact]
        public void InstrumentalSetTest()
        {
            // Arrange
            int instrumental = 0;
            int instrumental2 = 1;
            Track track = new Track()
            {
                Instrumental = instrumental
            };

            // Act
            // (set)
            track.Instrumental = instrumental2;
            // (get)
            int test = track.Instrumental;

            // Assert
            Assert.Equal(instrumental2, test);
        }

        [Fact]
        public void CommontrackIDGetTest()
        {
            // Arrange
            long commontrackID = 895623;
            Track track = new Track()
            {
                Commontrack_id = commontrackID
            };

            // Act
            // (get)
            long test = track.Commontrack_id;

            // Assert
            Assert.Equal(commontrackID, test);
        }
        [Fact]
        public void CommontrackIDSetTest()
        {
            // Arrange
            long commontrackID = 895623;
            long commontrackID2 = 89562;
            Track track = new Track()
            {
                Commontrack_id = commontrackID
            };

            // Act
            // (set)
            track.Commontrack_id = commontrackID2;
            // (get)
            long test = track.Commontrack_id;

            // Assert
            Assert.Equal(commontrackID2, test);
        }

        [Fact]
        public void TrackLengthGetTest()
        {
            // Arrange
            int trackLength = 200;
            Track track = new Track()
            {
                Track_length = trackLength
            };

            // Act
            // (get)
            int test = track.Track_length;

            // Assert
            Assert.Equal(trackLength, test);
        }
        [Fact]
        public void TrackLengthSetTest()
        {
            // Arrange
            int trackLength = 200;
            int trackLength2 = 190;
            Track track = new Track()
            {
                Track_length = trackLength
            };

            // Act
            // (set)
            track.Track_length = trackLength2;
            // (get)
            int test = track.Track_length;

            // Assert
            Assert.Equal(trackLength2, test);
        }

        [Fact]
        public void TrackRatingGetTest()
        {
            // Arrange
            int trackRating = 1;
            Track track = new Track()
            {
                Track_rating = trackRating
            };

            // Act
            // (get)
            int test = track.Track_rating;

            // Assert
            Assert.Equal(trackRating, test);
        }
        [Fact]
        public void TrackRatingSetTest()
        {
            // Arrange
            int trackRating = 1;
            int trackRating2 = 2;
            Track track = new Track()
            {
                Track_rating = trackRating
            };

            // Act
            // (set)
            track.Track_rating = trackRating2;
            // (get)
            int test = track.Track_rating;

            // Assert
            Assert.Equal(trackRating2, test);
        }

        [Fact]
        public void TrackNameTranslationListGetTest()
        {
            // Arrange
            string[] translationList = new string[] { "a", "b", "c" };
            Track track = new Track()
            {
                Track_name_translation_list = translationList
            };

            // Act
            // (get)
            string[] testTranslationList = track.Track_name_translation_list;

            // Assert
            Assert.Equal(translationList, testTranslationList);
        }
        [Fact]
        public void TrackNameTranslationListSetTest()
        {
            // Arrange
            string[] translationList = new string[] { "a", "b", "c" };
            string[] translationList2 = new string[] { "d", "e", "f" };
            Track track = new Track()
            {
                Track_name_translation_list = translationList
            };

            // Act
            // (set)
            track.Track_name_translation_list = translationList2;
            // (get)
            string[] testTranslationList = track.Track_name_translation_list;

            // Assert
            Assert.Equal(translationList2, testTranslationList);
        }

        [Fact]
        public void TrackNameGetTest()
        {
            // Arrange
            string trackName = "Shake It Off";
            Track track = new Track()
            {
                Track_name = trackName
            };

            // Act
            // (get)
            string test = track.Track_name;

            // Assert
            Assert.Equal(trackName, test);
        }
        [Fact]
        public void TrackNameSetTest()
        {
            // Arrange
            string trackName = "Shake It Off";
            string trackName2 = "Shake It OFF!!!";
            Track track = new Track()
            {
                Track_name = trackName
            };

            // Act
            // (set)
            track.Track_name = trackName2;
            // (get)
            string test = track.Track_name;

            // Assert
            Assert.Equal(trackName2, test);
        }

        [Fact]
        public void TrackXboxMusicIDGetTest()
        {
            // Arrange
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            Track track = new Track()
            {
                Track_xboxmusic_id = xboxID
            };

            // Act
            // (get)
            string test = track.Track_xboxmusic_id;

            // Assert
            Assert.Equal(xboxID, test);
        }
        [Fact]
        public void TrackXboxMusicIDSetTest()
        {
            // Arrange
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string xboxID2 = "a490sle658213fi23v0e99gls";
            Track track = new Track()
            {
                Track_xboxmusic_id = xboxID
            };

            // Act
            // (set)
            track.Track_xboxmusic_id = xboxID2;
            // (get)
            string test = track.Track_xboxmusic_id;

            // Assert
            Assert.Equal(xboxID2, test);
        }

        [Fact]
        public void TrackSoundCloudIDGetTest()
        {
            // Arrange
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            Track track = new Track()
            {
                Track_soundcloud_id = soundcloudID
            };

            // Act
            // (get)
            string test = track.Track_soundcloud_id;

            // Assert
            Assert.Equal(soundcloudID, test);
        }
        [Fact]
        public void TrackSoundCloudSetTest()
        {
            // Arrange
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string soundcloudID2 = "a490sle658213fi49fkgne9623v0e99g30";
            Track track = new Track()
            {
                Track_soundcloud_id = soundcloudID
            };

            // Act
            // (set)
            track.Track_soundcloud_id = soundcloudID2;
            // (get)
            string test = track.Track_soundcloud_id;

            // Assert
            Assert.Equal(soundcloudID2, test);
        }

        [Fact]
        public void TrackSpotifyIDGetTest()
        {
            // Arrange
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            Track track = new Track()
            {
                Track_spotify_id = spotifyID
            };

            // Act
            // (get)
            string test = track.Track_spotify_id;

            // Assert
            Assert.Equal(spotifyID, test);
        }
        [Fact]
        public void TrackSpotifyIDSetTest()
        {
            // Arrange
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string spotifyID2 = "984hunjfdz78w5yurhgjf9y8thgaj";
            Track track = new Track()
            {
                Track_spotify_id = spotifyID
            };

            // Act
            // (set)
            track.Track_spotify_id = spotifyID2;
            // (get)
            string test = track.Track_spotify_id;

            // Assert
            Assert.Equal(spotifyID2, test);
        }

        [Fact]
        public void TrackisrcGetTest()
        {
            // Arrange
            string isrc = "4309wghavsiny98rhoil";
            Track track = new Track()
            {
                Track_isrc = isrc
            };

            // Act
            // (get)
            string test = track.Track_isrc;

            // Assert
            Assert.Equal(isrc, test);
        }
        [Fact]
        public void TrackisrcSetTest()
        {
            // Arrange
            string isrc = "4309wghavsiny98rhoil";
            string isrc2 = "4309wghavsiny98rhoilww9eig";
            Track track = new Track()
            {
                Track_isrc = isrc
            };

            // Act
            // (set)
            track.Track_isrc = isrc2;
            // (get)
            string test = track.Track_isrc;

            // Assert
            Assert.Equal(isrc2, test);
        }

        [Fact]
        public void TrackmbidGetTest()
        {
            // Arrange
            string mbid = "4fi3-58fkg-8fkrk-49r";
            Track track = new Track()
            {
                Track_mbid = mbid
            };

            // Act
            // (get)
            string test = track.Track_mbid;

            // Assert
            Assert.Equal(mbid, test);
        }
        [Fact]
        public void TrackmbidSetTest()
        {
            // Arrange
            string mbid = "4fi3-58fkg-8fkrk-49r";
            string mbid2 = "4fi3-58fkg-8fkrk-49rb";
            Track track = new Track()
            {
                Track_mbid = mbid
            };

            // Act
            // (set)
            track.Track_mbid = mbid2;
            // (get)
            string test = track.Track_mbid;

            // Assert
            Assert.Equal(mbid2, test);
        }

        [Fact]
        public void TrackIDGetTest()
        {
            // Arrange
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID
            };

            // Act
            // (get)
            long test = track.Track_id;

            // Assert
            Assert.Equal(trackID, test);
        }
        [Fact]
        public void TrackIDSetTest()
        {
            // Arrange
            long trackID = 896589461532;
            long trackID2 = 8965891532;
            Track track = new Track()
            {
                Track_id = trackID
            };

            // Act
            // (set)
            track.Track_id = trackID2;
            // (get)
            long test = track.Track_id;

            // Assert
            Assert.Equal(trackID2, test);
        }

        [Fact]
        public void TrackGetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };

            // Act 
            // (get)
            Track testTrack = trackList.Track;

            // Assert
            Assert.Equal(track, testTrack);
        }
        [Fact]
        public void TrackSetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            Track track2 = new Track();
            TrackList trackList = new TrackList()
            {
                Track = track
            };

            // Act 
            // (set)
            trackList.Track = track2;
            // (get)
            Track testTrack = trackList.Track;

            // Assert
            Assert.Equal(track2, testTrack);
        }

        [Fact]
        public void TrackListGetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };
            Body body = new Body()
            {
                Track_list = trackLists
            };

            // Act
            // (get)
            List<TrackList> testTrackLists = body.Track_list;

            // Assert
            Assert.Equal(trackLists, testTrackLists);
        }
        [Fact]
        public void TrackListSetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            TrackList trackList2 = new TrackList();
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };
            List<TrackList> trackLists2 = new List<TrackList>
            {
                trackList2
            };
            Body body = new Body()
            {
                Track_list = trackLists
            };

            // Act
            // (set)
            body.Track_list = trackLists2;
            // (get)
            List<TrackList> testTrackLists = body.Track_list;

            // Assert
            Assert.Equal(trackLists2, testTrackLists);
        }

        [Fact]
        public void BodyGetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };

            Body body = new Body()
            {
                Track_list = trackLists
            };
            Message message = new Message()
            {
                Body = body
            };

            // Act
            // (get)
            Body testBody = message.Body;

            // Assert
            Assert.Equal(body, testBody);
        }
        [Fact]
        public void BodySetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };

            Body body = new Body()
            {
                Track_list = trackLists
            };
            Body body2 = new Body();
            Message message = new Message()
            {
                Body = body
            };

            // Act
            // (set)
            message.Body = body2;

            // (get)
            Body testBody = message.Body;

            // Assert
            Assert.Equal(body2, testBody);
        }

        [Fact]
        public void StatusCodeGetTest()
        {
            // Arrange
            int statusCode = 404;
            Header header = new Header()
            {
                Status_code = statusCode
            };

            // Act
            // (get)
            int testStatusCode = header.Status_code;

            // Assert
            Assert.Equal(statusCode, testStatusCode);
        }
        [Fact]
        public void StatusCodeSetTest()
        {
            // Arrange
            int statusCode = 404;
            int statusCode2 = 200;
            Header header = new Header()
            {
                Status_code = statusCode
            };

            // Act
            // (set)
            header.Status_code = statusCode2;
            // (get)
            int testStatusCode = header.Status_code;

            // Assert
            Assert.Equal(statusCode2, testStatusCode);
        }

        [Fact]
        public void ExecuteTimeGetTest()
        {
            // Arrange
            double executeTime = 0.1111;
            Header header = new Header()
            {
                Execute_time = executeTime
            };

            // Act
            // (get)
            double testExecuteTime = header.Execute_time;

            // Assert
            Assert.Equal(executeTime, testExecuteTime);
        }
        [Fact]
        public void ExecuteTimeSetTest()
        {
            // Arrange
            double executeTime = 0.1111;
            double executeTime2 = 0.2222;
            Header header = new Header()
            {
                Execute_time = executeTime
            };

            // Act
            // (set)
            header.Execute_time = executeTime2;
            // (get)
            double testExecuteTime = header.Execute_time;

            // Assert
            Assert.Equal(executeTime2, testExecuteTime);
        }

        [Fact]
        public void AvailableGetTest()
        {
            // Arrange
            int available = 1000;
            Header header = new Header()
            {
                Available = available
            };

            // Act
            // (get)
            int testAvailable = header.Available;

            // Assert
            Assert.Equal(available, testAvailable);
        }
        [Fact]
        public void AvailableSetTest()
        {
            // Arrange
            int available = 1000;
            int available2 = 2000;
            Header header = new Header()
            {
                Available = available
            };

            // Act
            // (set)
            header.Available = available2;
            // (get)
            int testAvailable = header.Available;

            // Assert
            Assert.Equal(available2, testAvailable);
        }

        [Fact]
        public void HeaderGetTest()
        {
            // Arrange
            int statusCode = 404;
            double executeTime = 0.1111;
            int available = 1000;

            Header header = new Header()
            {
                Status_code = statusCode,
                Execute_time = executeTime,
                Available = available
            };

            Message message = new Message()
            {
                Header = header
            };

            // Act
            // (get)
            Header testHeader = message.Header;

            // Assert
            Assert.Equal(header, testHeader);
        }
        [Fact]
        public void HeaderSetTest()
        {
            // Arrange
            int statusCode = 404;
            double executeTime = 0.1111;
            int available = 1000;

            Header header = new Header()
            {
                Status_code = statusCode,
                Execute_time = executeTime,
                Available = available
            };
            Header header2 = new Header();

            Message message = new Message()
            {
                Header = header
            };

            // Act
            // (set)
            message.Header = header2;
            // (get)
            Header testHeader = message.Header;

            // Assert
            Assert.Equal(header2, testHeader);
        }

        [Fact]
        public void MessageGetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };

            Body body = new Body()
            {
                Track_list = trackLists
            };

            int statusCode = 404;
            double executeTime = 0.1111;
            int available = 1000;

            Header header = new Header()
            {
                Status_code = statusCode,
                Execute_time = executeTime,
                Available = available
            };

            Message message = new Message()
            {
                Header = header,
                Body = body
            };

            Music music = new Music()
            {
                Message = message
            };

            // Act
            // (get)
            Message testMessage = music.Message;

            // Assert
            Assert.Equal(message, testMessage);
        }
        [Fact]
        public void MessageSetTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Pop Music",
                Music_genre_vanity = "vanity"
            };
            Genre secondGenre = new Genre()
            {
                Music_genre_id = 14,
                Music_genre_parent_id = 14,
                Music_genre_name = "Rock",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity2"
            };
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            List<MusicGenreList> musicGenreLists = new List<MusicGenreList>
            {
                musicGenreList
            };
            MusicGenreList musicGenreList2 = new MusicGenreList()
            {
                Music_genre = secondGenre
            };
            List<MusicGenreList> musicGenreLists2 = new List<MusicGenreList>
            {
                musicGenreList2
            };
            PrimaryGenres primaryGenres = new PrimaryGenres();
            PrimaryGenres secondaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists2
            };
            DateTime FirstReleaseDate = new DateTime(2001, 12, 23);
            DateTime UpdatedTime = new DateTime(2002, 2, 22);
            int restricted = 0;
            string vanityID = "a490sle09930kdls";
            string TrackShareUrl = "trackshareurl.com";
            string TrackEditUrl = "trackediturl.com";
            string albumCoverArt100 = "cover100";
            string albumCoverArt350 = "cover350";
            string albumCoverArt500 = "cover500";
            string albumCoverArt800 = "cover800";
            string artistName = "Taylor Swift";
            string artistmbid = "1fign2edl204";
            long artistID = 1095103;
            string albumName = "1989";
            long albumID = 95653184;
            int subtitleID = 0;
            long lyricsID = 0;
            int numFavourite = 0;
            int hasRichSync = 0;
            int hasSubtitles = 0;
            int hasLyricsCrowd = 0;
            int hasLyrics = 0;
            int explic = 0;
            int instrumental = 0;
            long commontrackID = 895623;
            int trackLength = 200;
            int trackRating = 1;
            string[] translationList = new string[] { "a", "b", "c" };
            string trackName = "Shake It Off";
            string xboxID = "a490sle658213fi23v0e99g30kdls";
            string soundcloudID = "a490sle658213fi49fkgne9623v0e99g30kdls";
            string spotifyID = "984hunjfdz78w5yurhgjf9y8thgaj";
            string isrc = "4309wghavsiny98rhoil";
            string Trackmbid = "4fi3-58fkg-8fkrk-49r";
            long trackID = 896589461532;
            Track track = new Track()
            {
                Track_id = trackID,
                Track_mbid = Trackmbid,
                Track_isrc = isrc,
                Track_spotify_id = spotifyID,
                Track_soundcloud_id = soundcloudID,
                Track_xboxmusic_id = xboxID,
                Track_name = trackName,
                Track_name_translation_list = translationList,
                Track_rating = trackRating,
                Track_length = trackLength,
                Commontrack_id = commontrackID,
                Instrumental = instrumental,
                Explicit = explic,
                Has_lyrics = hasLyrics,
                Has_lyrics_crowd = hasLyricsCrowd,
                Has_subtitles = hasSubtitles,
                Has_richsync = hasRichSync,
                Num_favourite = numFavourite,
                Lyrics_id = lyricsID,
                Subtitle_id = subtitleID,
                Album_id = albumID,
                Album_name = albumName,
                Artist_id = artistID,
                Artist_mbid = artistmbid,
                Artist_name = artistName,
                Album_coverart_100x100 = albumCoverArt100,
                Album_coverart_350x350 = albumCoverArt350,
                Album_coverart_500x500 = albumCoverArt500,
                Album_coverart_800x800 = albumCoverArt800,
                Track_share_url = TrackShareUrl,
                Track_edit_url = TrackEditUrl,
                Commontrack_vanity_id = vanityID,
                Restricted = restricted,
                First_release_date = FirstReleaseDate,
                Updated_time = UpdatedTime,
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            TrackList trackList = new TrackList()
            {
                Track = track
            };
            List<TrackList> trackLists = new List<TrackList>
            {
                trackList
            };

            Body body = new Body()
            {
                Track_list = trackLists
            };

            int statusCode = 404;
            double executeTime = 0.1111;
            int available = 1000;

            Header header = new Header()
            {
                Status_code = statusCode,
                Execute_time = executeTime,
                Available = available
            };

            Message message = new Message()
            {
                Header = header,
                Body = body
            };
            Message message2 = new Message();

            Music music = new Music()
            {
                Message = message
            };

            // Act
            // (set)
            music.Message = message2;
            // (get)
            Message testMessage = music.Message;

            // Assert
            Assert.Equal(message2, testMessage);
        }
    }
}