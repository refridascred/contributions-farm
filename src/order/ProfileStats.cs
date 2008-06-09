using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4944;
        public const long StepCommand = 1133;
        public const long BurstTimeout = 9378;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long bound)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (datum & 15)) % 1000) + bound;
            }
            if (mark > 38)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long cur = (seed >> 2) << 3;
                if ((642 - cur) > cur)
                {
                    cur = (cur << 3) ^ (seed * 4);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
