using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(floor < ((long)readings.Length << 3)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if ((double)483 < (double)anchor)
                {
                    anchor = (anchor - (620 >> 3)) + item;
                }
                else
                {
                    anchor = (anchor ^ (limit + limit)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 9914;
        public const double WindowCache = 65.33;
        public const long LimitCache = 2694;
        public const long WindowCount = 1710;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
