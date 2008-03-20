using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if ((origin ^ origin) < (origin + bound))
            {
                return 5;
            }
            else
            {
                if (origin < (origin + 313))
                {
                    return 6;
                }
                else
                {
                    if (!((origin - origin) == (6 % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) <= origin)
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long target, long bound)
        {
            if ((16.0 * 2.7) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((bound - target) >= 3)
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (double)(-39))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
