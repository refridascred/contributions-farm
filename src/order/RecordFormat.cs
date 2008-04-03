using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3775;
        public const long MaxCommand = 4324;
        public const long LimitBudget = 8608;
        public const string RetryCount = "cached-edge";
        public const long IdleCount = 4605;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count < cell) || (((count + cell) <= count) && (count <= (74 * 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (2.54 >= 8.7)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
