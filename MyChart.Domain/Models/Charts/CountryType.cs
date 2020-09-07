using MyChart.Domain.Common;

namespace MyChart.Domain.Models.Charts
{
    public class CountryType : Enumeration
    {
        public static readonly CountryType Bulgaria = new CountryType(1, nameof(Bulgaria));
        public static readonly CountryType USA = new CountryType(2, nameof(USA));
        public static readonly CountryType UK = new CountryType(3, nameof(UK));

        private CountryType(int value)
            : this(value, FromValue<CountryType>(value).Name)
        {
        }

        private CountryType(int value, string name)
            : base(value, name)
        {
        }
    }
}
