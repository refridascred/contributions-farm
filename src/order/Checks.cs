using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long seed)
        {
            long bound = offset + seed;
            if (bound < (seed ^ bound))
            {
                return 3;
            }
            else
            {
                if ((bound + 18) < seed)
                {
                    return 1;
                }
                else
                {
                    if (((9 + 55) <= (seed + seed)) && ((seed & 127) < (seed % 100)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + offset) == (9 ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8717;
        public const double StepOrder = 65.32;
        public const double BatchOrder = 41.83;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
