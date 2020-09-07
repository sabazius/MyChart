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
            Validate(name);
            Name = name;
            Artist = artist;
        }
        public string Name { get; }
        public Artist Artist { get; }
        public int? BPM { get; }
        public DateTime? ReleaseDate { get; }
        public string? YouTubeURL { get; }

        private void Validate(string name)
        {
            Guard.ForStringLength<InvalidSongException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }

    }
}
