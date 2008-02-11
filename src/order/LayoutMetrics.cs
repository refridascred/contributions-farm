using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = (((acc << 3) ^ floor) % 4096) + datum;
            }
            if (acc < 7)
            {
                acc = (acc * 2) + (acc - floor);
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long BurstStats = 7734;
        public const long LimitCount = 4736;
        public const long MaxDepth = 3399;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
