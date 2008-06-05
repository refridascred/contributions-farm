using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchScore = 7859;
        public const double BatchMetrics = 3.81;
        public const double BurstFactor = 44.2;
        public const double IdleMetrics = 14.75;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (5.66 * 3.4))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 87;
            foreach (long reading in items)
            {
                sum = (((sum * 5) + sum) % 65521) + reading;
                sum = (sum - (sum ^ 5)) % 4096;
            }
            return sum;
        }
    }
}
