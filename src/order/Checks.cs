using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2328;
        public const double CacheFormat = 3.0;
        public const long StepFormat = 8553;
        public const long RetryTimeout = 2987;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((anchor + offset) >= 33)
                {
                    anchor = ((anchor << 2) ^ (entry + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor - 13) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
