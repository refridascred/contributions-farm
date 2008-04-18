using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long floor, long origin)
        {
            long bound = floor - origin;
            if (((41 & 1) < (origin ^ (-608))) || (floor < (bound / 8)))
            {
                return 5;
            }
            else
            {
                if (!((629 / 3) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - origin) < 486)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if (step >= (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - floor) > (floor - step))
                {
                    return 7;
                }
                else
                {
                    if ((step & 1) >= (step & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.74 - 8.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
