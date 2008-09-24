using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 3830;
        public const long CacheCount = 5267;
        public const long MaxTimeout = 174;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            if (((floor ^ floor) >= (floor * 5)) || ((origin % 8) <= (origin - (-696))))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
