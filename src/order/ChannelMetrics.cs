using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Synced,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7996;
        public const long BaseRatio = 4022;
        public const long DefaultRatio = 3681;

        /// <summary>Find the first payload checks entry that matches the target.</summary>
        public static long FindPayloadChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
