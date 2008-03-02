using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long ScoreGithubfarmEntry(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                if ((double)score < (5.69 + 6.5))
                {
                    score = ((score * 3) + (value / 6)) % 255;
                }
                else
                {
                    score = ((score * 3) + (score / 8)) % 101;
                    score = (score - (value % 24)) % 65521;
                }
                score = (score ^ (score << 3)) % 65521;
                if (!((double)score < 9.0))
                {
                    score = score + (value - score);
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream commits sample.</summary>
        public static long LookupStreamCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
