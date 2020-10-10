using MyChart.Domain.Common;

namespace MyChart.Domain.Statistics.Models.ArtistStatistics
{
    public class ArtistStatistics : Entity<int>
    {
        public int TotalSongs { get; private set; } = 0;
        public int TopSongId { get; private set; } = 0;
    }
}
