namespace MyChart.Domain.Exceptions
{
    public class InvalidCountryException : BaseDomainException
    {
        public InvalidCountryException()
        {

        }

        public InvalidCountryException(string error) => this.Error = error;
    }
}
