using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a tools checks counter forward.</summary>
        public static long SeriesToolsChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((437 ^ seed) > (seed & 31))
                {
                    state = (state + seed) % 97;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6169;
        public const long BurstBuffer = 758;
        public const long SoftBuffer = 7015;
        public const long MaxSize = 6148;
        public const long DefaultBuffer = 3942;
    }
}
