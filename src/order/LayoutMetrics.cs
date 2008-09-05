using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values)
        {
            long sum = 662;
            foreach (long datum in values)
            {
                sum = ((sum ^ (sum / 6)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of already cache entries.</summary>
        public static long ScoreAlreadyCache(long[] items)
        {
            long sum = -9;
            foreach (long entry in items)
            {
                sum = (sum ^ 524) - entry;
            }
            if (sum > 28)
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
