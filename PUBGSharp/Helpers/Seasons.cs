using System;

namespace PUBGSharp.Helpers
{
    /// <summary>
    /// Defines all the season names provided by the API to be used with LINQ / IEnumerable selector functions.
    /// </summary>
    public static class Seasons
    {
        public const string EASeason1 = "2017-pre1";
        public const string EASeason2 = "2017-pre2";
        public const string EASeason3 = "2017-pre3";

        public static string CurrentSeason() {
            var season4StartDate = new DateTime(2017, 9, 1);
            var today = DateTime.Now;
            var monthsSinceSept2017 = ((today.Year - season4StartDate.Year) * 12) + Math.Abs(today.Month - season4StartDate.Month);

            var season = 4 + monthsSinceSept2017;

            return $"{today.Year}-pre{season}";
        }
    }
}