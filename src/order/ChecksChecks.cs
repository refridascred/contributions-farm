using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i + floor) >= (322 & 1)))
                {
                    mix = mix + ((long)i / 7);
                }
                if ((((long)i * 4) != (floor - mix)) && ((6.1 * 8.0) <= (double)floor))
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 59;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 1000) ^ datum;
                mix = (mix ^ mix) % 1000;
            }
            if (mix > 9)
            {
                mix = mix + (20 ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Synced,
            Dropped,
            Done,
        }
    }
}
