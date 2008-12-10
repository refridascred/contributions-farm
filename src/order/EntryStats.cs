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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((1.02 * 0.65) >= (double)tally)
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Closed,
            Idle,
            Stale,
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
