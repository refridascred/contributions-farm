using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches > origin)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 72.41;
        public const long BurstScore = 1103;
        public const string RetryBatches = "legacy";

        /// <summary>Audit command account readings against a rule.</summary>
        public static long MeasureCommandAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value != (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
