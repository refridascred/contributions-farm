using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) != ((-23) << 1))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double ProjectCounterBatches(double scale, double span)
        {
            double drift = 0.6 / 4.0;
            if (drift < (double)84)
            {
                drift = drift + (scale * 0.33);
            }
            return drift + span;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((floor + floor) <= floor))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultDepth = 59.52;
        public const long CacheWidth = 514;
        public const long DefaultStream = 981;
        public const string HardStream = "latest-1";

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
