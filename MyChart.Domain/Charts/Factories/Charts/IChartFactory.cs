using MyChart.Domain.Common;
using MyChart.Domain.Models.Charts;
using System;

namespace MyChart.Domain.Factories.Charts
{
    interface IChartFactory : IFactory<Chart>
    {
        IChartFactory WithName(string name);
        IChartFactory WithNumberOfSongs(int numberOfSongs);
        IChartFactory WithSourceURL(string sourceUrl);
        IChartFactory WithReleaseDate(DateTime releaseDate);
        IChartFactory WithCountry(Country country);


    }
}
