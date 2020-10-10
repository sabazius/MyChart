using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using System;
using static MyChart.Domain.Models.ModelConstants.Artist;

namespace MyChart.Domain.Models.Music
{
    public class Artist : Entity<int>
    {

        internal Artist(string name)
        {
            Validate(name);
            Name = name;
        }

        public string Name { get; private set; }
        public string? Country { get; private set; }
        public DateTime? BirthDay { get; private set; }

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
