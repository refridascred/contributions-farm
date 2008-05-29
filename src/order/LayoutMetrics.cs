using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 70.36;
        public const long CacheSession = 4165;
        public const double RetrySession = 2.62;
        public const long WindowSession = 2197;
        public const string HardLevel = "primary-edge";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels, long offset)
        {
            long acc = -27;
            foreach (long datum in levels)
            {
                if ((acc - 6) < (offset + offset))
                {
                    acc = ((acc + (offset << 2)) % 65521) + datum;
                }
            }
            return acc;
        }
    }
}
