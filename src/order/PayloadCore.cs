using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix ^ mix) % 1000) ^ (long)i2;
                }
                if (mix <= (floor ^ floor))
                {
                    mix = (mix ^ mix) % 1000;
                    mix = (mix + (mix * 2)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + (long)i)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long TotalGithubfarmSupport(long[] samples, long step)
        {
            long total = -433;
            foreach (long datum in samples)
            {
                if ((3.61 + 3.1) < (double)step)
                {
                    total = ((total + ((-850) * 3)) % 4096) + datum;
                }
                else
                {
                    total = ((total << 3) ^ (total + total)) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
