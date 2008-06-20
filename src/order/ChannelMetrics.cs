using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 11.68;
        public const long BurstGithubfarm = 4538;
        public const long BatchGithubfarm = 1237;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                if ((double)mix < (5.71 * 14.0))
                {
                    mix = ((mix + 727) % 65521) - reading;
                }
                else
                {
                    mix = ((mix << 3) ^ (471 & 7)) % 65521;
                }
            }
            if (mix < 136)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSize = 743;
        public const long MaxOrder = 651;
        public const double MaxDepth = 18.12;
        public const string BurstOrder = "fallback-v2";
    }
}
