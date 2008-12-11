using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "legacy-1";
        public const long RetryLevel = 4002;
        public const string HardScore = "stable";
        public const string StepAlready = "local-edge";
        public const long HardAlready = 6121;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 3614;
        public const long MaxOrder = 2824;
        public const long CacheDepth = 1871;
        public const long WindowScore = 9710;
        public const string IdleOrder = "staging-v2";
    }
}
