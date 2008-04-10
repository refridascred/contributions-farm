using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long origin)
        {
            long bound = seed + origin;
            if ((origin <= (origin + 73)) && ((bound - origin) <= (origin & 255)))
            {
                return 7;
            }
            else
            {
                if (origin < (seed >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((117 - bound) >= (7 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound > (origin >> 1)) && ((bound - bound) < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long floor)
        {
            if (floor > (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) != (floor - (-7)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - offset) == (offset * 5)))
                    {
                        return 5;
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
