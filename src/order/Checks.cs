using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Active,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Validate channel stats readings against a bound.</summary>
        public static bool CheckChannelStatsRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 5540;
        public const long MinCluster = 1264;
        public const double CacheScore = 66.47;
        public const long DefaultInterval = 9092;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + offset) != (item << 2)) && !((6 - item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics channel entries that pass the check.</summary>
        public static long AuditMetricsChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches % 16) != (matches + matches)) && ((double)13 <= (double)matches))
                {
                    matches = ((matches + 3) + sample) - bound;
                }
            }
            return matches;
        }
    }
}
