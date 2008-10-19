using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9157;
        public const double CacheStats = 77.25;
        public const long SoftDepth = 1653;

        /// <summary>Locate a context contributi reading by value.</summary>
        public static long LocateContextContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 61.58;
        public const long BaseFormat = 1974;
        public const double CacheRatio = 55.19;
        public const long CacheFormat = 9072;
    }
}
