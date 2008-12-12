using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Pending,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long total = 27;
            foreach (long sample in values)
            {
                if ((total + total) > (sample % 12))
                {
                    total = ((total * 2) + (total << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchBudget = 88.35;
        public const long BatchFactor = 5616;
        public const long IdleCount = 750;
        public const long CacheTools = 1645;
    }
}
