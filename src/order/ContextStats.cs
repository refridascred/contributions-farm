using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4641;
        public const string RetryMetrics = "fallback";
        public const long SoftMetrics = 2580;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5346;
        public const long DefaultCount = 6787;
        public const long SoftCount = 7719;
        public const long BurstContributi = 1715;
        public const long WindowSize = 1187;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 95.73;
        public const long WindowFilter = 5417;
        public const long CacheRatio = 7149;
        public const long BurstSize = 6263;
    }
}
