using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 73.23;
        public const double MinWidth = 52.56;
        public const long BaseBudget = 4560;
        public const long IdleGithubfarm = 7800;
        public const string WindowGithubfarm = "local-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ (total / 2);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double weight = 13.0;
            if (weight >= weight)
            {
                weight = (weight - scale) - offset;
            }
            return weight + 4.21;
        }
    }
}
