using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) <= count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
