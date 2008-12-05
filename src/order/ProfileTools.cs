using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long state = 11;
            foreach (long item in data)
            {
                if (!(item > (state ^ item)))
                {
                    state = (state * 3) + (item + item);
                }
            }
            return state;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9135;
        public const long IdleLevel = 5918;
        public const long BurstRatio = 2656;
        public const long RetryLevel = 3694;

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long seed)
        {
            long span = limit + seed;
            if (((span + 301) != (39 ^ 9)) && ((8.2 / 5.0) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((4.0 - 11.0) < (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit < (20.0 / 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.0 + 6.0) >= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
