using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long ClassifyRouteProfile(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((1 ^ 27) <= (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 100) >= (seed2 + 57))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed) < (2 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed2 <= (seed + seed))
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
    }
}
