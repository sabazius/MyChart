namespace MyChart.Domain.Exceptions
{
    class InvalidSongException : BaseDomainException
    {
        public InvalidSongException()
        {

        }

        public InvalidSongException(string error) => this.Error = error;
    }
}
