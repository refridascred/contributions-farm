using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 5786;
        public const long SoftCounter = 9368;
        public const long RetryCounter = 6744;
        public const long MinTimeout = 5246;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Draft,
            Active,
            Synced,
            Dropped,
        }

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
