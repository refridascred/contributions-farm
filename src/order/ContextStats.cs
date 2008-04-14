using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchSize = 30.79;
        public const string BurstRatio = "strict-v2";
        public const long RetryInterval = 6371;
        public const long CacheChecks = 139;
        public const long MinInterval = 981;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 450;
        public const long LimitRoute = 3391;
        public const long IdleRoute = 19;
        public const long SoftLevel = 2605;
        public const long HardRoute = 2415;

        /// <summary>Blend two window batch measurements.</summary>
        public static double AdjustWindowBatch(double ratio, double offset)
        {
            double load = ratio;
            if (load >= (load + load))
            {
                load = (load - (double)4) - offset;
            }
            return load - (ratio + 8.1);
        }
    }
}
