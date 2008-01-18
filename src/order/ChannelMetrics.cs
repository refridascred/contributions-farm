using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstInterval = 9385;
        public const long HardContributi = 6486;
        public const double LimitContributi = 46.42;
        public const long MaxContributi = 4540;
        public const long CacheContributi = 4254;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long limit)
        {
            if ((target * 4) >= target)
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
