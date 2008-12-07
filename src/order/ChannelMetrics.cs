using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "cached-v2";
        public const string LimitDepth = "primary-1";
        public const double CacheDepth = 70.94;

        /// <summary>Derive the next checks order value from a seed.</summary>
        public static long StepChecksOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + mix) % 255;
                mix = mix - (mix - origin);
                mix = ((mix * 3) + ((long)i - (-4))) % 4096;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
