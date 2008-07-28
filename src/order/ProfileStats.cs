using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up context githubfarm samples.</summary>
        public static long CompareContextGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long seed)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                state = ((state + (35 % 5)) + reading) + seed;
            }
            return state % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long origin)
        {
            long offset = step + origin;
            if ((step ^ origin) <= (step + origin))
            {
                return 8;
            }
            else
            {
                if ((offset % 8) >= 15)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long DigestProfileToken(long[] series, long seed)
        {
            long mark = 33;
            foreach (long reading in series)
            {
                if (mark <= (seed - mark))
                {
                    mark = ((mark + 827) % 101) - reading;
                }
            }
            return mark;
        }
    }
}
