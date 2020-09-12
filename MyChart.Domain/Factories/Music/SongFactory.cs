using MyChart.Domain.Models.Music;
using System;

namespace MyChart.Domain.Factories.Music
{
    internal class SongFactory : ISongFactory
    {
        private string name = default!;
        private Artist artist = default!;
        private SongOptions? options = default;
        private DateTime? releaseDate = default;
        private string? youTubeURL = default;

        public ISongFactory WithArtist(Artist artist)
        {
            this.artist = artist;
            return this;
        }

        public ISongFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ISongFactory WithOptions(SongOptions options)
        {
            this.options = options;
            return this;
        }

        public ISongFactory WithReleaseDate(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
            return this;
        }

        public ISongFactory WithYouTubeURL(string url)
        {
            this.youTubeURL = url;
            return this;
        }
        public Song Build() => new Song(name, artist);
        public Song Build(string name, Artist artist)
           => this
               .WithName(name)
               .WithArtist(artist)
               .Build();
    }
}
