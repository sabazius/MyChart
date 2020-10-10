using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using static MyChart.Domain.Models.ModelConstants.Song;

namespace MyChart.Domain.Models.Music
{
    public class SongOptions : ValueObject
    {

        internal SongOptions(int bpm, string key)
        {
            ValidateBPM(bpm);
            ValidateKey(key);
            BPM = bpm;
            Key = key;
        }

        public int BPM { get; private set; }
        public string Key { get; private set; }
                
        /// <summary>
        /// Validate <see cref="Song.BPM"/>
        /// </summary>
        /// <param name="bpm">beats per minute</param>
        private void ValidateBPM(int bpm)
        {
            Guard.AgainstOutOfRange<InvalidSongException>(
                bpm,
                MinBPM,
                MaxBPM,
                nameof(this.BPM)
            );
        }
        /// <summary>
        /// Validate <see cref="Song.Key"/>
        /// </summary>
        /// <param name="key">Key of the song</param>
        private void ValidateKey(string key)
        {
            Guard.ForStringLength<InvalidSongException>(
                key,
                MinKeyLength,
                MaxKeyLength,
                nameof(this.Key)
            );
        }
    }
}
