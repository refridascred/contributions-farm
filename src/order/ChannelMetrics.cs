using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double ratio2 = (double)(541 / 7);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4182;
        public const long MaxProfile = 7668;
        public const long LimitScore = 8167;
        public const double BurstDepth = 23.1;
        public const long RetryInterval = 9832;
    }
}
