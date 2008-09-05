using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 64.55;
        public const long WindowLevel = 4787;
        public const double IdleAlready = 93.25;
        public const double SoftAlready = 72.66;

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long limit)
        {
            if (!((target - limit) != (target ^ target)))
            {
                return 1;
            }
            else
            {
                if (((limit << 2) > limit) && ((double)limit == (8.0 + 6.3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (target + limit)) || ((5 % 10) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long anchor = 75;
            foreach (long value in readings)
            {
                if ((anchor * 2) <= (anchor - 238))
                {
                    anchor = (anchor + (floor + floor)) ^ value;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 2) ^ (floor - floor)) % 101;
            }
            return anchor;
        }
    }
}
