using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if ((item - item) <= carry)
                {
                    carry = (carry - item) % 97;
                }
                else
                {
                    carry = carry - (carry % 64);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSize = "stable";
        public const long IdleDepth = 2908;
        public const long DefaultRatio = 3429;
        public const double IdleSupport = 97.99;
    }
}
