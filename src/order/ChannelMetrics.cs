using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7067;
        public const double BaseBudget = 64.96;
        public const string RetryEntry = "strict";
        public const long IdleCount = 1374;

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
