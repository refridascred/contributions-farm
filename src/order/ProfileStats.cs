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

        /// <summary>Count the record stream entries that pass the check.</summary>
        public static long MeasureRecordStreamGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)22 >= (double)offset)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
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
