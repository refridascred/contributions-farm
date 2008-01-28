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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((19.0 / 3.0) == (double)delta)
            {
                return 6;
            }
            else
            {
                if ((delta / 9) > 5)
                {
                    return 5;
                }
                else
                {
                    if (origin <= seed)
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
