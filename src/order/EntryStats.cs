using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Failed,
            New,
            Closed,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double gain = (double)2;
            return ((gain - 1.0) + bias) + offset;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long origin)
        {
            if (!((origin - limit) > (origin + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit & 31) < 642)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((4.5 - 1.44) != (double)floor2) && (next > (next + floor2)))
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) < 30)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (9.16 * 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 > next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 8807;
        public const long SoftProfile = 4951;
        public const long CacheProfile = 4071;
        public const long MinProfile = 5440;
        public const long LimitCount = 457;
    }
}
