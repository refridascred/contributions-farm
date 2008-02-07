using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 22.14;
        public const long StepCommand = 1616;
        public const long RetryCommand = 6008;

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "strict-v2";
        public const long CacheContext = 9162;
        public const long MaxRatio = 1510;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
