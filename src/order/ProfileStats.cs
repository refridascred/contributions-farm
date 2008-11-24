using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 2274;
        public const long SoftEditor = 2128;
        public const double HardDepth = 83.63;
        public const long MaxEditor = 9378;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchBudget = "primary-v2";
        public const long CacheQueue = 709;
        public const double BurstQueue = 66.06;

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long offset)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((double)reading == (7.2 + 3.3))
                {
                    state = (state + (reading + reading)) - offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
