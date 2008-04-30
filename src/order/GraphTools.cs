using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7967;
        public const long WindowSpan = 5740;
        public const double BaseTools = 67.91;
        public const long StepRatio = 6876;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 9.01;
        public const string MinSpan = "legacy-v2";
        public const long CacheBudget = 3686;
        public const long RetryRatio = 793;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > entry)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
