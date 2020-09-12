using System;
using System.Collections.Generic;
using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using MyChart.Domain.Models.Music;
using static MyChart.Domain.Models.ModelConstants.Chart;

namespace MyChart.Domain.Models.Charts
{
    public class Chart : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Song> songs;

        internal Chart(string name, int numberOfSongs, string url, DateTime releaseDate)
        {
            ValidateName(name);
            ValidateNumberOfSongs(numberOfSongs);
            ValidateUrl(url);
            ValidateChartDate(releaseDate);
            Name = name;
            NumberOfSongs = numberOfSongs;
            SourceURL = url;
            ChartDate = releaseDate;
            songs = new HashSet<Song>(NumberOfSongs);
        }

        internal Chart(string name, int numberOfSongs, string sourceUrl, DateTime releaseDate, Country country)
        {
            Name = name;
            NumberOfSongs = numberOfSongs;
            SourceURL = sourceUrl;
            ChartDate = releaseDate;
            songs = new HashSet<Song>(NumberOfSongs);
            Country = country;
        }

        public string Name { get; private set; }
        public int NumberOfSongs { get; private set; }
        public string SourceURL { get; private set; }
        public DateTime ChartDate { get; private set; }
        public Country? Country { get; private set; }

        #region Setters
        /// <summary>
        /// Update <see cref="Chart.Name"/>
        /// </summary>
        /// <param name="songName">name of the chart</param>
        /// <returns>current chart object</returns>
        public Chart UpdateName(string chartName)
        {
            this.ValidateName(chartName);
            Name = chartName;
            return this;
        }
        /// <summary>
        /// Update <see cref="Chart.NumberOfSongs"/>
        /// </summary>
        /// <param name="songName">Number os songs for this chart</param>
        /// <returns>current chart object</returns>
        public Chart UpdateNumberOfSongs(int numberOfSongs)
        {
            this.ValidateNumberOfSongs(numberOfSongs);
            NumberOfSongs = numberOfSongs;
            return this;
        }
        /// <summary>
        /// Update <see cref="Chart.SourceURL"/>
        /// </summary>
        /// <param name="url">URL to validate</param>
        /// <returns>current <see cref="Chart"/> object</returns>
        public Chart UpdateURL(string url)
        {
            ValidateUrl(url);
            this.SourceURL = url;

            return this;
        }
        /// <summary>
        /// Update <see cref="Chart.ChartDate"/>
        /// </summary>
        /// <param name="chartDate">new date of the chart</param>
        /// <returns>current <see cref="Chart"/></returns>
        public Chart UpdateChartDate(DateTime chartDate)
        {
            ValidateChartDate(chartDate);
            this.ChartDate = chartDate;

            return this;
        }
        /// <summary>
        /// Update current <see cref="Chart.Country"/>
        /// </summary>
        /// <param name="countryType">Name of the country</param>
        /// <param name="continent">Continent</param>
        /// <returns>current <see cref="Chart"/></returns>
        public Chart UpdateCountry(CountryType countryType, Continent continent)
        {
            if (this.Country == null || this.Country.Name != countryType.Name || this.Country.Continent != continent)
            {
                this.Country = new Country(countryType, continent);
            }

            return this;
        }
        #endregion



        #region Validators
        /// <summary>
        /// Validate <see cref="Chart.Name"/>
        /// </summary>
        /// <param name="name">Name of the chart</param>
        private void ValidateName(string name)
        {
            Guard.ForStringLength<InvalidChartException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }
        /// <summary>
        /// Validate <see cref="Chart.NumberOfSongs"/>
        /// </summary>
        /// <param name="name">Number of songs for this chart</param>
        private void ValidateNumberOfSongs(int numberOfSongs)
        {
            Guard.AgainstOutOfRange<InvalidChartException>(
                numberOfSongs,
                MinSongs,
                MaxSongs,
                nameof(this.NumberOfSongs));
        }
        /// <summary>
        /// Validate <see cref="Chart.SourceURL"/>
        /// </summary>
        /// <param name="chartUrl">URL to validate</param>
        private void ValidateUrl(string chartUrl)
            => Guard.ForValidUrl<InvalidChartException>(
                chartUrl,
                nameof(this.SourceURL));
        /// <summary>
        /// Validate <see cref="Chart.ChartDate"/>
        /// </summary>
        /// <param name="chartDate">Chart Date to validate</param>
        private void ValidateChartDate(DateTime chartDate)
            => Guard.AgainstOutOfRange<InvalidChartException>(
                chartDate,
                new DateTime(MinChartYear, 1, 1),
                DateTime.Now,
                nameof(this.ChartDate)
            );
        #endregion
    }
}
