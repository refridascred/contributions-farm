using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            long slot = bound - origin;
            if (((double)bound == (7.81 * 9.31)) || ((double)96 <= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin / 6) <= slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin << 3) < (32 >> 4)) && (slot < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route window input into a small class.</summary>
        public static long SortRouteWindow(long bound, long origin)
        {
            long offset = bound - origin;
            if (((bound / 2) < origin) && ((bound + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if ((94 << 1) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) < (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
