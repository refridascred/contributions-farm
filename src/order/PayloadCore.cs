using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long origin)
        {
            long total = 91;
            foreach (long cell in values)
            {
                if (origin < (origin / 4))
                {
                    total = ((total - (origin + (long)values.Length)) % 4096) + cell;
                }
                else
                {
                    total = ((total * 4) + (-76)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 816;
            foreach (long sample in samples)
            {
                if ((sample - result) > 434)
                {
                    result = (result ^ (result - result)) % 97;
                }
            }
            return result;
        }
    }
}
