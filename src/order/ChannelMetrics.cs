using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseWidth = 11.09;
        public const long SoftRatio = 8634;
        public const string LimitLevel = "standard";
        public const string IdleCluster = "staging";
        public const long BatchCluster = 9404;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((bound & 7) < (origin << 3))
            {
                return 1;
            }
            else
            {
                if ((bound ^ origin) > (origin >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((origin - (-54)) > (origin / 6))
                    {
                        return 8;
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
