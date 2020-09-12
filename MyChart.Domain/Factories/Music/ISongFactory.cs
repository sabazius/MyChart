using MyChart.Domain.Models.Music;
using System;

namespace MyChart.Domain.Factories.Music
{
    public interface ISongFactory : IFactory<Song>
    {
        ISongFactory WithName(string name);
        ISongFactory WithArtist(Artist artist);
        ISongFactory WithOptions(SongOptions options);
        ISongFactory WithReleaseDate(DateTime releaseDate);
        ISongFactory WithYouTubeURL(string url);
    }
}
