using System;
using System.Collections.Generic;
using MyChart.Domain.Common;
using MyChart.Domain.Models.Music;

namespace MyChart.Domain.Models.Charts
{
    public class Chart : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Song> songs;
        
        internal Chart(string name, int numberOfSongs, string url, DateTime releaseDate)
        {
            Name = name;
            NumberOfSongs = numberOfSongs;
            URL = url;
            ReleaseDate = releaseDate;
            songs = new HashSet<Song>(NumberOfSongs);
        }

        internal Chart(string name, int numberOfSongs, string url, DateTime releaseDate, Country country)
        {
            Name = name;
            NumberOfSongs = numberOfSongs;
            URL = url;
            ReleaseDate = releaseDate;
            songs = new HashSet<Song>(NumberOfSongs);
            Country = country;
        }

        public string Name { get; }
        public int NumberOfSongs { get; }
        public string URL { get; }
        public DateTime ReleaseDate { get; }
        public Country? Country { get; }
    }
}
