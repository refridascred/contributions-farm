using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats schema pair into a bucket.</summary>
        public static long ClassifyStatsSchema(long step, long target)
        {
            if ((double)target <= 1.83)
            {
                return 8;
            }
            else
            {
                if ((3.4 + 1.03) > (double)target)
                {
                    return 4;
                }
                else
                {
                    if (target <= (7 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long limit2)
        {
            if ((limit2 + limit) < limit2)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (6.7 - 6.62)) || ((limit2 % 10) > (limit2 / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 >> 2) <= limit2) && ((limit2 << 2) != (52 >> 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 2115;
        public const long SoftTimeout = 5178;
        public const long WindowScore = 6674;
        public const long BatchDepth = 5040;

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
