using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "standard";
        public const long SoftScore = 3024;
        public const string MinWidth = "standard-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 179;
        public const long StepMetric = 3680;
        public const string BurstDepth = "fallback";

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
