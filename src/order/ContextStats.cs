using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long target2)
        {
            if (((target2 + 8) > target2) || (target2 <= (target * 4)))
            {
                return 8;
            }
            else
            {
                if (!((7.23 - 6.7) < (double)target2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank stats metrics input into a small class.</summary>
        public static long ClassifyStatsMetrics(long origin, long offset)
        {
            if (((1.9 + 17.0) <= (double)origin) || ((offset + origin) <= (offset % 8)))
            {
                return 5;
            }
            else
            {
                if ((origin + offset) >= (offset << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a buffer checks reading by value.</summary>
        public static long SeekBufferChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "staging-v2";
        public const long CacheAccount = 6341;
        public const double BatchSize = 34.22;
        public const string MinSize = "staging";
        public const long LimitAccount = 2903;
    }
}
