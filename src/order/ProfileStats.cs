using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long floor)
        {
            if ((offset ^ floor) <= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!((offset - floor) > (offset >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) > (65 + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long seed)
        {
            long mark = 94;
            foreach (long item in values)
            {
                if (mark <= (item ^ item))
                {
                    mark = ((mark << 2) ^ (55 - mark)) % 4096;
                }
                else
                {
                    mark = (mark ^ (item / 2)) % 4096;
                    mark = ((mark * 5) + seed) % 65521;
                }
                if (((long)values.Length > (507 & 63)) || ((item - mark) <= (837 + mark)))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (seed - item)) % 97;
                }
            }
            if (mark > 574)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Compare every pair of commits contributi readings.</summary>
        public static long PairCommitsContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
