using MyChart.Domain.Models.Charts;
using System;

namespace MyChart.Domain.Factories.Charts
{
    internal class ChartFactory : IChartFactory
    {
        private string name = default!;
        private int numberOfSongs = default!;
        private string sourceURL = default!;
        private DateTime chartDate = default!;
        private Country? country = default;

        public IChartFactory WithCountry(Country country)
        {
            this.country = country;
            return this;
        }

        public IChartFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public IChartFactory WithNumberOfSongs(int numberOfSongs)
        {
            this.numberOfSongs = numberOfSongs;
            return this;
        }

        public IChartFactory WithReleaseDate(DateTime releaseDate)
        {
            this.chartDate = releaseDate;
            return this;
        }

        public IChartFactory WithSourceURL(string sourceUrl)
        {
            this.sourceURL = sourceUrl;
            return this;
        }

        public Chart Build() => new Chart(name, numberOfSongs, sourceURL, chartDate);

        public Chart Build(string name, int numberOfSongs, string url, DateTime releaseDate)
           => this
               .WithName(name)
               .WithNumberOfSongs(numberOfSongs)
               .WithSourceURL(url)
               .WithReleaseDate(releaseDate)
               .Build();

        public Chart Build(string name, int numberOfSongs, string url, DateTime releaseDate, Country country)
           => this
               .WithName(name)
               .WithNumberOfSongs(numberOfSongs)
               .WithSourceURL(url)
               .WithReleaseDate(releaseDate)
               .WithCountry(country)
               .Build();
    }
}
