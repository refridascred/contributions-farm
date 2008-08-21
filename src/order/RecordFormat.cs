using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 3074;
        public const double BurstQueue = 38.81;
        public const long CacheQueue = 416;
        public const long IdleSpan = 6491;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 7364;
        public const long CacheBudget = 2481;
        public const long BatchChecks = 5614;

        /// <summary>Grade a report notes value against two limits.</summary>
        public static long RankReportNotes(long step, long limit)
        {
            long lane = step + limit;
            if (lane >= (858 - lane))
            {
                return 8;
            }
            else
            {
                if (((double)lane > (double)limit) || ((lane >> 5) != (lane ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!!(7.0 <= (double)matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
