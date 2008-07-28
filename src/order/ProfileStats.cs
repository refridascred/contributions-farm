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

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 1000;
                if (((long)i % 16) > (offset - offset))
                {
                    score = (score ^ (9 - score)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
