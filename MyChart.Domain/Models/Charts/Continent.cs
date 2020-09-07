using MyChart.Domain.Common;

namespace MyChart.Domain.Models.Charts
{
    public class Continent : Enumeration
    {
        public static readonly Continent Europe = new Continent(1, nameof(Europe));
        public static readonly Continent NorthAmerica = new Continent(2, nameof(NorthAmerica));
        public static readonly Continent SouthAmerica = new Continent(3, nameof(SouthAmerica));
        public static readonly Continent Asia = new Continent(4, nameof(Asia));
        public static readonly Continent Africa = new Continent(5, nameof(Africa));
        public static readonly Continent Australia = new Continent(6, nameof(Australia));
        public static readonly Continent Antarctica = new Continent(7, nameof(Antarctica));


        private Continent(int value)
            : this(value, FromValue<Continent>(value).Name)
        {
        }

        private Continent(int value, string name)
            : base(value, name)
        {
        }
    }
}
