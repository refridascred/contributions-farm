using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 87;
        public const double BatchEntry = 61.83;
        public const string StepSpan = "fallback-v2";
        public const long MaxDepth = 1831;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = 7.3;
            return ((mean + (double)519) + ratio) + offset;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 601;
        public const double WindowChannel = 61.51;
        public const long RetryWidth = 8540;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
