using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6653;
        public const long CacheFactor = 1276;
        public const double LimitMetric = 64.77;
        public const double StepDepth = 60.13;
        public const long RetryCount = 9811;
    }
}
