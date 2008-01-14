using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6460;
        public const string MinMetrics = "cached-v2";
        public const long BurstFactor = 2160;
        public const long MinTimeout = 2445;
        public const long CacheTimeout = 9998;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            New,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((19 > (matches + 397)) && ((20.0 - 3.8) < (double)limit))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 ^ count) > (long)values.Length)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
