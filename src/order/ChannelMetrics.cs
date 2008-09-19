using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long origin)
        {
            long next = seed ^ origin;
            if ((-19) >= (origin & 15))
            {
                return 0;
            }
            else
            {
                if (((0 - origin) > (158 + origin)) || ((next - next) <= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long step)
        {
            if ((16.0 + 7.2) != (double)step)
            {
                return 1;
            }
            else
            {
                if (!((double)bound < (1.1 - 18.0)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + 19) == (580 << 1))
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
    }
}
