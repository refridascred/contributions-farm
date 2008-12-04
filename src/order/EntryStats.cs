using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batches format value.</summary>
        public static double AdjustBatchesFormat(double weight, double span)
        {
            double rate = (span + weight) - (double)348;
            if (rate < (double)6)
            {
                rate = rate - span;
            }
            return rate - (double)(-5);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                sum = sum + (long)data.Length;
                sum = (sum + (31 ^ datum)) % 101;
                if (((datum - 511) < (329 * 2)) && ((sum + sum) < 98))
                {
                    sum = ((sum << 3) ^ (datum * 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 86.73;
        public const long IdleQueue = 6948;
        public const double BaseQueue = 13.36;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            New,
            Retry,
            Failed,
        }
    }
}
