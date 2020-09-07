namespace MyChart.Domain.Exceptions
{
    public class InvalidChartException : BaseDomainException
    {
        public InvalidChartException()
        {

        }

        public InvalidChartException(string error) => this.Error = error;
    }
}
