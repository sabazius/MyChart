using MyChart.Domain.Common;

namespace MyChart.Domain.Exceptions
{
    public class InvalidArtistException : BaseDomainException
    {

        public InvalidArtistException()
        {

        }

        public InvalidArtistException(string error) => this.Error = error;
    }
}
