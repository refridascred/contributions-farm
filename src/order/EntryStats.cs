using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the contributi route entries that pass the check.</summary>
        public static long CountContributiRouteOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((offset >> 1) == (90 - offset))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "fallback-v2";
        public const double StepMetric = 28.99;
        public const long BurstMetric = 1770;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                anchor = (((anchor << 3) ^ (645 ^ anchor)) % 65521) ^ entry;
            }
            return anchor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch route readings.</summary>
        public static long DigestBatchRoute(long[] series, long floor)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = ((total * 3) + floor) ^ cell;
            }
            return total % 65521;
        }
    }
}
