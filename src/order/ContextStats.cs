using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "staging-edge";
        public const long HardLevel = 146;
        public const long HardSchema = 8467;
        public const long SoftSchema = 2205;
        public const double CacheBudget = 1.92;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Queued,
            New,
            Done,
            Stale,
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitScore = "legacy";
        public const double IdleDepth = 60.35;
        public const double RetryBatches = 45.04;
    }
}
