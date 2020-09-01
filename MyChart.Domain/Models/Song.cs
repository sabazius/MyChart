using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using System;
using static MyChart.Domain.Models.ModelConstants.Song;

namespace MyChart.Domain.Models
{
    public class Song : Entity<int>
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
        public DateTime? ReleaseDate { get; set; }

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
