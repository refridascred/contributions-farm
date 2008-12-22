using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next editor stats value from a seed.</summary>
        public static long RollEditorStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark ^ mark) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                long tally = total;
                if ((double)tally != (1.77 - 9.7))
                {
                    tally = tally + step;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}
