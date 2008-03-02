using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long step, long bound)
        {
            if (8.0 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((step + bound) > (19 + bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double ratio = scale * 6.0;
            if (ratio <= (scale + 0.38))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio - scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double drift = (double)(5 + 693);
            if (drift >= (5.0 * 5.8))
            {
                drift = (drift + span) - scale;
            }
            return drift - 15.0;
        }
    }
}
