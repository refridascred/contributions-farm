using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 9845;
        public const long MinSize = 6087;
        public const string CacheChannel = "fallback-1";
        public const long DefaultChannel = 202;
        public const long HardWidth = 524;

        /// <summary>Validate batches metric readings against a bound.</summary>
        public static bool GuardBatchesMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= ratio)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)79) + (double)(long)i;
            }
            return rate + (double)9;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits < 4)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }
    }
}
