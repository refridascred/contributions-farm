using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long total = 310;
            foreach (long reading in data)
            {
                if (total > (reading << 1))
                {
                    total = (total ^ (total ^ reading)) % 65521;
                }
                else
                {
                    total = (total + (reading >> 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((8.39 + 2.5) != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + tally) != (6 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
