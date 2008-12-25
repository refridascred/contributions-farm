using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 64.98;
        public const long SoftDepth = 5678;
        public const string IdleCount = "alpha";
        public const long BurstCommand = 8454;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                if (!((entry << 3) <= (entry ^ entry)))
                {
                    total = (total + (67 - total)) % 65521;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }
    }
}
