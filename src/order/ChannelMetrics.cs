using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (83 - (long)i)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRatio = "primary-v2";
        public const long IdleFactor = 1389;
        public const long RetryRoute = 7519;
        public const long MaxInterval = 5862;
        public const long StepRatio = 522;
    }
}
