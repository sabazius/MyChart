using MyChart.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace MyChart.Domain.Statistics.Models.SongStatistics
{
    public class AllSongsStatistics : IAggregateRoot
    {
        private HashSet<SongStatistic> _allSongStats;

        public IReadOnlyCollection<SongStatistic> AllSongStats
            => _allSongStats.ToList().AsReadOnly();

        internal AllSongsStatistics()
        {
            _allSongStats = new HashSet<SongStatistic>();
        }

        //public void AddSongStatistic()
    }
}
