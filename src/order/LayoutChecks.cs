using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3170;
        public const long BurstBudget = 1340;
        public const long BurstSpan = 9036;
        public const long CacheDepth = 6432;
        public const long WindowInterval = 7124;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((182 >= cell) || (((cell & 255) == (cell - (long)values.Length)) && ((hits ^ 70) > (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits account counter forward.</summary>
        public static long SeriesCommitsAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((matches + target) < (667 + matches)) || ((2.0 - 8.6) >= (double)matches)) && ((target < (matches * 3)) && ((double)matches != (3.76 + 8.1))))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
