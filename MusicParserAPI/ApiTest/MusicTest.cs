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
            Assert.Equal(12, musicGenreParentID);
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
            Assert.Equal("Rock", MusicGenre);
        }

        [Fact]
        public void GenreMusicNameExtendedTest()
        {
            // Arrange
            Genre genre = new Genre();

            // Act 
            // (set)
            genre.Music_genre_name_extended = "Rock and Roll";
            // (get)
            string MusicGenreExtended = genre.Music_genre_name_extended;

            // Assert
            Assert.Equal("Rock and Roll", MusicGenreExtended);
        }

        [Fact]
        public void GenreMusicVanityTest()
        {
            // Arrange
            Genre genre = new Genre();

            // Act 
            // (set)
            genre.Music_genre_vanity = "vanity";
            // (get)
            string MusicVanity = genre.Music_genre_vanity;

            // Assert
            Assert.Equal("vanity", MusicVanity);
        }

        [Fact]
        public void MusicGenreListTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
                Music_genre_name_extended = "Rock and Roll",
                Music_genre_vanity = "vanity"
            };

            // Act 
            // (set)
            MusicGenreList musicGenreList = new MusicGenreList()
            {
                Music_genre = genre
            };
            // (get)
            Genre testGenre = musicGenreList.Music_genre;

            // Assert
            Assert.Equal(genre, testGenre);
        }

        [Fact]
        public void PrimaryGenresTest()
        {
            // Arrange
            Genre genre = new Genre
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
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

            // Act 
            // (set)
            PrimaryGenres primaryGenres = new PrimaryGenres()
            {
                Music_genre_list = musicGenreLists
            };

            // (get)
            List<MusicGenreList> testMusicGenreList = primaryGenres.Music_genre_list;

            // Assert
            Assert.Equal(musicGenreLists, testMusicGenreList);
        }

        [Fact]
        public void TrackPrimaryGenresTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
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
            // (set)
            Track track = new Track()
            {
                Primary_genres = primaryGenres
            };

            // (get)
            PrimaryGenres testPrimaryGenres = track.Primary_genres;

            // Assert
            Assert.Equal(primaryGenres, testPrimaryGenres);
        }

        [Fact]
        public void TrackSecondaryGenresTest()
        {
            // Arrange
            Genre genre = new Genre()
            {
                Music_genre_id = 12,
                Music_genre_parent_id = 12,
                Music_genre_name = "Pop",
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

            // Act 
            // (set)
            Track track = new Track()
            {
                Secondary_genres = secondaryGenres
            };

            // (get)
            PrimaryGenres testSecondaryGenres = track.Secondary_genres;

            // Assert
            Assert.Equal(secondaryGenres, testSecondaryGenres);
        }

        [Fact]
        public void FirstReleaseDateTest()
        {
            // Arrange
            DateTime dateTime = DateTime.Today;

            // Act
            // (set)
            Track track = new Track()
            {
                First_release_date = dateTime
            };

            // (get)

        }

        [Fact]
        public void TrackTest()
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
            Track track = new Track()
            {
                Primary_genres = primaryGenres,
                Secondary_genres = secondaryGenres
            };
            
            // Act 
            // (set)

            // (get)

            // Assert
        }

    }
}
