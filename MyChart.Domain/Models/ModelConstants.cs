using System;

namespace MyChart.Domain.Models
{
    public class ModelConstants
    {
        public class Common
        {
            public const int MinNameLength = 3;
            public const int MaxNameLength = 30;
            public const int MinEmailLength = 6;
            public const int MaxEmailLength = 50;
            public const int MaxUrlLength = 2048;
            public const int Zero = 0;
        }

        public class Song
        {
            public const int MinNameLength = 1;
            public const int MaxNameLength = 100;
            public const int MinBPM = 10;
            public const int MaxBPM = 2000;
            public const int MinReleaseYear = 2000;
        }

        public class Chart
        {
            public const int MinNameLength = 3;
            public const int MaxNameLength = 100;
            public const int MinSongs = 5;
            public const int MaxSongs = 1000;
            public const int MinChartYear = 2020;
        }

        public class Country
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 50;
        }

        public class Artist
        {
            public const int MinNameLength = 1;
            public const int MaxNameLength = 50;
        }
        //public class Options
        //{
        //    public const int MinNumberOfSeats = 2;
        //    public const int MaxNumberOfSeats = 50;
        //}

        //public class PhoneNumber
        //{
        //    public const int MinPhoneNumberLength = 5;
        //    public const int MaxPhoneNumberLength = 20;
        //    public const string PhoneNumberRegularExpression = @"\+[0-9]*";
        //}

        //public class CarAd
        //{
        //    public const int MinModelLength = 2;
        //    public const int MaxModelLength = 20;
        //}
    }
}
