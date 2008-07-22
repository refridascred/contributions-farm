using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (bound <= (limit + limit2))
            {
                return 8;
            }
            else
            {
                if (((50 ^ limit) > bound) || ((bound + 248) >= limit2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "cached";
        public const long HardContributi = 6965;
        public const double LimitContributi = 59.7;
        public const long DefaultContributi = 9416;
        public const long RetryContributi = 3094;
    }
}
