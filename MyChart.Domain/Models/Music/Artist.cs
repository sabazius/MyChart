using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using System;
using static MyChart.Domain.Models.ModelConstants.Artist;

namespace MyChart.Domain.Models.Music
{
    public class Artist
    {

        internal Artist(string name)
        {
            Validate(name);
            Name = name;
        }

        public string Name { get; }
        public string? Country { get; }
        public DateTime? BirthDay { get; }

        private void Validate(string name)
        {
            Guard.ForStringLength<InvalidArtistException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }

    }
}
