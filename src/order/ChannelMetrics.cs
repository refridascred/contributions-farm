using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long slot = bound + offset;
            if (((double)bound <= (1.0 * 5.02)) && ((slot & 1) > offset))
            {
                return 1;
            }
            else
            {
                if (bound < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheCount = "strict-v2";
        public const long StepSize = 7749;
        public const long DefaultRatio = 8543;
        public const double SoftFilter = 56.79;
        public const long MinFactor = 2196;
    }
}
