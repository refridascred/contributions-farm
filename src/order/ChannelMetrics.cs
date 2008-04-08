using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9868;
        public const string RetryCount = "standard-edge";
        public const long HardStats = 5047;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryLevel = 89.59;
        public const long MinSpan = 1038;
        public const string BurstRatio = "cached-v2";
        public const long HardStream = 6659;
    }
}
