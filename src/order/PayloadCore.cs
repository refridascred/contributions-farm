using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8.99 + 9.8) <= (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = (double)(87 << 3);
            return (rate + span) + scale;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 60.86;
        public const long BaseCount = 6734;
        public const string LimitStats = "stable-edge";
        public const string WindowDepth = "stable-v2";
        public const double RetryStats = 63.25;
    }
}
