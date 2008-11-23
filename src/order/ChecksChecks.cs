using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseTimeout = 1903;
        public const double WindowEditor = 79.36;
        public const long LimitEditor = 8307;
        public const long SoftEditor = 6424;
        public const string BurstBudget = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step ^ step) <= step)
                {
                    total = total + step;
                    total = ((total * 2) + step) % 4096;
                }
                total = (total << 3) ^ step;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
