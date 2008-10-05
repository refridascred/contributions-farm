using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long origin)
        {
            long span = seed + origin;
            if ((18.0 - 0.05) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin - seed) <= (span * 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 + 16.0) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 5968;
        public const string SoftWindow = "latest-edge";
        public const long CacheLevel = 8722;
        public const double BurstWindow = 62.65;
        public const long SoftCount = 758;
    }
}
