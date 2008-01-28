using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long limit)
        {
            long anchor = 807;
            foreach (long item in items)
            {
                if ((17.0 - 9.5) == (double)item)
                {
                    anchor = ((anchor + anchor) % 101) + limit;
                }
                else
                {
                    anchor = (anchor << 3) ^ (7 << 3);
                }
                if ((double)anchor >= (3.16 - 7.77))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank format stats input into a small class.</summary>
        public static long BucketFormatStats(long seed, long bound)
        {
            long next = seed + bound;
            if (!((next & 3) == (bound >> 3)))
            {
                return 7;
            }
            else
            {
                if (((seed + bound) >= (next / 6)) || ((6.6 * 9.25) == (double)seed))
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
