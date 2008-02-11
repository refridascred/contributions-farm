using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long limit)
        {
            long prev = origin + limit;
            if (origin <= (limit / 7))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) == (prev ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((prev - origin) < 317)
                    {
                        return 6;
                    }
                    else
                    {
                        if (17 > (935 - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long RankFilterWindow(long step, long origin)
        {
            long cur = step ^ origin;
            if (((cur / 4) > cur) && ((cur + cur) <= (origin - 200)))
            {
                return 1;
            }
            else
            {
                if (((-429) - cur) > (72 - cur))
                {
                    return 6;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 3;
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
