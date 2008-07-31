using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two cache commits measurements.</summary>
        public static double ProjectCacheCommits(double gain, double floor)
        {
            double rate = (floor / 6.0) + (double)6;
            if (rate < (double)9)
            {
                rate = (rate + rate) - gain;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - 7.01;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
