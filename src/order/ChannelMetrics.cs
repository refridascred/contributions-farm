using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell > (6.8 * 4.76)) || ((13.0 * 0.7) < (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 7033;
        public const string HardContext = "latest-edge";
        public const long BurstSize = 204;
        public const string SoftSize = "cached";
        public const double SoftInterval = 87.11;
    }
}
