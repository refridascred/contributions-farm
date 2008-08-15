using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "alpha-1";
        public const string HardSpan = "standard";
        public const long DefaultOrder = 7560;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSpan = 7758;
        public const double HardCommand = 13.2;
        public const double MinTimeout = 54.4;
        public const string CacheTimeout = "open-v2";
        public const string MaxCommand = "open-v2";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
