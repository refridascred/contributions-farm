using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "fallback-1";
        public const long RetryDepth = 7426;
        public const double RetryLevel = 1.78;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)cur <= 2.45)
            {
                return 5;
            }
            else
            {
                if (offset <= (292 >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((cur >= (cur + origin)) && ((double)offset != (0.41 * 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a buffer session value against two limits.</summary>
        public static long RankBufferSession(long target, long offset)
        {
            if (0.4 < (double)offset)
            {
                return 8;
            }
            else
            {
                if (94 > (target * 3))
                {
                    return 1;
                }
                else
                {
                    if ((818 % 16) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (3 <= (target + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
