using MyChart.Domain.Common;
using MyChart.Domain.Exceptions;
using static MyChart.Domain.Models.ModelConstants.Country;

namespace MyChart.Domain.Models.Charts
{
    public class Country
    {
        internal Country(CountryType countryType, Continent continent)
        {
            Validate(countryType.Name, continent);
            Name = countryType.Name;
            Continent = continent;
        }

        public string Name { get; private set; }
        public Continent Continent { get; private set; }

        private void Validate(string name, Continent continent)
        {
            Guard.ForStringLength<InvalidCountryException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

            Guard.ForNotNull<InvalidCountryException>(
                continent,
                nameof(this.Continent));
        }
    }
}
