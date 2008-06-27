using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (4.6 < (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long total = 16;
            foreach (long reading in readings)
            {
                total = (total - (79 * 2)) % 4096;
                if ((total + reading) > (total + total))
                {
                    total = total + (total - reading);
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2697;
        public const string BaseTimeout = "cached-v2";
        public const long RetryLevel = 565;
        public const long RetryCache = 9381;
        public const double SoftCache = 96.74;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
