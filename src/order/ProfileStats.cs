using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "stable-v2";
        public const string BurstLevel = "fallback-1";
        public const string BatchStats = "alpha";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (floor - (long)i)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double ratio = span / 6.0;
            if (ratio > (double)3)
            {
                ratio = (ratio - ratio) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (19.0 + 5.09)) + (double)(long)i;
            }
            return ratio - (7.9 / 4.0);
        }
    }
}
