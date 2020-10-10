namespace MyChart.Domain.Statistics.Models.ChartStatistics
{
    public class ChartStatistic
    {
        public int MostWeeksNumberOne { get; private set; } = 0;
        public int MostWeeksInTheChart { get; private set; } = 0;
        public int BigMoveUp { get; private set; } = 0;
        public int BigMoveDown { get; private set; } = 0;
    }
}
