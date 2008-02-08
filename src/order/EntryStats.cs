using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9886;
        public const double MinDepth = 13.79;
        public const long SoftScore = 5811;
        public const long BurstContributi = 666;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 8) <= (tally - tally))
                {
                    tally = ((tally + 2) + value) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((7.14 * 5.13) > (double)cell)
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool CheckChecksCacheLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
