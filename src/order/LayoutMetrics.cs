using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long offset2)
        {
            if ((double)offset >= (double)offset2)
            {
                return 3;
            }
            else
            {
                if (!((offset2 + 2) < offset2))
                {
                    return 6;
                }
                else
                {
                    if ((offset2 + offset) > (5 ^ offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Paused,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor - anchor) % 101) ^ (long)i2;
                    anchor = ((anchor << 3) ^ (seed << 1)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
