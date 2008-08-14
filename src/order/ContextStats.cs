using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((9.9 + 7.0) < (double)floor) || ((reading ^ reading) > reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context token reading.</summary>
        public static double ProjectContextToken(double scale, double floor)
        {
            double drift = (double)564 + floor;
            if (drift >= (double)2)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + scale;
            }
            return drift + (double)2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "standard-1";
        public const long RetrySpan = 6548;
        public const string BaseMetrics = "latest";
        public const long StepMetrics = 9959;

        /// <summary>Check that every batch context entry stays within the limit.</summary>
        public static bool GuardBatchContextRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
