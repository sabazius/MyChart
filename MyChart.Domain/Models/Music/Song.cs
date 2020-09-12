using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using System;
using static MyChart.Domain.Models.ModelConstants.Song;

namespace MyChart.Domain.Models.Music
{
    public class Song : Entity<int>, IAggregateRoot
    {

        internal Song(string name, Artist artist)
        {
            ValidateName(name);
            ValidateArtist(artist);
            Name = name;
            Artist = artist;
        }
        public string Name { get; private set; }
        public Artist Artist { get; private set; }
        public SongOptions? Options { get; private set; }
        public DateTime? ReleaseDate { get; private set; }
        public string? YouTubeURL { get; private set; }

    #region Setters
        /// <summary>
        /// Update name of the <see cref="Song"/>
        /// </summary>
        /// <param name="songName">name of the song</param>
        /// <returns>current song object</returns>
        public Song UpdateName(string songName)
        {
            this.ValidateName(songName);
            Name = songName;
            return this;
        }
        /// <summary>
        /// Update <see cref="Artist"/> of the Song
        /// </summary>
        /// <param name="artistName">Artist name</param>
        /// <returns>current Song object</returns>
        public Song UpdateArtist(string artistName)
        {
            if (this.Artist.Name != artistName)
            {
                this.Artist = new Artist(artistName);
            }

            return this;
        }
        /// <summary>
        /// Update <see cref="Artist"/> of the Song
        /// </summary>
        /// <param name="artistName">Artist name</param>
        /// <returns>current Song object</returns>
        public Song UpdateArtist(Artist artist)
        {
            ValidateArtist(artist);
            this.Artist = artist;

            return this;
        }
        
        /// <summary>
        /// Update <see cref="Song.ReleaseDate"/>
        /// </summary>
        /// <param name="releaseDate">new release date</param>
        /// <returns>current song object</returns>
        public Song UpdateReleaseDate(DateTime releaseDate)
        {
            ValidateReleaseDate(releaseDate);
            this.ReleaseDate = releaseDate;
            return this;
        }
        /// <summary>
        /// Update <see cref="Song.YouTubeURL"/>
        /// </summary>
        /// <param name="url">URL to validate</param>
        /// <returns>current <see cref="Song"/> object</returns>
        public Song UpdateURL(string url)
        {
            ValidateYoutubeUrl(url);
            this.YouTubeURL = url;

            return this;
        }
        /// <summary>
        /// Update BPM of the <see cref="Song"/>
        /// </summary>
        /// <param name="bpm">beats per minute</param>
        /// <returns>current song object</returns>
        public Song UpdateOptions(int bpm, string key)
        {
            this.Options = new SongOptions(bpm, key);

            return this;
        }
        #endregion
        #region Validators

        /// <summary>
        /// Validate <see cref="Song"/> name
        /// </summary>
        /// <param name="name"></param>
        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidSongException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
        /// <summary>
        /// Validate <see cref="Artist"/>
        /// </summary>
        /// <param name="artist">New song <see cref="Artist"/></param>
        private void ValidateArtist(Artist artist)
        {
            Guard.ForNotNull<InvalidSongException>(
                artist,
                nameof(this.Artist));
        }
        
        /// <summary>
        /// Validate <see cref="Song.ReleaseDate"/>
        /// </summary>
        /// <param name="releaseDate">Release Date to validate</param>
        private void ValidateReleaseDate(DateTime releaseDate)
        {
            Guard.AgainstOutOfRange<InvalidSongException>(
                releaseDate,
                new DateTime(MinReleaseYear, 1, 1),
                DateTime.Now,
                nameof(this.ReleaseDate)
            );
        }
        /// <summary>
        /// Validate <see cref="Song.YouTubeURL"/>
        /// </summary>
        /// <param name="youtubeUrl">URL to validate</param>
        private void ValidateYoutubeUrl(string youtubeUrl)
            => Guard.ForValidUrl<InvalidSongException>(
                youtubeUrl,
                nameof(this.YouTubeURL));
        #endregion
    }
}
