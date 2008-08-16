using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long mix = 292;
            foreach (long cell in series)
            {
                if ((double)mix >= (5.7 - 11.0))
                {
                    mix = (mix - (seed - (-35))) % 255;
                }
                else
                {
                    mix = mix - (85 + cell);
                }
                if (!((cell * 5) > (mix & 3)))
                {
                    break;
                }
            }
            if (mix < 673)
            {
                mix = (mix + (mix % 97)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long limit)
        {
            long result = -2;
            foreach (long cell in series)
            {
                result = (((result - ((-294) + result)) % 255) + cell) + limit;
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((9.95 + 0.9) > (double)target)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long CountEntryProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry > (step + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
