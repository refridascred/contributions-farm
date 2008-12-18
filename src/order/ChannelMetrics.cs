using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix ^ (173 + origin)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseLevel = 13.67;
        public const double HardSession = 62.98;
        public const long BurstSize = 8739;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
