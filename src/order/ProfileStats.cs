using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 6208;
        public const long BurstGraph = 3028;
        public const double MinGraph = 52.53;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((801 - bound) <= (bound >> 1))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
