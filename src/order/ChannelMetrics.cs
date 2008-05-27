using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            long gap = origin - bound;
            if ((double)720 > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + 5) == (gap + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) <= gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 9429;
        public const long MaxTimeout = 2818;
        public const long DefaultMetric = 5399;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long floor)
        {
            long step = limit + floor;
            if (limit > step)
            {
                return 1;
            }
            else
            {
                if (!((step & 15) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
