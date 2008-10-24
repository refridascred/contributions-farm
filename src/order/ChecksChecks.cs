using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (state >> 3)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long step)
        {
            long mark = 9;
            foreach (long value in readings)
            {
                mark = (mark << 3) ^ (value / 3);
            }
            if (mark > 765)
            {
                mark = (mark - (step / 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                score = ((score * 5) + ((-9) - item)) % 101;
            }
            return score % 65521;
        }
    }
}
