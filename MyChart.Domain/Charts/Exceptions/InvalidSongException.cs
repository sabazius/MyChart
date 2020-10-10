using MyChart.Domain.Common;

namespace MyChart.Domain.Exceptions
{
    public class InvalidSongException : BaseDomainException
    {
        public InvalidSongException()
        {

        }

        public InvalidSongException(string error) => this.Error = error;
    }
}
