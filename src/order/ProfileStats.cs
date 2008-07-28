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

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 79.91;
        public const double IdleCommand = 9.71;
        public const double BaseFactor = 17.82;

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
