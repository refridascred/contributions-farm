using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double load = span;
            if (load < (double)42)
            {
                load = load - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 6.8) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardTimeout = 33.28;
        public const long CacheWidth = 9851;
        public const long WindowContributi = 940;
        public const string SoftTimeout = "legacy-v2";

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = mark - (long)i2;
                }
                mark = ((mark * 2) + (mark - mark)) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 14.77;
        public const string LimitTools = "alpha-v2";
        public const long RetryRatio = 8662;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((394 <= (hits & 1)) && ((hits + 56) < (sample / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
