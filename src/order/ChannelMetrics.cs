using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 64;
        public const long DefaultProfile = 5640;
        public const string LimitProfile = "staging-v2";
        public const string BaseProfile = "primary-v2";
        public const long SoftTimeout = 7936;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 3751;
        public const string BurstFactor = "open";
        public const double MaxCount = 68.78;
        public const string CacheWindow = "strict-1";
        public const double BurstScore = 12.21;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                if ((-705) < acc)
                {
                    acc = ((acc << 2) ^ value) - floor;
                }
            }
            return acc % 4096;
        }
    }
}
