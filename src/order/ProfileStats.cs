using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (13 << 2)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((16.0 * 1.0) <= (double)limit) || ((double)519 == (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
