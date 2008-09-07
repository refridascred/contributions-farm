using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] values, long origin)
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

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "open-v2";
        public const long BatchFormat = 5428;
        public const long SoftFormat = 1963;
        public const long BaseTimeout = 2397;

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long MeasureGraphQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((435 + 296) < (entry & 63)) || !((hits % 8) >= entry))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double bias2 = (double)(0 / 3);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (3.9 * 1.3)) - floor;
            }
            return bias2 + (double)(-960);
        }
    }
}
