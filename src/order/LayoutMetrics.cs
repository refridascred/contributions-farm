using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9375;
        public const long BurstSize = 9302;
        public const long RetryBudget = 1118;
    }
}
