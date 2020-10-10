using MyChart.Domain.Common;

namespace MyChart.Domain.Statistics.Models.SongStatistics
{
    public class SongStatistic : Entity<int>
    {
        public int WeeksInTheChart { get; private set; } = 0;
        public int TopPosition { get; private set; } = 0;
        public int WeeksInTopPosition { get; private set; } = 0;

        internal SongStatistic(int weeksInChart, int topPosition, int weeksInTopPosition)
        {
            WeeksInTheChart = weeksInChart;
            TopPosition = topPosition;
            WeeksInTopPosition = weeksInTopPosition;
        }
    }
}
