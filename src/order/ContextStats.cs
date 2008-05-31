using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 461;
        public const long BatchBudget = 661;
        public const string HardReport = "stable";

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + ((long)i & 7)) % 4096;
                sum = (sum + (sum % 3)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Idle,
            Queued,
        }
    }
}
