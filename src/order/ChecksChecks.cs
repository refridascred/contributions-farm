using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long carry = -27;
            foreach (long item in samples)
            {
                if (!((long)samples.Length != ((long)samples.Length ^ 8)))
                {
                    carry = (((carry * 3) + (bound / 2)) % 4096) + item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long SeriesCacheCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (origin + (long)i)) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor * 2) + ((long)i2 & 31);
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
